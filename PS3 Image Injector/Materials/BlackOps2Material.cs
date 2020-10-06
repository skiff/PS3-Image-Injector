using System;

namespace PS3_Image_Injector {
    class BlackOps2Material : IMaterial {
        static TMAPI PS3 = new TMAPI();

        static readonly UInt32 ASSET_IMAGE_COUNT = 4336;
        static readonly UInt32 ASSET_IMAGE_START = 0x122529C;
        static readonly UInt32 ASSET_IMAGE_SIZE = 0x98;

        public String Name { get; set; }
        public UInt32 Pointer { get; set; }
        public UInt32 Buffer { get; set; }
        public Int32 Size { get; set; }
        public Int16 Width { get; set; }
        public Int16 Height { get; set; }

        public BlackOps2Material(UInt32 Pointer) {
            this.Pointer = Pointer;

            this.Name = PS3.Ext.ReadString(PS3.Ext.ReadUInt32(this.Pointer + 0x90));
            this.Buffer = PS3.Ext.ReadUInt32(this.Pointer + 0x28);
            this.Size = PS3.Ext.ReadInt32(this.Pointer + 0x18);
            this.Width = PS3.Ext.ReadInt16(this.Pointer + 0x1C);
            this.Height = PS3.Ext.ReadInt16(this.Pointer + 0x1E);
        }

        public byte[] DumpImage() {
            if (this.Buffer != 0) {
                byte[] Data = PS3.Ext.ReadBytes(this.Buffer, this.Size);

                return DDSCreate.CreateDDS(this.Width, this.Height, Data);
            }
            return new byte[1];
        }

        public void InjectImage(byte[] buffer) {
            if (this.Buffer != 0) {
                Int32 Magic = BitConverter.ToInt32(buffer, 0);
                if (Magic == 0x44445320) {
                    byte[] removeHeader = new byte[buffer.Length - 0x80];
                    Array.Copy(buffer, 0x80, removeHeader, 0, buffer.Length);
                    buffer = removeHeader;
                }

                PS3.Ext.WriteBytes(this.Buffer, buffer);
            }
        }

        public static void Populate(MainForm mainForm) {
            mainForm.ProgressBarLabel.Text = String.Format("Progress: 0 | {0}", ASSET_IMAGE_COUNT);
            mainForm.AssetProgressBar.Value = 0;
            mainForm.AssetProgressBar.Maximum = (Int32)ASSET_IMAGE_COUNT;
            mainForm.Refresh();

            for (uint i = 0; i < ASSET_IMAGE_COUNT; i++) {
                UInt32 ptr = ASSET_IMAGE_START + (i * ASSET_IMAGE_SIZE);

                uint StringName = PS3.Ext.ReadUInt32(ptr + 0x90);
                if (StringName != 0) {
                    IMaterial material = new BlackOps2Material(ptr);
                    mainForm.AssetListBox.Items.Add(material);

                    if (i % 10 == 0) {
                        mainForm.ProgressBarLabel.Text = String.Format("Progress: {0} | {1}", i, ASSET_IMAGE_COUNT);
                        mainForm.AssetProgressBar.Increment(10);
                        mainForm.ProgressBarLabel.Refresh();
                    }
                }
            }

            mainForm.ProgressBarLabel.Text = String.Format("Progress: {0} | {1}", ASSET_IMAGE_COUNT, ASSET_IMAGE_COUNT);
            mainForm.AssetProgressBar.Increment((Int32)ASSET_IMAGE_COUNT);
            mainForm.Refresh();
        }
    }
}
