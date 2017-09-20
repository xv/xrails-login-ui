/*  XRails_Container.cs
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
    public class XRails_Container : ContainerControl
    {
        #region Fields

        private readonly int draggableHeight;
        private bool isBeingDragged;
        private Point mouseLocation;

        private Rectangle titleBarRect;
        private int titleBar_stringLeft;
        private Rectangle titleBar_stringRect;

        #endregion
        #region Enumerations

        public enum Alignment
        {
            Left,
            Center
        }

        #endregion
        #region Custom Properties

        private bool _ControlMode;
        protected bool ControlMode
        {
            get { return _ControlMode; }
            set
            {
                _ControlMode = value;
                Invalidate();
            }
        }

        private Alignment _TextAlignment = Alignment.Left;
        [Browsable(true)]
        [Description("Indicates how the window title should be aligned.")]
        public Alignment TextAlignment
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }

        private bool _DrawIcon;
        [Browsable(true)]
        [Description("Determines whether the icon specified in the parent form should be drawn.")]
        public bool DrawIcon
        {
            get { return _DrawIcon; }
            set
            {
                _DrawIcon = value;
                Invalidate();
            }
        }

        private Color _TitleBarTextColor = Color.Gainsboro;
        [Browsable(true)]
        [Description("Sets the title bar title color.")]
        public Color TitleBarTextColor
        {
            get { return _TitleBarTextColor; }
            set
            {
                _TitleBarTextColor = value;
                Invalidate();
            }
        }

        #endregion
        #region Hidden Properties

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageLayout BackgroundImageLayout { get; set; }

        [Bindable(false),  EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage { get; set; }

        #endregion
        #region Functions

        /// <summary>
        /// Returns true if the mouse is over the title bar icon.
        /// </summary>
        private static bool IsOverTitleBarIcon(MouseEventArgs e)
        {
            var point = (e.X > 8 && e.X < 26) && (e.Y > 6 && e.Y < 22);
            return point;
        }

        #endregion
        #region EventArgs

        protected override void OnSizeChanged(EventArgs e)
        {
            if (!ControlMode)
                titleBarRect = new Rectangle(9, 2, Width, draggableHeight);

            base.OnSizeChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (titleBarRect.Contains(e.Location))
            {
                isBeingDragged = true;
                mouseLocation = e.Location;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            // Close when double-clicking on the title bar icon
            if (_DrawIcon && IsOverTitleBarIcon(e))
                Application.Exit();

            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isBeingDragged)
                Parent.Location = Point.Subtract(MousePosition, (Size)mouseLocation);

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (isBeingDragged)
                isBeingDragged = false;

            base.OnMouseUp(e);
        }

        #endregion

        public XRails_Container()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint            |
                     ControlStyles.ResizeRedraw, true);

            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            Padding = new Padding(0, 31, 0, 0);
            MinimumSize = new Size(100, 42);

            Font = new Font("Segoe UI", 9);
            Cursor = Cursors.Arrow;

            draggableHeight = 28;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();

            ParentForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.TransparencyKey = Color.Fuchsia; // IMPORTANT!
            ParentForm.BackColor = SystemColors.ControlDarkDark;
            ParentForm.MaximumSize = Screen.FromRectangle(ParentForm.Bounds).WorkingArea.Size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(SystemColors.Control);

            // Draw the title bar
            using (var brush = new SolidBrush(ColorTranslator.FromHtml("#323A3D")))
                g.FillRectangle(brush, new Rectangle(0, 0, Width, 31));

            /*  ========== FOR TESTING PURPOSES ONLY! ==========
            **  PLACEMENT BACKGROUNDS FOR THE CONTROLBOX BUTTONS
            **  ================================================
            **  using (var brush = new SolidBrush(ColorTranslator.FromHtml("#FF0000")))
            **      g.FillRectangle(brush, new Rectangle(Width - 46, 0, 46, 31));
            **
            **  using (var brush = new SolidBrush(ColorTranslator.FromHtml("#00FF00")))
            **      g.FillRectangle(brush, new Rectangle(Width - 92, 0, 46, 31));
            **
            **  using (var brush = new SolidBrush(ColorTranslator.FromHtml("#0000FF")))
            **      g.FillRectangle(brush, new Rectangle(Width - 138, 0, 46, 31));
            */
            
            // A 16x16 icon like the native window title bar
            if (DrawIcon)
            {
                titleBar_stringLeft = TextAlignment == Alignment.Left ? 33 : 5;
                g.DrawIcon(FindForm().Icon, new Rectangle(10, 7, 16, 16));
            }
            else
                titleBar_stringLeft = 5;

            titleBar_stringRect = new Rectangle(titleBar_stringLeft, 7, Width - 13, Height);

            switch (TextAlignment)
            {
                case Alignment.Left:
                    using (var stringColor = new SolidBrush(_TitleBarTextColor))
                    using (var sf = new StringFormat
                    { 
                        Alignment     = StringAlignment.Near,
                        LineAlignment = StringAlignment.Near
                    })
                    {
                        g.DrawString(Text, Font, stringColor, titleBar_stringRect, sf);
                    }
                    break;
                case Alignment.Center:
                    using (var stringColor = new SolidBrush(_TitleBarTextColor))
                    using (var sf = new StringFormat
                    { 
                        Alignment     = StringAlignment.Center,
                        LineAlignment = StringAlignment.Near
                    })
                    {
                        g.DrawString(Text, Font, stringColor, titleBar_stringRect, sf);
                    }
                    break;
            }

            base.OnPaint(e);
        }
    }
}