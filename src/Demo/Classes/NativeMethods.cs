using System.Runtime.InteropServices;
using System;

namespace XRails_LoginUI.Demo.Classes
{
    internal static class NativeMethods
    {
        #region DWM Functions

        /// <summary>
        /// Extends the window frame into the client area.
        /// </summary>
        /// 
        /// <param name="hWnd">
        /// The handle to the window in which the frame will be extended into
        /// the client area.
        /// </param>
        /// 
        /// <param name="pMarInset">
        /// A pointer to a <see cref="MARGINS"/> structure that describes the margins to use
        /// when extending the frame into the client area.
        /// </param>
        [DllImport("dwmapi.dll")]
        internal static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        /// <summary>
        /// Obtains a value that indicates whether Desktop Window Manager (DWM)
        /// composition is enabled.
        /// </summary>
        /// 
        /// <param name="pfEnabled">
        /// A pointer to a value that, when this function returns successfully,
        /// receives TRUE if DWM composition is enabled; otherwise, FALSE.
        /// </param>
        [DllImport("dwmapi.dll")]
        internal static extern int DwmIsCompositionEnabled(out bool pfEnabled);

        /// <summary>
        /// Sets the value of non-client rendering attributes for a window.
        /// </summary>
        /// 
        /// <param name="hwnd">
        /// The handle to the window that will receive the attributes.
        /// </param>
        /// 
        /// <param name="dwAttribute">
        /// A single <see cref="DWMWINDOWATTRIBUTE"/> flag to apply to the window.
        /// </param>
        /// 
        /// <param name="pvAttribute ">
        /// A pointer to the value of the attribute specified in the 
        /// <paramref name="dwAttribute"/> parameter.
        /// </param>
        /// 
        /// <param name="cbAttribute">
        /// The size, in bytes, of the value type pointed to by the
        /// <paramref name="pvAttribute"/> parameter.
        /// </param>
        [DllImport("dwmapi.dll")]
        internal static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

        #endregion
        #region Structures

        /// <summary>
        /// Defines the margins of windows that have visual styles applied.
        /// </summary>
        internal struct MARGINS
        {
            internal int cxLeftWidth;
            internal int cxRightWidth;
            internal int cyTopHeight;
            internal int cyBottomHeight;
        }

        #endregion
        #region Enumerations

        /// <summary>
        /// Flags used by the DwmGetWindowAttribute and
        /// <see cref="DwmSetWindowAttribute"/> functions to specify window
        /// attributes for non-client rendering.
        /// </summary>
        internal enum DWMWINDOWATTRIBUTE
        {
            DWMWA_NCRENDERING_ENABLED = 1,
            DWMWA_NCRENDERING_POLICY,
            DWMWA_TRANSITIONS_FORCEDISABLED,
            DWMWA_ALLOW_NCPAINT,
            DWMWA_CAPTION_BUTTON_BOUNDS,
            DWMWA_NONCLIENT_RTL_LAYOUT,
            DWMWA_FORCE_ICONIC_REPRESENTATION,
            DWMWA_FLIP3D_POLICY,
            DWMWA_EXTENDED_FRAME_BOUNDS,
            DWMWA_HAS_ICONIC_BITMAP,
            DWMWA_DISALLOW_PEEK,
            DWMWA_EXCLUDED_FROM_PEEK,
            DWMWA_CLOAK,
            DWMWA_CLOAKED,
            DWMWA_FREEZE_REPRESENTATION,
            DWMWA_LAST
        }

        /// <summary>
        /// Windows messages.
        /// </summary>
        [Flags]
        internal enum WindowsMessages
        {
            NULL          = 0x0000,
            WM_NCPAINT    = 0x0085,
            WM_NCACTIVATE = 0x0086
        }

        #endregion
    }
}