using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System;

namespace XRails_LoginUI.Demo.Classes
{
    internal sealed class FontLoader
    {
        /// <summary>
        /// Provides a collection of font families built from font files that
        /// are provided by the client application.
        /// </summary>
        private static PrivateFontCollection fontCollection;
        
        private static void LoadFontIntoMemory()
        {
            try
            {
                // Add a font provided by the client application without installing it
                // SNIPPET CREDIT: Shibumi
                fontCollection    = new PrivateFontCollection();

                var fontLength    = Properties.Resources.Raleway_Light.Length;
                var fontData      = Properties.Resources.Raleway_Light;
                var memoryPointer = Marshal.AllocCoTaskMem(fontLength);

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

        /// <summary>
        /// Sets the custom font that was defined in <see cref="LoadFontIntoMemory()"/>.
        /// </summary>
        /// 
        /// <param name="size">
        /// The em-size of the font measured in the units specified by the
        /// <paramref name="unit"/> property.
        /// </param>
        /// 
        /// <param name="style">
        /// Specifies style information applied to text.
        /// </param>
        /// 
        /// <param name="unit">
        /// Specifies the unit of measure for the given data.
        /// </param>
        /// 
        /// <param name="gdiCharSet">
        /// A byte value that specifies the GDI character set that the font uses.
        /// The default is value 1.
        /// </param>
        public static Font SetFont(float size, FontStyle style, GraphicsUnit unit, byte gdiCharSet)
        {
            if (fontCollection == null)
                LoadFontIntoMemory();

            return new Font(fontCollection.Families[0], size, style, unit, gdiCharSet);
        }
    }
}