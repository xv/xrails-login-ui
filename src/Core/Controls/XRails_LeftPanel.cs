/*  XRails_LeftPanel.cs
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

using System.Windows.Forms;
using System.Drawing;

namespace XRails.Controls
{
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
}