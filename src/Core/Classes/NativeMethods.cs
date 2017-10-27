using System.Runtime.InteropServices;
using System;

namespace XRails.Classes
{
    internal static class NativeMethods
    {
        #region Cursor Functions

        /// <summary>
        /// Loads the specified cursor resource from the executable (.EXE) file
        /// associated with an application instance.
        /// </summary>
        ///
        /// <param name="hInstance">
        /// A handle to an instance of the module whose executable file contains the
        /// cursor to be loaded.
        /// </param>
        ///
        /// <param name="lpCursorName">
        /// The name of the cursor resource to be loaded.
        /// </param>
        [DllImport("user32.dll")]
        internal static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        /// <summary>
        /// Sets the cursor shape.
        /// </summary>
        ///
        /// <param name="hCursor">
        /// A handle to the cursor.
        /// </param>
        [DllImport("user32.dll")]
        internal static extern IntPtr SetCursor(IntPtr hCursor);

        #endregion
    }
}