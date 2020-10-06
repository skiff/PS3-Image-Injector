namespace PS3_Image_Injector
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose (bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose ();
         }
         base.Dispose (disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent ()
      {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormTheme = new Teen.ThirteenForm();
            this.MainFormControlBox = new Teen.ThirteenControlBox();
            this.SelectGameLabel = new System.Windows.Forms.Label();
            this.ImagesGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.AssetProgressBar = new System.Windows.Forms.ProgressBar();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.PointerLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AssetListBox = new System.Windows.Forms.ListBox();
            this.ConnectAttachButton = new Teen.ThirteenButton();
            this.RefreshImagesButton = new Teen.ThirteenButton();
            this.SelectGameComboBox = new Teen.ThirteenComboBox();
            this.SearchTextBox = new Teen.ThirteenTextBox();
            this.PreviewImageButton = new Teen.ThirteenButton();
            this.DumpImageButton = new Teen.ThirteenButton();
            this.InjectImageButton = new Teen.ThirteenButton();
            this.SaveImagesToFileButton = new Teen.ThirteenButton();
            this.MainFormTheme.SuspendLayout();
            this.ImagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTheme
            // 
            this.MainFormTheme.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.MainFormTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainFormTheme.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.MainFormTheme.Controls.Add(this.SelectGameComboBox);
            this.MainFormTheme.Controls.Add(this.RefreshImagesButton);
            this.MainFormTheme.Controls.Add(this.ConnectAttachButton);
            this.MainFormTheme.Controls.Add(this.MainFormControlBox);
            this.MainFormTheme.Controls.Add(this.SelectGameLabel);
            this.MainFormTheme.Controls.Add(this.ImagesGroupBox);
            this.MainFormTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormTheme.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.MainFormTheme.ForeColor = System.Drawing.Color.White;
            this.MainFormTheme.Location = new System.Drawing.Point(0, 0);
            this.MainFormTheme.Name = "MainFormTheme";
            this.MainFormTheme.Size = new System.Drawing.Size(807, 719);
            this.MainFormTheme.TabIndex = 0;
            this.MainFormTheme.Text = "Jimtrix Image Injector";
            // 
            // MainFormControlBox
            // 
            this.MainFormControlBox.AccentColor = System.Drawing.Color.DodgerBlue;
            this.MainFormControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainFormControlBox.ColorScheme = Teen.ThirteenControlBox.ColorSchemes.Dark;
            this.MainFormControlBox.ForeColor = System.Drawing.Color.White;
            this.MainFormControlBox.Location = new System.Drawing.Point(653, 3);
            this.MainFormControlBox.Name = "MainFormControlBox";
            this.MainFormControlBox.Size = new System.Drawing.Size(100, 25);
            this.MainFormControlBox.TabIndex = 22;
            this.MainFormControlBox.Text = "Control Box";
            // 
            // SelectGameLabel
            // 
            this.SelectGameLabel.AutoSize = true;
            this.SelectGameLabel.Location = new System.Drawing.Point(544, 62);
            this.SelectGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectGameLabel.Name = "SelectGameLabel";
            this.SelectGameLabel.Size = new System.Drawing.Size(139, 28);
            this.SelectGameLabel.TabIndex = 21;
            this.SelectGameLabel.Text = "Select A Game:";
            // 
            // ImagesGroupBox
            // 
            this.ImagesGroupBox.Controls.Add(this.SaveImagesToFileButton);
            this.ImagesGroupBox.Controls.Add(this.InjectImageButton);
            this.ImagesGroupBox.Controls.Add(this.DumpImageButton);
            this.ImagesGroupBox.Controls.Add(this.PreviewImageButton);
            this.ImagesGroupBox.Controls.Add(this.SearchTextBox);
            this.ImagesGroupBox.Controls.Add(this.ProgressBarLabel);
            this.ImagesGroupBox.Controls.Add(this.AssetProgressBar);
            this.ImagesGroupBox.Controls.Add(this.FormatLabel);
            this.ImagesGroupBox.Controls.Add(this.SearchLabel);
            this.ImagesGroupBox.Controls.Add(this.PointerLabel);
            this.ImagesGroupBox.Controls.Add(this.SizeLabel);
            this.ImagesGroupBox.Controls.Add(this.HeightLabel);
            this.ImagesGroupBox.Controls.Add(this.WidthLabel);
            this.ImagesGroupBox.Controls.Add(this.NameLabel);
            this.ImagesGroupBox.Controls.Add(this.AssetListBox);
            this.ImagesGroupBox.ForeColor = System.Drawing.Color.White;
            this.ImagesGroupBox.Location = new System.Drawing.Point(13, 148);
            this.ImagesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagesGroupBox.Name = "ImagesGroupBox";
            this.ImagesGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImagesGroupBox.Size = new System.Drawing.Size(781, 552);
            this.ImagesGroupBox.TabIndex = 18;
            this.ImagesGroupBox.TabStop = false;
            this.ImagesGroupBox.Text = "Images";
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Location = new System.Drawing.Point(420, 470);
            this.ProgressBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(124, 28);
            this.ProgressBarLabel.TabIndex = 16;
            this.ProgressBarLabel.Text = "Progress: 0/0";
            // 
            // AssetProgressBar
            // 
            this.AssetProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.AssetProgressBar.Location = new System.Drawing.Point(420, 504);
            this.AssetProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssetProgressBar.MarqueeAnimationSpeed = 10;
            this.AssetProgressBar.Name = "AssetProgressBar";
            this.AssetProgressBar.Size = new System.Drawing.Size(353, 31);
            this.AssetProgressBar.Step = 1;
            this.AssetProgressBar.TabIndex = 15;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(416, 127);
            this.FormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(77, 28);
            this.FormatLabel.TabIndex = 13;
            this.FormatLabel.Text = "Format:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(416, 167);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(150, 28);
            this.SearchLabel.TabIndex = 11;
            this.SearchLabel.Text = "Search Materials";
            // 
            // PointerLabel
            // 
            this.PointerLabel.AutoSize = true;
            this.PointerLabel.Location = new System.Drawing.Point(416, 63);
            this.PointerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointerLabel.Name = "PointerLabel";
            this.PointerLabel.Size = new System.Drawing.Size(76, 28);
            this.PointerLabel.TabIndex = 10;
            this.PointerLabel.Text = "Pointer:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Location = new System.Drawing.Point(607, 63);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(166, 28);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(607, 95);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(166, 28);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(416, 95);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(66, 28);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(416, 31);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 28);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // AssetListBox
            // 
            this.AssetListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AssetListBox.ForeColor = System.Drawing.Color.White;
            this.AssetListBox.FormattingEnabled = true;
            this.AssetListBox.ItemHeight = 28;
            this.AssetListBox.Location = new System.Drawing.Point(10, 31);
            this.AssetListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssetListBox.Name = "AssetListBox";
            this.AssetListBox.Size = new System.Drawing.Size(398, 508);
            this.AssetListBox.TabIndex = 0;
            this.AssetListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.AssetListBox_DrawItem);
            this.AssetListBox.SelectedValueChanged += new System.EventHandler(this.AssetListBox_SelectedValueChanged);
            // 
            // ConnectAttachButton
            // 
            this.ConnectAttachButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectAttachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ConnectAttachButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.ConnectAttachButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.ConnectAttachButton.ForeColor = System.Drawing.Color.White;
            this.ConnectAttachButton.Location = new System.Drawing.Point(18, 63);
            this.ConnectAttachButton.Name = "ConnectAttachButton";
            this.ConnectAttachButton.Size = new System.Drawing.Size(257, 74);
            this.ConnectAttachButton.TabIndex = 23;
            this.ConnectAttachButton.Text = "Connect/Attach";
            this.ConnectAttachButton.UseVisualStyleBackColor = false;
            this.ConnectAttachButton.Click += new System.EventHandler(this.ConnectAttachButton_Click);
            // 
            // RefreshImagesButton
            // 
            this.RefreshImagesButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshImagesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RefreshImagesButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.RefreshImagesButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.RefreshImagesButton.ForeColor = System.Drawing.Color.White;
            this.RefreshImagesButton.Location = new System.Drawing.Point(281, 63);
            this.RefreshImagesButton.Name = "RefreshImagesButton";
            this.RefreshImagesButton.Size = new System.Drawing.Size(257, 74);
            this.RefreshImagesButton.TabIndex = 24;
            this.RefreshImagesButton.Text = "Refresh Images";
            this.RefreshImagesButton.UseVisualStyleBackColor = false;
            this.RefreshImagesButton.Click += new System.EventHandler(this.RefreshImagesButton_Click);
            // 
            // SelectGameComboBox
            // 
            this.SelectGameComboBox.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.SelectGameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectGameComboBox.ColorScheme = Teen.ThirteenComboBox.ColorSchemes.Dark;
            this.SelectGameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectGameComboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.SelectGameComboBox.ForeColor = System.Drawing.Color.White;
            this.SelectGameComboBox.FormattingEnabled = true;
            this.SelectGameComboBox.Items.AddRange(new object[] {
            "Modern Warfare 2 (1.14)",
            "Black Ops (1.13)",
            "Modern Warfare 3 (1.24)",
            "Black Ops 2 (1.19)",
            "Ghosts (1.16)",
            "Ghosts (1.02)"});
            this.SelectGameComboBox.Location = new System.Drawing.Point(549, 97);
            this.SelectGameComboBox.Name = "SelectGameComboBox";
            this.SelectGameComboBox.Size = new System.Drawing.Size(249, 34);
            this.SelectGameComboBox.TabIndex = 18;
            this.SelectGameComboBox.TextChanged += new System.EventHandler(this.SelectGameComboBox_TextChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.SearchTextBox.ForeColor = System.Drawing.Color.White;
            this.SearchTextBox.Location = new System.Drawing.Point(422, 198);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(351, 33);
            this.SearchTextBox.TabIndex = 18;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // PreviewImageButton
            // 
            this.PreviewImageButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.PreviewImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PreviewImageButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.PreviewImageButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.PreviewImageButton.ForeColor = System.Drawing.Color.White;
            this.PreviewImageButton.Location = new System.Drawing.Point(420, 246);
            this.PreviewImageButton.Name = "PreviewImageButton";
            this.PreviewImageButton.Size = new System.Drawing.Size(353, 51);
            this.PreviewImageButton.TabIndex = 19;
            this.PreviewImageButton.Text = "Preview Image";
            this.PreviewImageButton.UseVisualStyleBackColor = false;
            this.PreviewImageButton.Click += new System.EventHandler(this.PreviewImageButton_Click);
            // 
            // DumpImageButton
            // 
            this.DumpImageButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.DumpImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DumpImageButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.DumpImageButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.DumpImageButton.ForeColor = System.Drawing.Color.White;
            this.DumpImageButton.Location = new System.Drawing.Point(420, 300);
            this.DumpImageButton.Name = "DumpImageButton";
            this.DumpImageButton.Size = new System.Drawing.Size(353, 51);
            this.DumpImageButton.TabIndex = 20;
            this.DumpImageButton.Text = "Dump Image";
            this.DumpImageButton.UseVisualStyleBackColor = false;
            this.DumpImageButton.Click += new System.EventHandler(this.DumpImageButton_Click);
            // 
            // InjectImageButton
            // 
            this.InjectImageButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.InjectImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InjectImageButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.InjectImageButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.InjectImageButton.ForeColor = System.Drawing.Color.White;
            this.InjectImageButton.Location = new System.Drawing.Point(420, 354);
            this.InjectImageButton.Name = "InjectImageButton";
            this.InjectImageButton.Size = new System.Drawing.Size(353, 51);
            this.InjectImageButton.TabIndex = 21;
            this.InjectImageButton.Text = "Inject Image";
            this.InjectImageButton.UseVisualStyleBackColor = false;
            this.InjectImageButton.Click += new System.EventHandler(this.InjectImageButton_Click);
            // 
            // SaveImagesToFileButton
            // 
            this.SaveImagesToFileButton.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.SaveImagesToFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveImagesToFileButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.SaveImagesToFileButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.SaveImagesToFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveImagesToFileButton.Location = new System.Drawing.Point(420, 408);
            this.SaveImagesToFileButton.Name = "SaveImagesToFileButton";
            this.SaveImagesToFileButton.Size = new System.Drawing.Size(353, 51);
            this.SaveImagesToFileButton.TabIndex = 22;
            this.SaveImagesToFileButton.Text = "Save Image Names to File";
            this.SaveImagesToFileButton.UseVisualStyleBackColor = false;
            this.SaveImagesToFileButton.Click += new System.EventHandler(this.SaveImagesToFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 719);
            this.Controls.Add(this.MainFormTheme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Jimtrix Image Injector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainFormTheme.ResumeLayout(false);
            this.MainFormTheme.PerformLayout();
            this.ImagesGroupBox.ResumeLayout(false);
            this.ImagesGroupBox.PerformLayout();
            this.ResumeLayout(false);

      }

        #endregion

        private Teen.ThirteenForm MainFormTheme;
        private Teen.ThirteenControlBox MainFormControlBox;
        private System.Windows.Forms.Label SelectGameLabel;
        private System.Windows.Forms.GroupBox ImagesGroupBox;
        public System.Windows.Forms.Label ProgressBarLabel;
        public System.Windows.Forms.ProgressBar AssetProgressBar;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label PointerLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.ListBox AssetListBox;
        private Teen.ThirteenButton ConnectAttachButton;
        private Teen.ThirteenButton RefreshImagesButton;
        private Teen.ThirteenComboBox SelectGameComboBox;
        private Teen.ThirteenTextBox SearchTextBox;
        private Teen.ThirteenButton PreviewImageButton;
        private Teen.ThirteenButton DumpImageButton;
        private Teen.ThirteenButton InjectImageButton;
        private Teen.ThirteenButton SaveImagesToFileButton;
    }
}

