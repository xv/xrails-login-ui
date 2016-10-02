using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing;

namespace XRails
{
    internal sealed class FontLoader
    {
        private static PrivateFontCollection fontCollection = null;
        
        public static void LoadFontIntoMemory()
        {
            try
            {
                // Add a font provided by the client application without installing it
                fontCollection = new PrivateFontCollection();
                int fontLength = Properties.Resources.Raleway_Light.Length;
                byte[] fontData = Properties.Resources.Raleway_Light;

                IntPtr memoryPointer = Marshal.AllocCoTaskMem(fontLength);
                Marshal.Copy(fontData, 0, memoryPointer, fontLength);

                // Add the font contained in system memory to the PrivateFontCollection
                fontCollection.AddMemoryFont(memoryPointer, fontLength);
                Marshal.FreeCoTaskMem(memoryPointer);
            }
            catch (Exception up) 
            {
                up = new Exception(up.Message);
                throw up;
            }
        }

        public static Font GetFont(float size, FontStyle style, GraphicsUnit unit, byte charSet)
        {
            if (fontCollection == null) { LoadFontIntoMemory(); }
            return new Font(fontCollection.Families[0], size, style, unit, charSet);
        }
    }
}
