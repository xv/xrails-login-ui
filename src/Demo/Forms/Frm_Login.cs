/*  Frm_Login.cs
**  Copyright (C) 2017, Jad Altahan
** 
**  This software may be modified and 
**  distributed under the terms of the
**  MIT license. See the LICENSE file
**  for details.
** 
**  http://github.com/xv
**  mailto:xviyy@aol.com
*/

using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;
using System;
using XRails_LoginUI.Demo.Classes;

namespace XRails_LoginUI.Demo
{
    public partial class Frm_Login : Form
    {
        #region Fields

        private readonly Timer tmrFadeIn;
        private bool aeroShadow;

        #endregion
        #region Constants

        /// <summary>
        /// Allows minimizing from taskbar.
        /// </summary>
        private const int WS_MINIMIZEBOX = 0x20000;

        /// <summary>
        /// Paints all descendants of a window in bottom-to-top painting order
        /// using double-buffering.
        /// </summary>
        private const int WS_EX_COMPOSITED = 0x02000000;

        #endregion

        public Frm_Login()
        {
            InitializeComponent();

            // Animator settings
            Animator.AnimationType = AnimatorNS.AnimationType.Transparent;
            Animator.Interval = 8;
            Animator.MaxAnimationTime = 1000;
            Animator.TimeStep = 0.02F;

            XR_Button_Login.Enabled = false;
            XR_TextBox_User.TextChanged += ValidateInput;
            XR_TextBox_Pass.TextChanged += ValidateInput;

            /* IMPORTANT, OTHERWISE THE CUSTOM FONT WILL NOT LOAD
            ** ---------
            ** Because we're not installing the custom font on the system, debugging the software 
            ** without specifying the XRails_TitleLabel font property on the form that is using it 
            ** will cause the label to revert to the default system font
            **
            ** The form designer may show the TitleLabel font as "Microsoft Sans Serif", don't
            ** panic! The custom font only loads during the debugging process and after running
            ** the compiled software
            */
            var customFont = FontLoader.SetFont(22, FontStyle.Regular, GraphicsUnit.Point, 1);
            XR_TitleLabel_Welcome.Font = customFont;
            XR_TitleLabel_LoginTo.Font = customFont;

            // Set the form opacity to 0% and enable the timer that will
            // increase it when the software is launched.
            Opacity = 0;

            tmrFadeIn = new Timer
            {
                Interval = 1,
                Enabled  = true,
            };

            // Add a dynamic handler to the .Tick event
            tmrFadeIn.Tick += FadeIn_Tick;
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            // Increase the form opacity value until it reaches 1 (or 100%).
            // After that, stop the timer and disable it.
            Opacity += 0.05;
            if (Opacity == 1)
            {
                tmrFadeIn.Stop();
                tmrFadeIn.Enabled = false;
                tmrFadeIn.Tick -= FadeIn_Tick;
            }
        }

        #region Form Events

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unsubscribe previously used events
            tmrFadeIn.Tick -= FadeIn_Tick;
            XR_TextBox_User.TextChanged -= ValidateInput;
            XR_TextBox_Pass.TextChanged -= ValidateInput;
        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            // Animate the controls that have the property [Visible = False] after the form has
            // been fully loaded and became visible. This code can be added to the {Form_Load}
            // event. However, it may cause the form to flicker when the software is launched.
            foreach (Control item in XR_RightPanel.Controls)
            {
                if (item.Visible != true)
                    Animator.Show(item);
            };
        }

        #endregion

        /// <summary>
        /// Checks if the Desktop Window Manager is enabled.
        /// </summary>
        private static bool IsDwmCompositionEnabled()
        {
            // Only Windows Vista and up
            // NOTE: DWM composition is always enabled as of Windows 8
            if (Environment.OSVersion.Version.Major < 6)
                return false;
            
            bool isEnabled;
            NativeMethods.DwmIsCompositionEnabled(out isEnabled);
            
            return isEnabled;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            XR_Button_Login.Enabled = !(XR_TextBox_User.Text == string.Empty ||
                                        XR_TextBox_Pass.Text == string.Empty);
        }

        private void Wait(int seconds)
        {
            if (seconds < 1)
                return;

            var timeToWait = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < timeToWait)
                System.Windows.Forms.Application.DoEvents();
        }

        // Just simulate a login process...
        private void XR_Button_Login_Click(object sender, EventArgs e)
        {
            XR_TextBox_User.Enabled = false;
            XR_TextBox_Pass.Enabled = false;
            XR_Button_Login.Enabled = false;

            Animator.Hide(XR_Button_Login, true, AnimatorNS.Animation.HorizSlide);
            Animator.Hide(XR_LinkLabel_ForgotPass, true, AnimatorNS.Animation.Transparent);
            Animator.Show(XR_Label_LoggingIn);

            Wait(4);

            Animator.Hide(XR_Label_LoggingIn, true);
            Animator.Show(XR_Button_Login, true, AnimatorNS.Animation.HorizSlide);
            Animator.Show(XR_LinkLabel_ForgotPass, true, AnimatorNS.Animation.Transparent);

            XR_TextBox_User.Enabled = true;
            XR_TextBox_Pass.Enabled = true;
            XR_Button_Login.Enabled = true;
        }

        // Modify the parameters of the form's handle (unmanaged code).
        protected override CreateParams CreateParams
        {
            get
            {
                new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                aeroShadow = IsDwmCompositionEnabled();

                var cp = base.CreateParams;

                // WS_MINIMIZEBOX   : allows minimizing the software from the taskbar
                // WS_EX_COMPOSITED : paints bottom-to-top. Reduces flicker greatly

                cp.Style |= WS_MINIMIZEBOX;
                cp.ExStyle |= WS_EX_COMPOSITED;

                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch ((NativeMethods.WindowsMessages)m.Msg)
            {
                case NativeMethods.WindowsMessages.WM_NCPAINT:
                    if (aeroShadow)
                    {
                        var ncAttr = NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_NCRENDERING_POLICY;
                        var dwAttrPntr = 2;
                        NativeMethods.DwmSetWindowAttribute(Handle, ncAttr, ref dwAttrPntr, 4);

                        var margins = new NativeMethods.MARGINS()
                        {
                            cyBottomHeight = 1,
                            cxLeftWidth    = 1,
                            cxRightWidth   = 1,
                            cyTopHeight    = 1
                        };

                        NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                case NativeMethods.WindowsMessages.WM_NCACTIVATE:
                    // Change the title bar text color according to whether the
                    // window is active or inactive
                    if (m.WParam == IntPtr.Zero)
                        XR_Container.TitleBarTextColor = Color.DarkGray;
                    else
                        XR_Container.TitleBarTextColor = Color.Gainsboro;
                    break;
            }
            base.WndProc(ref m);
        }
    }
}