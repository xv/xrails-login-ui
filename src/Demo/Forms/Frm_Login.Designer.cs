namespace XRails_LoginUI.Demo
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Animator = new AnimatorNS.Animator(this.components);
            this.XR_Container = new XRails.Controls.XRails_Container();
            this.XR_RightPanel = new XRails.Controls.XRails_Panel();
            this.XR_Button_Login = new XRails.Controls.XRails_Button();
            this.XR_Label_LoggingIn = new XRails.Controls.XRails_Label();
            this.XR_TitleLabel_LoginTo = new XRails.Controls.XRails_TitleLabel();
            this.XR_TextBox_Pass = new XRails.Controls.XRails_TextBox();
            this.XR_TextBox_User = new XRails.Controls.XRails_TextBox();
            this.XR_LinkLabel_Email = new XRails.Controls.XRails_LinkLabel();
            this.XR_Label_Contact = new XRails.Controls.XRails_Label();
            this.XR_Label_Support = new XRails.Controls.XRails_Label();
            this.XR_LinkLabel_ForgotPass = new XRails.Controls.XRails_LinkLabel();
            this.XR_LeftPanel = new XRails.Controls.XRails_Panel();
            this.XR_TitleLabel_Welcome = new XRails.Controls.XRails_TitleLabel();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.XR_LogoBox = new XRails.Controls.XRails_LogoBox();
            this.XR_ControlBox = new XRails.Controls.XRails_ControlBox();
            this.XR_Container.SuspendLayout();
            this.XR_RightPanel.SuspendLayout();
            this.XR_LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Animator
            // 
            this.Animator.AnimationType = AnimatorNS.AnimationType.Custom;
            this.Animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation2;
            // 
            // XR_Container
            // 
            this.XR_Container.Controls.Add(this.XR_RightPanel);
            this.XR_Container.Controls.Add(this.XR_LeftPanel);
            this.XR_Container.Controls.Add(this.XR_ControlBox);
            this.XR_Container.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_Container, AnimatorNS.DecorationType.None);
            this.XR_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XR_Container.DrawIcon = false;
            this.XR_Container.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XR_Container.Location = new System.Drawing.Point(0, 0);
            this.XR_Container.MinimumSize = new System.Drawing.Size(100, 42);
            this.XR_Container.Name = "XR_Container";
            this.XR_Container.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.XR_Container.Size = new System.Drawing.Size(700, 515);
            this.XR_Container.TabIndex = 0;
            this.XR_Container.Text = "XRails Login";
            this.XR_Container.TextAlignment = XRails.Controls.XRails_Container.Alignment.Left;
            this.XR_Container.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // XR_RightPanel
            // 
            this.XR_RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.XR_RightPanel.Controls.Add(this.XR_Button_Login);
            this.XR_RightPanel.Controls.Add(this.XR_Label_LoggingIn);
            this.XR_RightPanel.Controls.Add(this.XR_TitleLabel_LoginTo);
            this.XR_RightPanel.Controls.Add(this.XR_TextBox_Pass);
            this.XR_RightPanel.Controls.Add(this.XR_TextBox_User);
            this.XR_RightPanel.Controls.Add(this.XR_LinkLabel_Email);
            this.XR_RightPanel.Controls.Add(this.XR_Label_Contact);
            this.XR_RightPanel.Controls.Add(this.XR_Label_Support);
            this.XR_RightPanel.Controls.Add(this.XR_LinkLabel_ForgotPass);
            this.XR_RightPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_RightPanel, AnimatorNS.DecorationType.None);
            this.XR_RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XR_RightPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.XR_RightPanel.Location = new System.Drawing.Point(350, 31);
            this.XR_RightPanel.Name = "XR_RightPanel";
            this.XR_RightPanel.Side = XRails.Controls.XRails_Panel.PanelSide.Right;
            this.XR_RightPanel.Size = new System.Drawing.Size(350, 484);
            this.XR_RightPanel.TabIndex = 2;
            // 
            // XR_Button_Login
            // 
            this.XR_Button_Login.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.XR_Button_Login, AnimatorNS.DecorationType.None);
            this.XR_Button_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.XR_Button_Login.Enabled = false;
            this.XR_Button_Login.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.XR_Button_Login.Location = new System.Drawing.Point(-7, 317);
            this.XR_Button_Login.MinimumSize = new System.Drawing.Size(144, 47);
            this.XR_Button_Login.Name = "XR_Button_Login";
            this.XR_Button_Login.Radius = 20;
            this.XR_Button_Login.Size = new System.Drawing.Size(144, 47);
            this.XR_Button_Login.TabIndex = 0;
            this.XR_Button_Login.Text = "LOGIN";
            this.XR_Button_Login.Click += new System.EventHandler(this.XR_Button_Login_Click);
            // 
            // XR_Label_LoggingIn
            // 
            this.XR_Label_LoggingIn.BackColor = System.Drawing.Color.Transparent;
            this.XR_Label_LoggingIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_Label_LoggingIn, AnimatorNS.DecorationType.None);
            this.XR_Label_LoggingIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XR_Label_LoggingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.XR_Label_LoggingIn.Image = ((System.Drawing.Image)(resources.GetObject("XR_Label_LoggingIn.Image")));
            this.XR_Label_LoggingIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XR_Label_LoggingIn.Location = new System.Drawing.Point(17, 329);
            this.XR_Label_LoggingIn.Name = "XR_Label_LoggingIn";
            this.XR_Label_LoggingIn.Size = new System.Drawing.Size(96, 22);
            this.XR_Label_LoggingIn.TabIndex = 8;
            this.XR_Label_LoggingIn.Text = "Logging in...";
            this.XR_Label_LoggingIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XR_Label_LoggingIn.Visible = false;
            // 
            // XR_TitleLabel_LoginTo
            // 
            this.XR_TitleLabel_LoginTo.AutoSize = true;
            this.XR_TitleLabel_LoginTo.BackColor = System.Drawing.Color.Transparent;
            this.XR_TitleLabel_LoginTo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_TitleLabel_LoginTo, AnimatorNS.DecorationType.None);
            this.XR_TitleLabel_LoginTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.XR_TitleLabel_LoginTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.XR_TitleLabel_LoginTo.Location = new System.Drawing.Point(20, 136);
            this.XR_TitleLabel_LoginTo.Name = "XR_TitleLabel_LoginTo";
            this.XR_TitleLabel_LoginTo.Side = XRails.Controls.XRails_TitleLabel.PanelSide.RightPanel;
            this.XR_TitleLabel_LoginTo.Size = new System.Drawing.Size(298, 40);
            this.XR_TitleLabel_LoginTo.TabIndex = 7;
            this.XR_TitleLabel_LoginTo.Text = "Login to your account";
            this.XR_TitleLabel_LoginTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XR_TitleLabel_LoginTo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.XR_TitleLabel_LoginTo.UseCompatibleTextRendering = true;
            this.XR_TitleLabel_LoginTo.Visible = false;
            // 
            // XR_TextBox_Pass
            // 
            this.XR_TextBox_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.XR_TextBox_Pass.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.XR_TextBox_Pass, AnimatorNS.DecorationType.None);
            this.XR_TextBox_Pass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.XR_TextBox_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.XR_TextBox_Pass.Image = ((System.Drawing.Image)(resources.GetObject("XR_TextBox_Pass.Image")));
            this.XR_TextBox_Pass.Location = new System.Drawing.Point(0, 247);
            this.XR_TextBox_Pass.MaxLength = 30;
            this.XR_TextBox_Pass.Multiline = false;
            this.XR_TextBox_Pass.Name = "XR_TextBox_Pass";
            this.XR_TextBox_Pass.ReadOnly = false;
            this.XR_TextBox_Pass.ShortcutsEnabled = true;
            this.XR_TextBox_Pass.ShowBottomBorder = true;
            this.XR_TextBox_Pass.ShowTopBorder = false;
            this.XR_TextBox_Pass.Size = new System.Drawing.Size(350, 50);
            this.XR_TextBox_Pass.TabIndex = 6;
            this.XR_TextBox_Pass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.XR_TextBox_Pass.UseSystemPasswordChar = true;
            this.XR_TextBox_Pass.Watermark = "Password";
            this.XR_TextBox_Pass.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // XR_TextBox_User
            // 
            this.XR_TextBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.XR_TextBox_User.ColorBordersOnEnter = true;
            this.Animator.SetDecoration(this.XR_TextBox_User, AnimatorNS.DecorationType.None);
            this.XR_TextBox_User.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.XR_TextBox_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.XR_TextBox_User.Image = ((System.Drawing.Image)(resources.GetObject("XR_TextBox_User.Image")));
            this.XR_TextBox_User.Location = new System.Drawing.Point(0, 197);
            this.XR_TextBox_User.MaxLength = 64;
            this.XR_TextBox_User.Multiline = false;
            this.XR_TextBox_User.Name = "XR_TextBox_User";
            this.XR_TextBox_User.ReadOnly = false;
            this.XR_TextBox_User.ShortcutsEnabled = true;
            this.XR_TextBox_User.ShowBottomBorder = false;
            this.XR_TextBox_User.ShowTopBorder = true;
            this.XR_TextBox_User.Size = new System.Drawing.Size(350, 50);
            this.XR_TextBox_User.TabIndex = 5;
            this.XR_TextBox_User.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.XR_TextBox_User.UseSystemPasswordChar = false;
            this.XR_TextBox_User.Watermark = "Username or Email";
            this.XR_TextBox_User.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // XR_LinkLabel_Email
            // 
            this.XR_LinkLabel_Email.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.XR_LinkLabel_Email.AutoSize = true;
            this.XR_LinkLabel_Email.BackColor = System.Drawing.Color.Transparent;
            this.XR_LinkLabel_Email.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_LinkLabel_Email, AnimatorNS.DecorationType.None);
            this.XR_LinkLabel_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XR_LinkLabel_Email.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.XR_LinkLabel_Email.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.XR_LinkLabel_Email.Location = new System.Drawing.Point(217, 444);
            this.XR_LinkLabel_Email.Name = "XR_LinkLabel_Email";
            this.XR_LinkLabel_Email.Size = new System.Drawing.Size(91, 15);
            this.XR_LinkLabel_Email.TabIndex = 4;
            this.XR_LinkLabel_Email.TabStop = true;
            this.XR_LinkLabel_Email.Text = "admin@xrails.io";
            this.XR_LinkLabel_Email.Visible = false;
            this.XR_LinkLabel_Email.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // XR_Label_Contact
            // 
            this.XR_Label_Contact.AutoSize = true;
            this.XR_Label_Contact.BackColor = System.Drawing.Color.Transparent;
            this.XR_Label_Contact.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_Label_Contact, AnimatorNS.DecorationType.None);
            this.XR_Label_Contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XR_Label_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.XR_Label_Contact.Location = new System.Drawing.Point(42, 429);
            this.XR_Label_Contact.Name = "XR_Label_Contact";
            this.XR_Label_Contact.Size = new System.Drawing.Size(261, 30);
            this.XR_Label_Contact.TabIndex = 3;
            this.XR_Label_Contact.Text = "To obtain access to this app or for any questions\r\nabout its use, submit an email" +
    " to\r\n";
            this.XR_Label_Contact.Visible = false;
            // 
            // XR_Label_Support
            // 
            this.XR_Label_Support.AutoSize = true;
            this.XR_Label_Support.BackColor = System.Drawing.Color.Transparent;
            this.XR_Label_Support.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_Label_Support, AnimatorNS.DecorationType.None);
            this.XR_Label_Support.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XR_Label_Support.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.XR_Label_Support.Location = new System.Drawing.Point(42, 409);
            this.XR_Label_Support.Name = "XR_Label_Support";
            this.XR_Label_Support.Size = new System.Drawing.Size(50, 15);
            this.XR_Label_Support.TabIndex = 2;
            this.XR_Label_Support.Text = "Support";
            this.XR_Label_Support.Visible = false;
            // 
            // XR_LinkLabel_ForgotPass
            // 
            this.XR_LinkLabel_ForgotPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.XR_LinkLabel_ForgotPass.AutoSize = true;
            this.XR_LinkLabel_ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.XR_LinkLabel_ForgotPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_LinkLabel_ForgotPass, AnimatorNS.DecorationType.None);
            this.XR_LinkLabel_ForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XR_LinkLabel_ForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.XR_LinkLabel_ForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            this.XR_LinkLabel_ForgotPass.Location = new System.Drawing.Point(147, 333);
            this.XR_LinkLabel_ForgotPass.Name = "XR_LinkLabel_ForgotPass";
            this.XR_LinkLabel_ForgotPass.Size = new System.Drawing.Size(100, 15);
            this.XR_LinkLabel_ForgotPass.TabIndex = 1;
            this.XR_LinkLabel_ForgotPass.TabStop = true;
            this.XR_LinkLabel_ForgotPass.Text = "Forgot password?";
            this.XR_LinkLabel_ForgotPass.Visible = false;
            this.XR_LinkLabel_ForgotPass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // XR_LeftPanel
            // 
            this.XR_LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.XR_LeftPanel.Controls.Add(this.XR_TitleLabel_Welcome);
            this.XR_LeftPanel.Controls.Add(this.PB_Logo);
            this.XR_LeftPanel.Controls.Add(this.XR_LogoBox);
            this.XR_LeftPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_LeftPanel, AnimatorNS.DecorationType.None);
            this.XR_LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.XR_LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.XR_LeftPanel.Location = new System.Drawing.Point(0, 31);
            this.XR_LeftPanel.Name = "XR_LeftPanel";
            this.XR_LeftPanel.Side = XRails.Controls.XRails_Panel.PanelSide.Left;
            this.XR_LeftPanel.Size = new System.Drawing.Size(350, 484);
            this.XR_LeftPanel.TabIndex = 1;
            // 
            // XR_TitleLabel_Welcome
            // 
            this.XR_TitleLabel_Welcome.AutoSize = true;
            this.XR_TitleLabel_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.XR_TitleLabel_Welcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_TitleLabel_Welcome, AnimatorNS.DecorationType.None);
            this.XR_TitleLabel_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.XR_TitleLabel_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.XR_TitleLabel_Welcome.Location = new System.Drawing.Point(33, 209);
            this.XR_TitleLabel_Welcome.Name = "XR_TitleLabel_Welcome";
            this.XR_TitleLabel_Welcome.Side = XRails.Controls.XRails_TitleLabel.PanelSide.LeftPanel;
            this.XR_TitleLabel_Welcome.Size = new System.Drawing.Size(284, 74);
            this.XR_TitleLabel_Welcome.TabIndex = 7;
            this.XR_TitleLabel_Welcome.Text = "Welcome to the\r\nXRails access portal";
            this.XR_TitleLabel_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XR_TitleLabel_Welcome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.XR_TitleLabel_Welcome.UseCompatibleTextRendering = true;
            // 
            // PB_Logo
            // 
            this.PB_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(98)))));
            this.Animator.SetDecoration(this.PB_Logo, AnimatorNS.DecorationType.None);
            this.PB_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_Logo.Image")));
            this.PB_Logo.Location = new System.Drawing.Point(143, 34);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(64, 64);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // XR_LogoBox
            // 
            this.XR_LogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(98)))));
            this.Animator.SetDecoration(this.XR_LogoBox, AnimatorNS.DecorationType.None);
            this.XR_LogoBox.Location = new System.Drawing.Point(33, 0);
            this.XR_LogoBox.MinimumSize = new System.Drawing.Size(100, 42);
            this.XR_LogoBox.Name = "XR_LogoBox";
            this.XR_LogoBox.Size = new System.Drawing.Size(317, 146);
            this.XR_LogoBox.TabIndex = 0;
            this.XR_LogoBox.Text = "xRails_TopLeftBox1";
            // 
            // XR_ControlBox
            // 
            this.XR_ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XR_ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.XR_ControlBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Animator.SetDecoration(this.XR_ControlBox, AnimatorNS.DecorationType.None);
            this.XR_ControlBox.EnableMaximizeButton = false;
            this.XR_ControlBox.EnableMinimizeButton = true;
            this.XR_ControlBox.Location = new System.Drawing.Point(561, 0);
            this.XR_ControlBox.Name = "XR_ControlBox";
            this.XR_ControlBox.Size = new System.Drawing.Size(139, 31);
            this.XR_ControlBox.TabIndex = 0;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 515);
            this.Controls.Add(this.XR_Container);
            this.Animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "Frm_Login";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XRails Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Login_FormClosing);
            this.Shown += new System.EventHandler(this.Frm_Login_Shown);
            this.XR_Container.ResumeLayout(false);
            this.XR_RightPanel.ResumeLayout(false);
            this.XR_RightPanel.PerformLayout();
            this.XR_LeftPanel.ResumeLayout(false);
            this.XR_LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XRails.Controls.XRails_Container XR_Container;
        private XRails.Controls.XRails_ControlBox XR_ControlBox;
        private XRails.Controls.XRails_Panel XR_LeftPanel;
        private XRails.Controls.XRails_Panel XR_RightPanel;
        private XRails.Controls.XRails_LogoBox XR_LogoBox;
        private System.Windows.Forms.PictureBox PB_Logo;
        private XRails.Controls.XRails_Button XR_Button_Login;
        private XRails.Controls.XRails_LinkLabel XR_LinkLabel_ForgotPass;
        private XRails.Controls.XRails_Label XR_Label_Support;
        private XRails.Controls.XRails_LinkLabel XR_LinkLabel_Email;
        private XRails.Controls.XRails_Label XR_Label_Contact;
        private XRails.Controls.XRails_TextBox XR_TextBox_User;
        private XRails.Controls.XRails_TextBox XR_TextBox_Pass;
        private XRails.Controls.XRails_TitleLabel XR_TitleLabel_Welcome;
        private XRails.Controls.XRails_TitleLabel XR_TitleLabel_LoginTo;
        private XRails.Controls.XRails_Label XR_Label_LoggingIn;
        private AnimatorNS.Animator Animator;

    }
}

