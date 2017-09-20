/*  XRails_TextBox.cs
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

using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace XRails.Controls
{
    [DefaultEvent("TextChanged")]
    public class XRails_TextBox : Control
    {
        #region Fields

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
            get { return _ColorBordersOnEnter;  }
            set { _ColorBordersOnEnter = value; }
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
                    if (value)
                        XRailsTB.Height = Height - 10;
                    else
                        Height = XRailsTB.Height + 10;
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
                if (XRailsTB != null)
                    XRailsTB.ReadOnly = value;
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

            if (XRailsTB.TextLength <= 0)
                RemoveWatermark();
            else
                Invalidate();

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

            borderColor = new Pen(ColorTranslator.FromHtml("#393E51"));
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
            XRailsTB.KeyDown     += _KeyDown;
            XRailsTB.KeyPress    += _KeyPress;
            XRailsTB.KeyUp       += _KeyUp;
            XRailsTB.Click       += _Click;
            XRailsTB.Enter       += _Enter;
            XRailsTB.Leave       += _Leave;
        }

        private void DrawWatermark()
        {
            if (_WatermarkContainer != null || XRailsTB.TextLength > 0)
                return;
            
            _WatermarkContainer = new Panel();
            _WatermarkContainer.Paint += WatermarkContainer_Paint;
            _WatermarkContainer.Invalidate();
            _WatermarkContainer.Click += WatermarkContainer_Click;

            XRailsTB.Controls.Add(_WatermarkContainer);
        }

        private void RemoveWatermark()
        {
            if (_WatermarkContainer == null)
                return;
            
            XRailsTB.Controls.Remove(_WatermarkContainer);
            _WatermarkContainer = null;
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

            if (Image == null)
                XRailsTB.Width = Width - 35;
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

            bitmap.Dispose();
            g.Dispose();
        }
    }
}