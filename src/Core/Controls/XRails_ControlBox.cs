/*  XRails_ControlBox.cs
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
    public class XRails_ControlBox : Control
    {
        #region Fields

        private bool hover_min, hover_max, hover_close;

        #endregion
        #region Custom Properties

        private bool _EnableMaximize = false;
        [Browsable(true)]
        [Description("Determines whether the control should enable the use of the maximize button.")]
        public bool EnableMaximizeButton
        {
            get { return _EnableMaximize; }
            set
            {
                _EnableMaximize = value;
                Invalidate();
            }
        }

        private bool _EnableMinimize = true;
        [Browsable(true)]
        [Description("Determines whether the control should enable the use of the minimize button.")]
        public bool EnableMinimizeButton
        {
            get { return _EnableMinimize; }
            set
            {
                _EnableMinimize = value;
                Invalidate();
            }
        }

        #endregion
        #region Hidden Properties

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageLayout BackgroundImageLayout { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new RightToLeft RightToLeft { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ContextMenuStrip ContextMenuStrip { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size MinimumSize { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size MaximumSize { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Font Font { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Margin { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Tag { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text { get; set; }

        #endregion
        #region EventArgs

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(139, 31);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.X > 0 && e.X < 47 && 
                e.Y > 0 && e.Y < 31)
            {
                hover_min   = true;
                hover_max   = false;
                hover_close = false;
            }
            else if (e.X > 46 && e.X < 94 && 
                     e.Y > 0  && e.Y < 31)
            {
                hover_min   = false;
                hover_max   = true;
                hover_close = false;
            }
            else if (e.X > 93 && e.X < 150 && 
                     e.Y > 0  && e.Y < 31)
            {
                hover_min   = false;
                hover_max   = false;
                hover_close = true;
            }
            else
            {
                hover_min   = false;
                hover_max   = false;
                hover_close = false;
            }

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hover_min   = false;
            hover_max   = false;
            hover_close = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Parent form
            var pf = FindForm();

            if (_EnableMaximize)
            {
                if (hover_max & e.Button == MouseButtons.Left)
                {
                    switch (pf.WindowState)
                    {
                        case FormWindowState.Normal:
                            pf.WindowState = FormWindowState.Maximized;
                            break;
                        case FormWindowState.Maximized:
                            pf.WindowState = FormWindowState.Normal;
                            break;
                    }
                }
            }

            if (_EnableMinimize)
            {
                if (hover_min & e.Button == MouseButtons.Left)
                    pf.WindowState = FormWindowState.Minimized;
            }

            if (hover_close & e.Button == MouseButtons.Left)
                Application.Exit();
        }

        #endregion

        public XRails_ControlBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cursor = Cursors.Arrow;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Location = new Point(FindForm().Width - 139, 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            // This defines the size of the background that is drawn when
            // the mouse moves over one of the three ControlBox buttons
            var btnBackgroundSize = new Size(46, Height);

            // Minimize button
            var minimizeBtnFont = new Font("Tahoma", 12);
            var minimizeBtnPoint = new Point(15, 5);
            var minimizeBtnBrush = new SolidBrush(_EnableMinimize ? ColorTranslator.FromHtml("#A0A0A0") : 
                                                                    ColorTranslator.FromHtml("#696969"));

            if (hover_min && _EnableMinimize)
            {
                using (var backColor = new SolidBrush(Color.FromArgb(15, Color.White)))
                    g.FillRectangle(backColor, new Rectangle(new Point(1, 0), btnBackgroundSize));

                minimizeBtnBrush = new SolidBrush(Color.White);
            }

            g.DrawString("\u2212", minimizeBtnFont, minimizeBtnBrush, minimizeBtnPoint);
            minimizeBtnBrush.Dispose();
            minimizeBtnFont.Dispose();

            // Maxmize button
            var maximizeBtnFont = new Font("Marlett", 9);
            var maximizeBtnPoint = new Point(63, 10);
            var maximizeBtnBrush = new SolidBrush(_EnableMaximize ? ColorTranslator.FromHtml("#A0A0A0") : 
                                                                    ColorTranslator.FromHtml("#696969"));

            if (hover_max && _EnableMaximize)
            {
                using (var backColor = new SolidBrush(Color.FromArgb(15, Color.White)))
                    g.FillRectangle(backColor, new Rectangle(new Point(47, 0), btnBackgroundSize));

                maximizeBtnBrush = new SolidBrush(Color.White);
            }

            g.DrawString(FindForm().WindowState != FormWindowState.Maximized ? "1" : "2", 
                         maximizeBtnFont, maximizeBtnBrush, maximizeBtnPoint);

            maximizeBtnBrush.Dispose();
            maximizeBtnFont.Dispose();

            // Close button
            var closeBtnFont = new Font("Tahoma", 11);
            var closeBtnPoint = new Point(107, 6);
            var closeBtnBrush = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (hover_close)
            {
                using (var backColor = new SolidBrush(ColorTranslator.FromHtml("#C75050")))
                    g.FillRectangle(backColor, new Rectangle(new Point(93, 0), btnBackgroundSize));

                closeBtnBrush = new SolidBrush(Color.White);
            }

            g.DrawString("\u2A09", closeBtnFont, closeBtnBrush, closeBtnPoint);
            closeBtnBrush.Dispose();
            closeBtnFont.Dispose();

            base.OnPaint(e);
        }
    }
}