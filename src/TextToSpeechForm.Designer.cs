namespace JNSoundboard
{
    partial class TextToSpeechForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToSpeechForm));
            this.label3 = new System.Windows.Forms.Label();
            this.vsSoundVolume = new NAudio.Gui.VolumeSlider();
            this.cbAddToList = new System.Windows.Forms.CheckBox();
            this.preview = new System.Windows.Forms.Button();
            this.btnCreateWAV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKeys = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.keysTimer = new System.Windows.Forms.Timer(this.components);
            this.nSoundVolume = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWindows = new System.Windows.Forms.ComboBox();
            this.btnReloadWindows = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.clearHotkey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.stopPreview = new System.Windows.Forms.Button();
            this.btnPlayThroughMic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Custom volume";
            // 
            // vsSoundVolume
            // 
            this.vsSoundVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vsSoundVolume.Location = new System.Drawing.Point(12, 282);
            this.vsSoundVolume.Name = "vsSoundVolume";
            this.vsSoundVolume.Size = new System.Drawing.Size(213, 20);
            this.vsSoundVolume.TabIndex = 117;
            this.vsSoundVolume.TabStop = false;
            this.vsSoundVolume.VolumeChanged += new System.EventHandler(this.vsSoundVolume_VolumeChanged);
            this.vsSoundVolume.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.vsSoundVolume_MouseWheel);
            // 
            // cbAddToList
            // 
            this.cbAddToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAddToList.AutoSize = true;
            this.cbAddToList.Location = new System.Drawing.Point(12, 197);
            this.cbAddToList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbAddToList.Name = "cbAddToList";
            this.cbAddToList.Size = new System.Drawing.Size(72, 17);
            this.cbAddToList.TabIndex = 105;
            this.cbAddToList.Text = "Add to list";
            this.cbAddToList.UseVisualStyleBackColor = true;
            this.cbAddToList.CheckedChanged += new System.EventHandler(this.cbAddToList_CheckedChanged);
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.AutoSize = true;
            this.preview.Location = new System.Drawing.Point(161, 161);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(75, 23);
            this.preview.TabIndex = 104;
            this.preview.Text = "Preview";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // btnCreateWAV
            // 
            this.btnCreateWAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateWAV.Location = new System.Drawing.Point(141, 360);
            this.btnCreateWAV.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCreateWAV.Name = "btnCreateWAV";
            this.btnCreateWAV.Size = new System.Drawing.Size(100, 23);
            this.btnCreateWAV.TabIndex = 112;
            this.btnCreateWAV.Text = "Create WAV";
            this.btnCreateWAV.UseVisualStyleBackColor = true;
            this.btnCreateWAV.Click += new System.EventHandler(this.btnCreateWAV_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Keys (optional)";
            // 
            // tbKeys
            // 
            this.tbKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKeys.Location = new System.Drawing.Point(12, 238);
            this.tbKeys.Name = "tbKeys";
            this.tbKeys.ReadOnly = true;
            this.tbKeys.ShortcutsEnabled = false;
            this.tbKeys.Size = new System.Drawing.Size(213, 20);
            this.tbKeys.TabIndex = 106;
            this.tbKeys.Enter += new System.EventHandler(this.tbKeys_Enter);
            this.tbKeys.Leave += new System.EventHandler(this.tbKeys_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(247, 360);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 113;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // keysTimer
            // 
            this.keysTimer.Tick += new System.EventHandler(this.keysTimer_Tick);
            // 
            // nSoundVolume
            // 
            this.nSoundVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nSoundVolume.Location = new System.Drawing.Point(231, 282);
            this.nSoundVolume.Name = "nSoundVolume";
            this.nSoundVolume.Size = new System.Drawing.Size(39, 20);
            this.nSoundVolume.TabIndex = 108;
            this.nSoundVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nSoundVolume.ValueChanged += new System.EventHandler(this.nSoundVolume_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Restrict to a certain window";
            // 
            // cbWindows
            // 
            this.cbWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbWindows.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWindows.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWindows.FormattingEnabled = true;
            this.cbWindows.Location = new System.Drawing.Point(12, 326);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(213, 21);
            this.cbWindows.TabIndex = 110;
            // 
            // btnReloadWindows
            // 
            this.btnReloadWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReloadWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadWindows.Image")));
            this.btnReloadWindows.Location = new System.Drawing.Point(231, 325);
            this.btnReloadWindows.Name = "btnReloadWindows";
            this.btnReloadWindows.Size = new System.Drawing.Size(22, 23);
            this.btnReloadWindows.TabIndex = 111;
            this.btnReloadWindows.UseVisualStyleBackColor = true;
            this.btnReloadWindows.Click += new System.EventHandler(this.btnReloadWindows_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(12, 163);
            this.cbGender.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(120, 21);
            this.cbGender.TabIndex = 103;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // clearHotkey
            // 
            this.clearHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearHotkey.ForeColor = System.Drawing.Color.Red;
            this.clearHotkey.Location = new System.Drawing.Point(231, 237);
            this.clearHotkey.Name = "clearHotkey";
            this.clearHotkey.Size = new System.Drawing.Size(22, 22);
            this.clearHotkey.TabIndex = 107;
            this.clearHotkey.Text = "X";
            this.clearHotkey.UseVisualStyleBackColor = true;
            this.clearHotkey.Click += new System.EventHandler(this.clearHotkey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Text";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(12, 74);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(310, 65);
            this.tbText.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(12, 29);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(310, 20);
            this.tbName.TabIndex = 100;
            // 
            // stopPreview
            // 
            this.stopPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopPreview.AutoSize = true;
            this.stopPreview.Location = new System.Drawing.Point(242, 162);
            this.stopPreview.Name = "stopPreview";
            this.stopPreview.Size = new System.Drawing.Size(80, 23);
            this.stopPreview.TabIndex = 119;
            this.stopPreview.Text = "Stop Preview";
            this.stopPreview.UseVisualStyleBackColor = true;
            this.stopPreview.Click += new System.EventHandler(this.stopPreview_Click);
            // 
            // btnPlayThroughMic
            // 
            this.btnPlayThroughMic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayThroughMic.AutoSize = true;
            this.btnPlayThroughMic.Location = new System.Drawing.Point(161, 190);
            this.btnPlayThroughMic.Name = "btnPlayThroughMic";
            this.btnPlayThroughMic.Size = new System.Drawing.Size(161, 23);
            this.btnPlayThroughMic.TabIndex = 120;
            this.btnPlayThroughMic.Text = "Play Through Mic";
            this.btnPlayThroughMic.UseVisualStyleBackColor = true;
            this.btnPlayThroughMic.Click += new System.EventHandler(this.btnPlayThroughMic_Click);
            // 
            // TextToSpeechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 394);
            this.Controls.Add(this.btnPlayThroughMic);
            this.Controls.Add(this.stopPreview);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vsSoundVolume);
            this.Controls.Add(this.cbAddToList);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.btnCreateWAV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKeys);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nSoundVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbWindows);
            this.Controls.Add(this.btnReloadWindows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.clearHotkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 385);
            this.Name = "TextToSpeechForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text-to-speech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextToSpeechForm_FormClosing);
            this.Load += new System.EventHandler(this.TTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private NAudio.Gui.VolumeSlider vsSoundVolume;
        private System.Windows.Forms.CheckBox cbAddToList;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Button btnCreateWAV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKeys;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer keysTimer;
        private System.Windows.Forms.NumericUpDown nSoundVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbWindows;
        private System.Windows.Forms.Button btnReloadWindows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button clearHotkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button stopPreview;
        private System.Windows.Forms.Button btnPlayThroughMic;
    }
}