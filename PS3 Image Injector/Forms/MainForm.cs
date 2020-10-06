using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PS3_Image_Injector {
    public partial class MainForm : Form {
        private static TMAPI PS3 = new TMAPI();
        private static PS3RPC PS3RPC = new PS3RPC(PS3);
        private static Color AccentColor = Color.WhiteSmoke;

        public MainForm() {
            InitializeComponent();

            AssetListBox.DisplayMember = "Name";

            SelectGameComboBox.Text = Properties.Settings.Default.Game;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Game = SelectGameComboBox.Text;
            Properties.Settings.Default.Save();
        }

        private void ChangeAccentColors(string Game) {
            if (SelectGameComboBox.Text.Equals("Modern Warfare 2 (1.14)"))
                AccentColor = Color.DarkViolet;

            else if (SelectGameComboBox.Text.Equals("Black Ops (1.13)"))
                AccentColor = Color.Firebrick;

            else if (SelectGameComboBox.Text.Equals("Modern Warfare 3 (1.24)"))
                AccentColor = Color.SteelBlue;

            else if (SelectGameComboBox.Text.Equals("Black Ops 2 (1.19)"))
                AccentColor = Color.OrangeRed;

            else if (SelectGameComboBox.Text.Equals("Ghosts (1.16)"))
                AccentColor = Color.Goldenrod;

            else if (SelectGameComboBox.Text.Equals("Ghosts (1.02)"))
                AccentColor = Color.Goldenrod;

            this.MainFormTheme.AccentColor = AccentColor;
            this.ConnectAttachButton.AccentColor = AccentColor;
            this.RefreshImagesButton.AccentColor = AccentColor;
            this.SelectGameComboBox.AccentColor = AccentColor;
            this.PreviewImageButton.AccentColor = AccentColor;
            this.DumpImageButton.AccentColor = AccentColor;
            this.InjectImageButton.AccentColor = AccentColor;
            this.SaveImagesToFileButton.AccentColor = AccentColor;
            this.MainFormControlBox.AccentColor = AccentColor;
        }

        private void AssetListBox_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index < 0)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, AccentColor);

            e.DrawBackground();
            e.Graphics.DrawString(AssetListBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void SelectGameComboBox_TextChanged(object sender, EventArgs e) {
            ChangeAccentColors(SelectGameComboBox.Text);
        }

        private void ConnectAttachButton_Click(object sender, EventArgs e) {
            try {
                PS3.ConnectTarget();
                PS3.AttachProcess();

                if (!PS3RPC.Install())
                    throw new Exception("RPC Failed to install");
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to connect and attach to PS3\n\n" + ex.Message, "Connection Error!");
            }
        }

        private void RefreshImagesButton_Click(object sender, EventArgs e) {
            AssetListBox.Items.Clear();

            if (SelectGameComboBox.Text.Equals("Modern Warfare 2 (1.14)"))
                ModernWarfare2Material.Populate(this);

            else if (SelectGameComboBox.Text.Equals("Black Ops (1.13)"))
                BlackOpsMaterial.Populate(this);

            else if (SelectGameComboBox.Text.Equals("Modern Warfare 3 (1.24)"))
                ModernWarfare3Material.Populate(this);

            else if (SelectGameComboBox.Text.Equals("Black Ops 2 (1.19)"))
                BlackOps2Material.Populate(this);

            else if (SelectGameComboBox.Text.Equals("Ghosts (1.16)"))
                GhostsMaterial.Populate(this);

            else if (SelectGameComboBox.Text.Equals("Ghosts (1.02)"))
                GhostsMaterial102.Populate(this);
        }

        private void AssetListBox_SelectedValueChanged(object sender, EventArgs e) {
            IMaterial material = (IMaterial)AssetListBox.SelectedItem;
            if (material == null)
                return;

            this.PointerLabel.Text = String.Format("Pointer: 0x{0}", material.Pointer.ToString("X"));
            this.NameLabel.Text = String.Format("Name: {0}", material.Name);
            this.WidthLabel.Text = String.Format("Width: {0}", material.Width);
            this.HeightLabel.Text = String.Format("Height: {0}", material.Height);
            this.SizeLabel.Text = String.Format("Size: 0x{0}", material.Size.ToString("X"));

            if (material.Size == (material.Width * material.Height))
                this.FormatLabel.Text = "Format: DXT5";
            else
                this.FormatLabel.Text = "Format: DXT1";
        }

        private void PreviewImageButton_Click(object sender, EventArgs e) {
            IMaterial material = (IMaterial)AssetListBox.SelectedItem;
            if (material == null)
                return;

            byte[] bytes = material.DumpImage();

            try {
                PreviewForm pForm = new PreviewForm(material.Name, bytes, material.Width, material.Height);
                pForm.Show();
            }
            catch {
                MessageBox.Show("There was an error processing the picture", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DumpImageButton_Click(object sender, EventArgs e) {
            IMaterial material = (IMaterial)AssetListBox.SelectedItem;
            if (material == null)
                return;

            byte[] bytes = material.DumpImage();
            if (!Directory.Exists(@"images"))
                Directory.CreateDirectory(@"images");

            string fileName = @"images/" + material.Name + ".dds";
            File.WriteAllBytes(fileName, bytes);

            MessageBox.Show("Image saved to:\n\n" + fileName, "Image Dump Complete");
        }

        private void InjectImageButton_Click(object sender, EventArgs e) {
            IMaterial material = (IMaterial)AssetListBox.SelectedItem;
            if (material == null)
                return;

            var file = new OpenFileDialog { Filter = "DDS|*.bin;*.dds" };
            if (file.ShowDialog() == DialogResult.OK) {
                string fileName = file.FileName;
                try {
                    byte[] image = File.ReadAllBytes(file.FileName);

                    DialogResult dialogResult = DialogResult.Yes;
                    if (image.Length > material.Size)
                        dialogResult = MessageBox.Show("The file you are trying to inject is larger than the buffer.\n\nWould you like to inject anyways?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dialogResult == DialogResult.Yes)
                        material.InjectImage(image);
                }
                catch (Exception) {
                    this.Close();

                    MessageBox.Show("Unable to inject your image", "Injection Error!");
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) {
            int index = AssetListBox.FindString(this.SearchTextBox.Text);
            if(index >= 0) {
                AssetListBox.SelectedIndex = index;
            }
        }

        private void SaveImagesToFileButton_Click(object sender, EventArgs e) {
            if (AssetListBox.Items.Count <= 0)
                return;

            if (!Directory.Exists(@"images"))
                Directory.CreateDirectory(@"images");

            string FileName = @"images/" + SelectGameComboBox.Text + "_DUMP.txt";
            if (File.Exists(FileName))
                File.Delete(FileName);

            File.AppendAllText(FileName, String.Format("< {0} Image Name Dump >\n", SelectGameComboBox.Text));
            for (int i = 0; i < this.AssetListBox.Items.Count; i++) {
                IMaterial material = (IMaterial)AssetListBox.Items[i];
                string name = material.Name;

                File.AppendAllText(FileName, name + Environment.NewLine);
            }
            File.AppendAllText(FileName, Environment.NewLine);

            MessageBox.Show("All image names have been dumped to\n\n" + FileName, "Image Name Dump Complete");
        }
    }
}
