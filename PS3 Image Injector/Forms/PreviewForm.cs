using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS3_Image_Injector {
    public partial class PreviewForm : Form {
        public PreviewForm(String name, byte[] image, Int16 width, Int16 height) {
            InitializeComponent();

            try {
                this.Text = name;
                this.Width = width + 19;
                this.Height = height + 44;

                this.PreviewFormTheme.Text = name;
                this.PreviewFormTheme.Width = width + 19;
                this.PreviewFormTheme.Height = height + 44;

                this.PreviewPictureBox.Width = width + 15;
                this.PreviewPictureBox.Height = height + 40;
                this.PreviewPictureBox.Image = new DDSImage(image).BitmapImage;
            }
            catch {
                throw new Exception();
            }
        }
    }
}
