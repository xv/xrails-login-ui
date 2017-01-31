using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;

using XRails.Classes;

namespace XRails
{
    public partial class Form_Login : Form
    {
        internal Timer FadeIn = new Timer();

        public Form_Login()
        {
            InitializeComponent();

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
            TitleLabel_Welcome.Font = FontLoader.GetFont(22, FontStyle.Regular, GraphicsUnit.Point, 1);
            TitleLabel_LoginTo.Font = FontLoader.GetFont(22, FontStyle.Regular, GraphicsUnit.Point, 1);

            // Animator settings
            animator1.AnimationType = AnimatorNS.AnimationType.Transparent;
            animator1.Interval = 8;
            animator1.MaxAnimationTime = 1500;
            animator1.TimeStep = 0.02F;

            // Set the form opacity to 0% and enable the timer that will increase it when the
            // software is launched.
            Opacity = 0;
            FadeIn.Interval = 1;
            FadeIn.Enabled = true;

            // Add a dynamic handler to the .Tick event
            FadeIn.Tick += new EventHandler(FadeIn_Tick);

            BTN_Login.Enabled = false;

            TB_Username.TextChanged += ValidateInput;
            TB_Password.TextChanged += ValidateInput;
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            BTN_Login.Enabled = !(TB_Username.Text == string.Empty ||
                                  TB_Password.Text == string.Empty);
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            // Increase the form opacity value until it reaches 1 (or 100%). After that, stop the
            // timer and disable it.
            Opacity += 0.03;
            if (Opacity == 1)
            {
                FadeIn.Stop();
                FadeIn.Enabled = false;
            }
        }

        private void Form_Login_Shown(object sender, EventArgs e)
        {
            // Animate the controls that have the property [Visible = False] after the form has
            // been fully loaded and became visible. This code can be added to the {Form_Load}
            // event. However, it may cause the form to flicker when the software is launched.
            foreach (Control item in xRails_RightPanel1.Controls)
            {
                if (item.Visible != true)
                    animator1.Show(item);
            };
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unsubscribe events
            TB_Username.TextChanged -= ValidateInput;
            TB_Password.TextChanged -= ValidateInput;
        }

        private void Wait(int interval)
        {
            var stopW = new Stopwatch();
            stopW.Start();

            while (stopW.ElapsedMilliseconds < interval)
                Application.DoEvents();

            stopW.Stop();
        }

        // Just simulating a login process
        private void BTN_Login_Click(object sender, EventArgs e)
        {
            TB_Username.Enabled = false;
            TB_Password.Enabled = false;
            BTN_Login.Enabled = false;

            animator1.Hide(BTN_Login, true, AnimatorNS.Animation.HorizSlide);
            animator1.Show(Label_LoggingIn, true);

            Wait(4000);

            animator1.Hide(Label_LoggingIn, true);
            animator1.Show(BTN_Login, true, AnimatorNS.Animation.HorizSlide);

            TB_Username.Enabled = true;
            TB_Password.Enabled = true;
            BTN_Login.Enabled = true;
        }
    }
}