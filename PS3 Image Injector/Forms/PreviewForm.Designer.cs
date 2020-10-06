namespace PS3_Image_Injector
{
   partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.PreviewFormTheme = new Teen.ThirteenForm();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.thirteenControlBox1 = new Teen.ThirteenControlBox();
            this.PreviewFormTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewFormTheme
            // 
            this.PreviewFormTheme.AccentColor = System.Drawing.Color.WhiteSmoke;
            this.PreviewFormTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PreviewFormTheme.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.PreviewFormTheme.Controls.Add(this.thirteenControlBox1);
            this.PreviewFormTheme.Controls.Add(this.PreviewPictureBox);
            this.PreviewFormTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewFormTheme.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.PreviewFormTheme.ForeColor = System.Drawing.Color.White;
            this.PreviewFormTheme.Location = new System.Drawing.Point(0, 0);
            this.PreviewFormTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreviewFormTheme.Name = "PreviewFormTheme";
            this.PreviewFormTheme.Size = new System.Drawing.Size(415, 337);
            this.PreviewFormTheme.TabIndex = 0;
            this.PreviewFormTheme.Text = "Image Previewer";
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Location = new System.Drawing.Point(8, 36);
            this.PreviewPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(399, 293);
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // thirteenControlBox1
            // 
            this.thirteenControlBox1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenControlBox1.ColorScheme = Teen.ThirteenControlBox.ColorSchemes.Dark;
            this.thirteenControlBox1.ForeColor = System.Drawing.Color.White;
            this.thirteenControlBox1.Location = new System.Drawing.Point(311, 3);
            this.thirteenControlBox1.Name = "thirteenControlBox1";
            this.thirteenControlBox1.Size = new System.Drawing.Size(100, 25);
            this.thirteenControlBox1.TabIndex = 1;
            this.thirteenControlBox1.Text = "thirteenControlBox1";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 337);
            this.Controls.Add(this.PreviewFormTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewForm";
            this.Text = "Image Preview";
            this.PreviewFormTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.ResumeLayout(false);

      }

        #endregion

        private Teen.ThirteenForm PreviewFormTheme;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private Teen.ThirteenControlBox thirteenControlBox1;
    }
}