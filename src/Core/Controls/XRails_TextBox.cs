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
using System.Drawing;
using System.Windows.Forms;
using System;

namespace XRails.Controls
{
    [DefaultEvent("TextChanged")]
    public class XRails_TextBox : Control
    {
        #region Fields

        private TextBox tbCtrl = new TextBox();
        private Color borderColor;
        private Panel watermarkContainer;

        #endregion
        #region Properties

        [Browsable(true)]
        [Description("Decides whether the top and bottom border lines are recolored on Enter event.")]
        public bool ColorBordersOnEnter { get; set; } = true;

        private Image _Image;
        [Browsable(true)]
        [Description("The image displayed in the TextBox.")]
        public Image Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                ImageSize = value == null ? Size.Empty : value.Size;
                tbCtrl.Location = new Point(24, 14);

                Invalidate();
            }
        }

        protected Size ImageSize { get; private set; }

        private int _MaxLength = 32767;
        [Browsable(true)]
        [Description("Specifies the maximum number of characters that can be entered into the edit control.")]
        public int MaxLength
        {
            get { return _MaxLength; }
            set
            {
                _MaxLength = value;
                tbCtrl.MaxLength = MaxLength;
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
                if (tbCtrl != null)
                {
                    tbCtrl.Multiline = value;
                    if (value)
                        tbCtrl.Height = Height - 10;
                    else
                        Height = tbCtrl.Height + 10;
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
                if (tbCtrl != null)
                    tbCtrl.ReadOnly = value;
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
                tbCtrl.ShortcutsEnabled = value;
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
                tbCtrl.TextAlign = _TextAlignment;
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
                tbCtrl.UseSystemPasswordChar = UseSystemPasswordChar;
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

        private Color _WatermarkColor;
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

        private void TextBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (ColorBordersOnEnter)
                borderColor = ColorTranslator.FromHtml("#F25D59");

            if (tbCtrl.TextLength <= 0)
            {
                RemoveWatermark();
                DrawWatermark();
            }
            
            Invalidate();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (ColorBordersOnEnter)
                borderColor = ColorTranslator.FromHtml("#3C3F50");

            if (tbCtrl.TextLength <= 0)
                RemoveWatermark();
            else
                Invalidate();

            Invalidate();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                tbCtrl.SelectAll();
                e.SuppressKeyPress = true;
            }
            
            if (e.Control && e.KeyCode == Keys.C)
            {
                tbCtrl.Copy();
                e.SuppressKeyPress = true;
            }

            OnKeyDown(e);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            Text = tbCtrl.Text;

            if (tbCtrl.TextLength > 0)
                RemoveWatermark();
            else
                DrawWatermark();
        }

        private void WatermarkContainer_Click(object sender, EventArgs e)
        {
            tbCtrl.Focus();
        }

        private void WatermarkContainer_Paint(object sender, PaintEventArgs e)
        {
            // X has to be >=1, otherwise the cursor won't show
            watermarkContainer.Location = new Point(1, -1);
            watermarkContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            watermarkContainer.Width = tbCtrl.Width - 25;
            watermarkContainer.Height = tbCtrl.Height;

            using (var watermark = new SolidBrush(_WatermarkColor))
                e.Graphics.DrawString(_Watermark, Font, watermark, new PointF(-3.0f, 1.0f));
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbCtrl.Font = Font;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

            tbCtrl.ForeColor = ForeColor;
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            tbCtrl.Focus();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (_Multiline)
                tbCtrl.Height = Height - 30;
            else
                Height = tbCtrl.Height + 32;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            tbCtrl.Text = Text;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            if (watermarkContainer != null)
                watermarkContainer.Invalidate();
        }

        #endregion

        public XRails_TextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint, true);

            DoubleBuffered = true;

            _WatermarkColor = ColorTranslator.FromHtml("#747881");
            watermarkContainer = null;

            AddTextBox();
            DrawWatermark();

            borderColor = ColorTranslator.FromHtml("#3C3F50");
            BackColor = ColorTranslator.FromHtml("#2B3043");

            Text = string.Empty;
            Font = new Font("Segoe UI", 10);
            Size = new Size(145, 49);
        }

        /// <summary>
        /// Adds an actual <see cref="TextBox"/> control to this control.
        /// </summary>
        private void AddTextBox()
        {
            tbCtrl.Size = new Size(Width - 10, 49);
            tbCtrl.Location = new Point(24, 14);
            tbCtrl.BorderStyle = BorderStyle.None;
            tbCtrl.TextAlign = HorizontalAlignment.Left;
            tbCtrl.Font = new Font("Segoe UI", 10);
            tbCtrl.UseSystemPasswordChar = _UseSystemPasswordChar;
            tbCtrl.ShortcutsEnabled = _ShortcutsEnabled;
            tbCtrl.Multiline = false;
            tbCtrl.BackColor = ColorTranslator.FromHtml("#2B3043");

            ForeColor = ColorTranslator.FromHtml("#7F838C");

            tbCtrl.TextChanged += TextBox_TextChanged;
            tbCtrl.KeyDown += TextBox_KeyDown;
            tbCtrl.KeyPress += TextBox_KeyPress;
            tbCtrl.KeyUp += TextBox_KeyUp;
            tbCtrl.Click += TextBox_Click;
            tbCtrl.Enter += TextBox_Enter;
            tbCtrl.Leave += TextBox_Leave;

            Controls.Add(tbCtrl);
        }

        /// <summary>
        /// Adds a watermark container.
        /// </summary>
        private void DrawWatermark()
        {
            if (watermarkContainer != null || tbCtrl.TextLength > 0)
                return;
            
            watermarkContainer = new Panel();
            watermarkContainer.Paint += WatermarkContainer_Paint;
            watermarkContainer.Click += WatermarkContainer_Click;
            
            tbCtrl.Controls.Add(watermarkContainer);
        }

        /// <summary>
        /// Removes the watermark container.
        /// </summary>
        private void RemoveWatermark()
        {
            if (watermarkContainer == null)
                return;
            
            tbCtrl.Controls.Remove(watermarkContainer);
            watermarkContainer = null;
        }

        /// <summary>
        /// Draws the borders of the contorl.
        /// </summary>
        /// 
        /// <param name="g">Reference to the Graphics class.</param>
        private void DrawBorder(Graphics g)
        {
            using (var border = new Pen(borderColor))
            {
                // Top border
                if (_ShowTopBorder)
                {
                    g.DrawLine(border, 0, 0, Width - 1, 0);
                    g.DrawLine(border, 0, 1, Width - 1, 1);
                }

                // Bottom border
                if (_ShowBottomBorder)
                {
                    g.DrawLine(border, 0, Height - 2, Width - 1, Height - 2);
                    g.DrawLine(border, 0, Height - 1, Width - 1, Height - 1);
                }
            }
        }

        /// <summary>
        /// If the <see cref="Image"/> property value is specified, the image
        /// will be drawn.
        /// /// </summary>
        /// 
        /// <param name="g">Reference to the Graphics class.</param>
        private void DrawImage(Graphics g)
        {
            if (Image == null)
                tbCtrl.Width = Width - 35;
            else
            {
                tbCtrl.Location = new Point(48, tbCtrl.Location.Y);
                tbCtrl.Width = Width - 59;

                g.DrawImage(_Image, 23, 14, 16, 16);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            DrawWatermark();
            DrawBorder(g);
            DrawImage(g);

            base.OnPaint(e);
        }
    }
}