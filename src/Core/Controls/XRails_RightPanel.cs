/*  XRails_RightPanel.cs
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
using System.Windows.Forms;

namespace XRails.Controls
{
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
}