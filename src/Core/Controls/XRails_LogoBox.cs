/*  XRails_TopLeftBox.cs
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

using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace XRails.Controls
{
    public class XRails_LogoBox : Control
    {
        public XRails_LogoBox()
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
}