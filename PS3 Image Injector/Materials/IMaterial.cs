using System;

namespace PS3_Image_Injector {
    interface IMaterial {
        UInt32 Pointer { get; }
        String Name { get; }
        UInt32 Buffer { get; }
        Int32 Size { get; }
        Int16 Width { get; }
        Int16 Height { get; }

        byte[] DumpImage();
        void InjectImage(byte[] buffer);
    }
}
