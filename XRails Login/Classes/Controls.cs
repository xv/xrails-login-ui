/* |-----------DO-NOT-REMOVE-----------|
** 
**  Controls.cs
** 
**  Copyright (C) 2016, Ezra Altahan
** 
**  This software may be modified and 
**  distributed under the terms of the
**  MIT license. See the LICENSE file
**  for details
** 
**  Site   : GitHub.com/ei | exr.be
**  Created: 26.Sep.2016
**  Version: 1.0.0
** 
** |-----------DO-NOT-REMOVE-----------|
*/

using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

using XRails.Classes;

namespace XRails
{
    #region TopLeftBox

    public class XRails_TopLeftBox : Control
    {
        public XRails_TopLeftBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint            |
                     ControlStyles.ResizeRedraw, true);

            Size = new Size(310, 146);
            MinimumSize = new Size(100, 42);
            BackColor = ColorTranslator.FromHtml("#F46662");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var borderRect = new Rectangle(1, 0, Width, Height - 1);

            g.SmoothingMode = SmoothingMode.None;

            using (var border = new Pen(ColorTranslator.FromHtml("#F68F84"), 2.0f))
            using (var fill = new SolidBrush(ColorTranslator.FromHtml("#F46662")))
            {
                g.DrawRectangle(border, borderRect);
                g.FillRectangle(fill, 1, 0, Width - 1, Height - 1);
            }
            
            base.OnPaint(e);
        }
    }

    #endregion
    #region Panels

    public class XRails_LeftPanel : Panel
    {
        public XRails_LeftPanel()
        {
            DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint  |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw          |
                     ControlStyles.UserPaint, true);

            UpdateStyles();

            ForeColor = ColorTranslator.FromHtml("#FAFAFA");
            BackColor = ColorTranslator.FromHtml("#F25D59");

            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Left;
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }
    }

    public class XRails_RightPanel : Panel
    {
        public XRails_RightPanel()
        {
            DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint  |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw          |
                     ControlStyles.UserPaint, true);

            UpdateStyles();

            ForeColor = ColorTranslator.FromHtml("#FAFAFA");
            BackColor = ColorTranslator.FromHtml("#292C3B");

            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Fill;
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }
    }

    #endregion
    #region TitleLabel

    public class XRails_TitleLabel : Label
    {
        #region Properties

        private PanelSide _Side;
        [Browsable(true)]
        [Description("Determines the foreground color of the label according to which side it is placed on.")]
        public PanelSide Side
        {
            get { return _Side; }
            set
            {
                _Side = value;
                switch (value)
                {
                    case PanelSide.LeftPanel:
                        ForeColor = ColorTranslator.FromHtml("#FAFAFA");
                        break;
                    case PanelSide.RightPanel:
                        ForeColor = ColorTranslator.FromHtml("#AAABB0");
                        break;
                }
                Invalidate();
            }
        }

        private TextRenderingHint _TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        [Browsable(true)]
        [Description("Specifies the quality of text rendering.")]
        public TextRenderingHint TextRenderingHint
        {
            get { return _TextRenderingHint; }
            set
            {
                _TextRenderingHint = value;
                Invalidate();
            }
        }

        #endregion

        public enum PanelSide { LeftPanel, RightPanel };

        public XRails_TitleLabel()
        {
            Font = FontLoader.GetFont(22, FontStyle.Regular, GraphicsUnit.Point, 1);
            UseCompatibleTextRendering = true;
            TextAlign = ContentAlignment.MiddleCenter;
            ForeColor = ColorTranslator.FromHtml("#FAFAFA");
            BackColor = Color.Transparent;
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = _TextRenderingHint;
            base.OnPaint(e);  
        }
    }

    #endregion
    #region LinkLabel

    public class XRails_LinkLabel : LinkLabel
    {
        #region Variables

        private readonly Color linkColor       = ColorTranslator.FromHtml("#F25D59");
        private readonly Color activeLinkColor = ColorTranslator.FromHtml("#DE5954");

        private const int WM_SETCURSOR = 0x0020;
        private const int IDC_HAND = 32649;

        #endregion
        #region Use Win32 hand cursor

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SETCURSOR)
            {
                NativeMethods.SetCursor(NativeMethods.LoadCursor(IntPtr.Zero, IDC_HAND));
                msg.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref msg);
        }

        #endregion

        public XRails_LinkLabel()
        {
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            BackColor = Color.Transparent;
            LinkColor = linkColor;
            ActiveLinkColor = activeLinkColor;
            VisitedLinkColor = activeLinkColor;
            LinkBehavior = LinkBehavior.NeverUnderline;
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            ActiveLinkColor = activeLinkColor;
            VisitedLinkColor = activeLinkColor;
        }
    }

    #endregion
    #region Label

    public class XRails_Label : Label
    {
        public XRails_Label()
        {
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            BackColor = Color.Transparent;
            ForeColor = ColorTranslator.FromHtml("#72767F");
            Cursor = Cursors.Arrow;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }
    }

    #endregion
    #region TextBox

    [DefaultEvent("TextChanged")]
    public class XRails_TextBox : Control
    {
        #region Variables

        internal TextBox XRailsTB = new TextBox();

        private Pen borderColor;
        private Panel _WatermarkContainer;
        private SolidBrush _WatermarkBrush;

        #endregion
        #region Properties

        private bool _ColorBordersOnEnter = true;
        [Browsable(true)]
        [Description("Decides whether the top and bottom border lines are recolored on Enter event.")]
        public bool ColorBordersOnEnter
        {
            get { return _ColorBordersOnEnter; }
            set
            {
                _ColorBordersOnEnter = value;
            }
        }

        private Image _Image;
        [Browsable(true)]
        [Description("The image displayed in the TextBox.")]
        public Image Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                _ImageSize = value == null ? Size.Empty : value.Size;
                XRailsTB.Location = new Point(24, 14);

                Invalidate();
            }
        }

        private Size _ImageSize;
        protected Size ImageSize
        {
            get { return _ImageSize; }
        }

        private int _MaxLength = 32767;
        [Browsable(true)]
        [Description("Specifies the maximum number of characters that can be entered into the edit control.")]
        public int MaxLength
        {
            get { return _MaxLength; }
            set
            {
                _MaxLength = value;
                XRailsTB.MaxLength = MaxLength;
                Invalidate();
            }
        }

        private bool _Multiline;
        [Browsable(true)]
        [Description("Controls whether the text of the edit control can span more than one line.")]
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (XRailsTB != null)
                {
                    XRailsTB.Multiline = value;
                    if (value) { XRailsTB.Height = Height - 10; }
                    else       { Height = XRailsTB.Height + 10; }
                }
            }
        }

        private bool _ReadOnly;
        [Browsable(true)]
        [Description("Controls whether the text in the edit control can be changed or not.")]
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (XRailsTB != null) { XRailsTB.ReadOnly = value; }
            }
        }

        private bool _ShortcutsEnabled = true;
        [Browsable(true)]
        [Description("Indicates whether shortcuts defined for the control are enabled.")]
        public bool ShortcutsEnabled
        {
            get { return _ShortcutsEnabled; }
            set
            {
                _ShortcutsEnabled = value;
                XRailsTB.ShortcutsEnabled = value;
            }
        }

        private bool _ShowBottomBorder = true;
        [Browsable(true)]
        [Description("Decides whether the bottom border line should be drawn.")]
        public bool ShowBottomBorder
        {
            get { return _ShowBottomBorder; }
            set
            {
                _ShowBottomBorder = value;
                Invalidate();
            }
        }

        private bool _ShowTopBorder = true;
        [Browsable(true)]
        [Description("Decides whether the top border line should be drawn.")]
        public bool ShowTopBorder
        {
            get { return _ShowTopBorder; }
            set
            {
                _ShowTopBorder = value;
                Invalidate();
            }
        }

        private HorizontalAlignment _TextAlignment;
        [Browsable(true)]
        [Description("Indicates how the text should be aligned for edit controls.")]
        public HorizontalAlignment TextAlignment
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }

        private bool _UseSystemPasswordChar = false;
        [Browsable(true)]
        [Description("Indicates if the text in the edit control should appear as the default password character.")]
        public bool UseSystemPasswordChar
        {
            get { return _UseSystemPasswordChar; }
            set
            {
                _UseSystemPasswordChar = value;
                XRailsTB.UseSystemPasswordChar = UseSystemPasswordChar;
                Invalidate();
            }
        }

        private string _Watermark = string.Empty;
        [Browsable(true)]
        [Description("Allows adding a watermark to the TextBox field when it is empty.")]
        public string Watermark
        {
            get { return _Watermark; }
            set
            {
                _Watermark = value;
                Invalidate();
            }
        }

        private Color  _WatermarkColor;
        [Browsable(true)]
        [Description("Allows adding a watermark to the TextBox field when it is empty.")]
        public Color WatermarkColor
        {
            get { return _WatermarkColor; }
            set
            {
                _WatermarkColor = value;
                Invalidate();
            }
        }

        #endregion
        #region EventArgs

        private void _Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void _Enter(object sender, EventArgs e)
        {
            if (_ColorBordersOnEnter)
                borderColor = new Pen(ColorTranslator.FromHtml("#F25D59"));

            _WatermarkBrush = new SolidBrush(_WatermarkColor);

            if (XRailsTB.TextLength <= 0)
            {
                RemoveWatermark();
                DrawWatermark();
            }
            Invalidate();
        }

        private void _Leave(object sender, EventArgs e)
        {
            if (_ColorBordersOnEnter)
                borderColor = new Pen(ColorTranslator.FromHtml("#3C3F50"));

            _WatermarkBrush = new SolidBrush(_WatermarkColor);

            if (XRailsTB.TextLength <= 0) { RemoveWatermark(); }
            else { Invalidate(); }

            Invalidate();
        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                XRailsTB.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                XRailsTB.Copy();
                e.SuppressKeyPress = true;
            }

            OnKeyDown(e);
        }

        private void _KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void WatermarkContainer_Click(object sender, EventArgs e)
        {
            XRailsTB.Focus();
        }

        private void WatermarkContainer_Paint(object sender, PaintEventArgs e)
        {
            // X has to be >=1, otherwise the cursor won't show
            _WatermarkContainer.Location = new Point(1, -1);
            _WatermarkContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _WatermarkContainer.Width = XRailsTB.Width - 25;
            _WatermarkContainer.Height = XRailsTB.Height;

            _WatermarkBrush = new SolidBrush(_WatermarkColor);
            e.Graphics.DrawString(_Watermark, Font, _WatermarkBrush, new PointF(-3.0F, 1.0F));
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            XRailsTB.Font = Font;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

            XRailsTB.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            XRailsTB.Focus();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (_Multiline) { XRailsTB.Height = Height - 30; }
            else            { Height = XRailsTB.Height + 32; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            XRailsTB.Text = Text;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            if (_WatermarkContainer != null)
                _WatermarkContainer.Invalidate();
        }

        #endregion

        public XRails_TextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.AllPaintingInWmPaint         |
                     ControlStyles.OptimizedDoubleBuffer        |
                     ControlStyles.UserPaint, true);

            DoubleBuffered = true;

            _WatermarkColor = ColorTranslator.FromHtml ("#747881");
            _WatermarkBrush = new SolidBrush(_WatermarkColor);
            _WatermarkContainer = null;

            AddTextBox();
            Controls.Add(XRailsTB);
            DrawWatermark();

            borderColor = new Pen(ColorTranslator.FromHtml("#3C3F50"));
            BackColor = ColorTranslator.FromHtml("#2B3043");

            Text = null;
            Font = new Font("Segoe UI", 10);
            Size = new Size(145, 49);
        }

        private void AddTextBox()
        {
            XRailsTB.Size = new Size(Width - 10, 49);
            XRailsTB.Location = new Point(24, 14);
            XRailsTB.Text = string.Empty;
            XRailsTB.BorderStyle = BorderStyle.None;
            XRailsTB.TextAlign = HorizontalAlignment.Left;
            XRailsTB.Font = new Font("Segoe UI", 10);
            XRailsTB.UseSystemPasswordChar = UseSystemPasswordChar;
            XRailsTB.ShortcutsEnabled = ShortcutsEnabled;
            XRailsTB.Multiline = false;
            XRailsTB.BackColor = ColorTranslator.FromHtml("#2B3043");
            ForeColor = ColorTranslator.FromHtml("#7F838C");

            // Event handlers
            XRailsTB.TextChanged += _TextChanged;
            XRailsTB.KeyDown += _KeyDown;
            XRailsTB.KeyPress += _KeyPress;
            XRailsTB.KeyUp += _KeyUp;
            XRailsTB.Click += _Click;
            XRailsTB.Enter += _Enter;
            XRailsTB.Leave += _Leave;
        }

        private void DrawWatermark()
        {
            if (_WatermarkContainer == null && XRailsTB.TextLength <= 0)
            {
                _WatermarkContainer = new Panel();
                _WatermarkContainer.Paint += WatermarkContainer_Paint;
                _WatermarkContainer.Invalidate();
                _WatermarkContainer.Click += WatermarkContainer_Click;
                XRailsTB.Controls.Add(_WatermarkContainer);
            }
        }

        private void RemoveWatermark()
        {
            if (_WatermarkContainer != null)
            {
                XRailsTB.Controls.Remove(_WatermarkContainer);
                _WatermarkContainer = null;
            }
        }

        public void _TextChanged(object sender, EventArgs e)
        {
            Text = XRailsTB.Text;

            if (XRailsTB.TextLength > 0)
                RemoveWatermark();
            else
                DrawWatermark();
        }

        public void _BaseTextChanged(object sender, EventArgs e)
        {
            XRailsTB.Text = Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var bitmap = new Bitmap(Width, Height);
            var g = Graphics.FromImage(bitmap);

            DrawWatermark();
            g.SmoothingMode = SmoothingMode.None;

            if (Image == null) { XRailsTB.Width = Width - 35; }
            else
            {
                XRailsTB.Location = new Point(48, XRailsTB.Location.Y);
                XRailsTB.Width = Width - 59;
            }

            XRailsTB.TextAlign = TextAlignment;
            XRailsTB.UseSystemPasswordChar = UseSystemPasswordChar;

            // Top border
            if (_ShowTopBorder)
            {
                g.DrawLine(borderColor, 0, 0, Width - 1, 0);
                g.DrawLine(borderColor, 0, 1, Width - 1, 1);
            }

            // Bottom border
            if (_ShowBottomBorder)
            {
                g.DrawLine(borderColor, 0, Height - 2, Width - 1, Height - 2);
                g.DrawLine(borderColor, 0, Height - 1, Width - 1, Height - 1);
            }

            if (Image != null)
                g.DrawImage(_Image, 23, 14, 16, 16);

            e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);

            g.Dispose();
            bitmap.Dispose();
        }
    }

    #endregion
    #region Button

    public class XRails_Button : Control, IButtonControl
    {
        #region General Variables

        private readonly Timer animationTimer;
        private int buttonGlow;
        private int stringGlow;
        private bool hoverButton;

        private int mouseState;
        private Rectangle R1;
        private readonly StringFormat stringFormat;

        private const int WM_SETCURSOR = 0x0020;
        private const int IDC_HAND = 32649;

        #endregion
        #region Properties

        private Color _ForeColor = ColorTranslator.FromHtml("#F25D59");
        [Browsable(true)]
        [Description("The foreground color of this component, which is used to display text.")]
        public override Color ForeColor
        {
            get { return _ForeColor; }
            set
            {
                _ForeColor = value;
                Invalidate();
            }
        }

        private int _Radius = 20;
        [Browsable(true)]
        [Description("Sets the radius of curvature for the control.")]
        public int Radius
        {
            get { return _Radius; }
            set
            {
                if (!(value < 1 || value > 20)) { _Radius = value; }
                else { throw new Exception("The entered value cannot be less than 1 or greater than 20."); }

                Invalidate();
            }
        }

        #endregion
        #region IButtonControl

        private bool _IsDefault;
        private DialogResult dlgResult;

        /// <summary>
        /// Gets or sets a value that indicates whether a Button is the default
        /// button. A user invokes the default button by pressing the ENTER key.
        /// </summary>
        [Browsable(false)]
        private bool IsDefault
        {
            get { return _IsDefault; }
        }

        /// <summary>
        /// Gets or sets the value returned to the parent form when the button
        /// is clicked.
        /// </summary>
        public DialogResult DialogResult
        {
            get { return dlgResult; }
            set
            {
                if (Enum.IsDefined(typeof(DialogResult), value))
                    dlgResult = value;
            }
        }

        /// <summary>
        /// Notifies a control that it is the default button so that its
        /// appearance and behavior is adjusted accordingly.
        /// </summary>
        /// 
        /// <param name="value">
        /// True if the button is to have the appearance of the default button;
        /// otherwise, false.
        /// </param>
        public void NotifyDefault(bool value)
        {
            _IsDefault = value;
        }

        /// <summary>
        /// Generates a Click event for the control.
        /// </summary>
        public void PerformClick()
        {
            if (CanSelect) { OnClick(EventArgs.Empty); }
        }

        #endregion
        #region Create Round Rectangle
        
        // Snippet by RodStephens
        private static GraphicsPath RoundedRect(RectangleF rect, float x_radius, float y_radius,
                                                                 bool round_upperLeft, bool round_upperRight,
                                                                 bool round_lowerRight, bool round_lowerLeft)
        {
            PointF point1, point2;
            var path = new GraphicsPath();

            // Upper left corner
            if (round_upperLeft)
            {
                var corner = new RectangleF(rect.X, rect.Y, 2 * x_radius, 2 * y_radius);
                path.AddArc(corner, 180, 90);
                point1 = new PointF(rect.X + x_radius, rect.Y);
            }
            else { point1 = new PointF(rect.X, rect.Y); }

            // Top side
            if (round_upperRight) { point2 = new PointF(rect.Right - x_radius, rect.Y); }
            else
            {
                point2 = new PointF(rect.Right, rect.Y);
                path.AddLine(point1, point2);
            }

            // Upper right corner
            if (round_upperRight)
            {
                var corner = new RectangleF(rect.Right - 2 * x_radius, rect.Y, 2 * x_radius, 2 * y_radius);
                path.AddArc(corner, 270, 90);
                point1 = new PointF(rect.Right, rect.Y + y_radius);
            }
            else { point1 = new PointF(rect.Right, rect.Y); }

            // Right side
            if (round_lowerRight) { point2 = new PointF(rect.Right, rect.Bottom - y_radius); }
            else
            {
                point2 = new PointF(rect.Right, rect.Bottom);
                path.AddLine(point1, point2);
            }

            // Lower right corner
            if (round_lowerRight)
            {
                var corner = new RectangleF(rect.Right - 2 * x_radius, rect.Bottom - 2 * y_radius, 2 * x_radius, 2 * y_radius);
                path.AddArc(corner, 0, 90);
                point1 = new PointF(rect.Right - x_radius, rect.Bottom);
            }
            else { point1 = new PointF(rect.Right, rect.Bottom); }

            // Bottom side
            if (round_lowerLeft) { point2 = new PointF(rect.X + x_radius, rect.Bottom); }
            else
            {
                point2 = new PointF(rect.X, rect.Bottom);
                path.AddLine(point1, point2);
            }

            // Lower left corner
            if (round_lowerLeft)
            {
                var corner = new RectangleF(rect.X, rect.Bottom - 2 * y_radius, 2 * x_radius, 2 * y_radius);
                path.AddArc(corner, 90, 90);
                point1 = new PointF(rect.X, rect.Bottom - y_radius);
            }
            else { point1 = new PointF(rect.X, rect.Bottom); }

            // Left side
            if (round_upperLeft) { point2 = new PointF(rect.X, rect.Y + y_radius); }
            else
            {
                point2 = new PointF(rect.X, rect.Y);
                path.AddLine(point1, point2);
            }

            path.CloseFigure();
            return path;
        }

        #endregion
        #region EventArgs

        protected override void OnMouseUp(MouseEventArgs e)
        {
            mouseState = 0;
            Invalidate();
            base.OnMouseUp(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseState = 1;
            Invalidate();
            Focus();
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            mouseState = 3;
            hoverButton = true;
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mouseState = 0;
            hoverButton = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Invalidate();
            base.OnTextChanged(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            animationTimer.Start();
        }

        protected override void OnResize(EventArgs e)
        {
            if (Width > 0 && Height > 0)
            {
                R1 = new Rectangle(0, 0, Width, Height);
            }

            Invalidate();
            base.OnResize(e);
        }

        #endregion

        public XRails_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint         |
                     ControlStyles.OptimizedDoubleBuffer        |
                     ControlStyles.ResizeRedraw                 |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);

            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10);
            ForeColor = ColorTranslator.FromHtml("#F25D59");
            Size = new Size(144, 47);
            MinimumSize = new Size(144, 47);
            
            stringFormat = new StringFormat
            { 
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            animationTimer = new Timer { Interval = 1 };
            animationTimer.Tick += Animation;
        }

        #region Use Win32 hand cursor

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SETCURSOR)
            {
                NativeMethods.SetCursor(NativeMethods.LoadCursor(IntPtr.Zero, IDC_HAND));
                msg.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref msg);
        }

        #endregion

        private void Animation(object sender, EventArgs e)
        {
            if (hoverButton)
            {
                if (buttonGlow < 242) { buttonGlow += 15; }
                if (stringGlow < 160) { stringGlow += 15; }
            }
            else
            {
                if (buttonGlow >= 15) { buttonGlow -= 15; }
                if (stringGlow >= 15) { stringGlow -= 15; }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode     = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode   = PixelOffsetMode.HighQuality;

            const float margin = 3;
            float width  = ClientSize.Width - 2 * margin;
            float height = ClientSize.Height - 6;

            var rect = new RectangleF(margin, margin, width, height);
            var path = RoundedRect(rect, _Radius, _Radius, false, true, true, false);

            // Fill the button with animation when the mouse is over the control
            g.FillPath(new SolidBrush(Color.FromArgb(buttonGlow, Color.FromArgb(242, 93, 89))), path);

            switch (mouseState)
            {
                case 0: // Inactive state
                    using (var pen = new Pen(ColorTranslator.FromHtml("#F25D59"), 2.0F))
                    using (var brush = new SolidBrush(ColorTranslator.FromHtml("#F25D59")))
                    {
                        g.DrawPath(pen, path);
                        g.DrawString(Text, Font, brush, R1, stringFormat);
                    }
                    break;
                case 1: // Pressed state
                    using (var pen = new Pen(ColorTranslator.FromHtml("#F25D59"), 2.0F))
                    using (var brush = new SolidBrush(ColorTranslator.FromHtml("#FFFFFF")))
                    {
                        g.DrawPath(pen, path);
                        g.DrawString(Text, Font, brush, R1, stringFormat);
                    }
                    break;
                case 3: // Hover state
                    using (var pen = new Pen(ColorTranslator.FromHtml("#F25D59"), 2.0F))
                    using (var brush = new SolidBrush(Color.FromArgb(80 + stringGlow, Color.White)))
                    {
                        g.DrawPath(pen, path);
                        g.DrawString(Text, Font, brush, R1, stringFormat);

                    }
                    break;
            }

            base.OnPaint(e);
        }
    }

    #endregion
}
