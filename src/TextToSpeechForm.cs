using NAudio.Wave;
using System;
using System.Diagnostics;
using System.IO;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace JNSoundboard
{
    public partial class TextToSpeechForm : Form
    {
        MainForm mainForm;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        Prompt previewPrompt;

        internal static int lastGenderIndex = 0;
        internal static bool lastAddToListChecked = false;
        internal static string lastWindow = "";
        internal static float lastSoundVolume = 1;

        public VoiceGender Gender { get; set; } = VoiceGender.Neutral;

        public TextToSpeechForm()
        {
            InitializeComponent();
        }

        private void TTS_Load(object sender, EventArgs e)
        {
            mainForm = Application.OpenForms[0] as MainForm;

            cbGender.SelectedIndex = lastGenderIndex;
            Gender = (VoiceGender)cbGender.SelectedIndex + 1; //1 = Male; 2 = Female

            cbAddToList.Checked = lastAddToListChecked;
            tbKeys.Enabled = lastAddToListChecked;
            clearHotkey.Enabled = lastAddToListChecked;
            cbWindows.Enabled = lastAddToListChecked;
            btnReloadWindows.Enabled = lastAddToListChecked;
            vsSoundVolume.Enabled = lastAddToListChecked;
            nSoundVolume.Enabled = lastAddToListChecked;

            vsSoundVolume.Volume = lastSoundVolume;

            Helper.getWindows(cbWindows);
            Helper.selectWindow(cbWindows, lastWindow);
        }

        private void btnCreateWAV_Click(object sender, EventArgs e)
        {
            string[] fileLocation;

            if (!string.IsNullOrWhiteSpace(tbText.Text))
            {
                //show dialog
                var diag = new SaveFileDialog();
                diag.Filter = "WAV files|*.wav";

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = new string[] { diag.FileName };
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No text entered");
                return;
            }

            //create file
            synth.SelectVoiceByHints(Gender, VoiceAge.NotSet);
            synth.SetOutputToWaveFile(fileLocation[0]);

            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(tbText.Text);

            synth.Speak(builder);

            synth.Dispose();
            synth = null;

            if (cbAddToList.Checked)
            {
                //add to list
                if (!Helper.stringToKeysArray(tbKeys.Text, out Keyboard.Keys[] keysArray, out _)) keysArray = new Keyboard.Keys[] { };

                string windowText = (cbWindows.SelectedIndex > 0) ? cbWindows.Text : "";

                mainForm.soundHotkeys.Add(new XMLSettings.SoundHotkey(tbName.Text, keysArray, vsSoundVolume.Volume, windowText, fileLocation));

                var newItem = new ListViewItem(tbKeys.Text);
                newItem.SubItems.Add(vsSoundVolume.Volume == 1 ? "" : Helper.linearVolumeToString(vsSoundVolume.Volume));
                newItem.SubItems.Add(windowText);
                newItem.SubItems.Add(fileLocation[0]);

                newItem.ToolTipText = Helper.getFileNamesTooltip(fileLocation);

                mainForm.lvKeySounds.Items.Add(newItem);

                mainForm.sortHotkeys();

                //remember last used options
                lastWindow = cbWindows.Text;
                lastSoundVolume = vsSoundVolume.Volume;
            }

            //remember last used options
            lastGenderIndex = cbGender.SelectedIndex;
            lastAddToListChecked = cbAddToList.Checked;

            MessageBox.Show("Saved: " + fileLocation[0]);

            this.Close(); //don't know if this wasn't added before or if I deleted it or what...
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (previewPrompt != null) StopPreview();
            this.Close();
        }

        private void tbKeys_Enter(object sender, EventArgs e)
        {
            keysTimer.Enabled = true;
        }

        private void tbKeys_Leave(object sender, EventArgs e)
        {
            keysTimer.Enabled = false;
            keysTimer.Interval = 100;
        }


        int lastAmountPressed = 0;
        private void keysTimer_Tick(object sender, EventArgs e)
        {
            keysTimer.Interval = 10; //lowering the interval to avoid missing key presses (e.g. when an input is corrected)

            var keysData = Keyboard.getKeys(lastAmountPressed, tbKeys.Text);

            lastAmountPressed = keysData.Item1;
            tbKeys.Text = keysData.Item2;
        }

        private void clearHotkey_Click(object sender, EventArgs e)
        {
            tbKeys.Text = "";
        }

        private void preview_Click(object sender, EventArgs e)
        {
            StopPreview();

            if (!string.IsNullOrWhiteSpace(tbText.Text))
            {
                synth.SelectVoiceByHints(Gender, VoiceAge.NotSet);
                previewPrompt = synth.SpeakAsync(tbText.Text);
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = (VoiceGender)cbGender.SelectedIndex + 1; //1 = Male; 2 = Female
        }

        private void stopPreview_Click(object sender, EventArgs e)
        {
            StopPreview();
        }

        private void StopPreview()
        {
            if (synth.State == SynthesizerState.Speaking) synth.SpeakAsyncCancel(previewPrompt);
        }

        private void btnReloadWindows_Click(object sender, EventArgs e)
        {
            Helper.getWindows(cbWindows);
        }

        private void cbAddToList_CheckedChanged(object sender, EventArgs e)
        {
            tbKeys.Enabled = cbAddToList.Checked;
            clearHotkey.Enabled = cbAddToList.Checked;
            cbWindows.Enabled = cbAddToList.Checked;
            btnReloadWindows.Enabled = cbAddToList.Checked;
            vsSoundVolume.Enabled = cbAddToList.Checked;
            nSoundVolume.Enabled = cbAddToList.Checked;
        }


        private bool volumeChangedBySlider = false;
        private bool volumeChangedByField = false;
        public void vsSoundVolume_VolumeChanged(object sender, EventArgs e)
        {
            //prevent infinite or skipped changes
            if (volumeChangedByField)
            {
                volumeChangedByField = false;

                return;
            }

            volumeChangedBySlider = true;

            nSoundVolume.Value = Helper.linearVolumeToInteger(vsSoundVolume.Volume);
        }

        public void vsSoundVolume_MouseWheel(object sender, MouseEventArgs e)
        {
            vsSoundVolume.Volume = Helper.getNewSoundVolume(vsSoundVolume.Volume, e.Delta);
        }

        public void nSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            //prevent infinite or skipped changes
            if (volumeChangedBySlider)
            {
                volumeChangedBySlider = false;

                return;
            }

            volumeChangedByField = true;

            vsSoundVolume.Volume = (float)(nSoundVolume.Value / 100);
        }

        MemoryStream ms;
        NAudio.Wave.RawSourceWaveStream rsws;
        SpeechAudioFormatInfo synthFormat;
        private void btnPlayThroughMic_Click(object sender, EventArgs e)
        {
            if (synthFormat == null)
            {
                synthFormat = new SpeechAudioFormatInfo(44100, AudioBitsPerSample.Sixteen, AudioChannel.Mono);//SpeechAudioFormatInfo(EncodingFormat.Pcm, 88200, 16, 1, 16000, 2, null);
            }
            ms?.Dispose();
            rsws?.Dispose();

            ms = new MemoryStream();
            
            synth.SetOutputToWaveStream(ms);
            synth.Speak(tbText.Text);

            rsws = new RawSourceWaveStream(ms, WaveFormat.CreateIeeeFloatWaveFormat(44100, 2));

            //using (RawSourceWaveStream rsws = new RawSourceWaveStream(ms, WaveFormat.CreateIeeeFloatWaveFormat(44100, 2)))// new WaveFormat(41000, 16, 1)))
            //using (NAudio.Wave.WaveFileReader wfr = new NAudio.Wave.WaveFileReader(ms))
            mainForm.stopPlayback();
            mainForm.playSound(rsws, 1, MainForm.VolumeType.Private);
            mainForm.playSound(rsws, 1, MainForm.VolumeType.Public);

            

            //wfr = new NAudio.Wave.WaveFileReader(ms);
        }

        private void TextToSpeechForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms?.Dispose();
            rsws?.Dispose();
        }
    }
}
