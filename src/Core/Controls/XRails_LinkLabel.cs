/*  XRails_LinkLabel.cs
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
using System;
using XRails.Classes;

namespace XRails.Controls
{
    public class XRails_LinkLabel : LinkLabel
    {
        #region Fields

        private readonly Color linkColor       = ColorTranslator.FromHtml("#F25D59");
        private readonly Color activeLinkColor = ColorTranslator.FromHtml("#DE5954");
        private readonly Cursor NativeHand;

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

            NativeHand = new Cursor(NativeMethods.LoadCursor(IntPtr.Zero, NativeConstants.IDC_HAND));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (OverrideCursor == Cursors.Hand)
                OverrideCursor = NativeHand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            OverrideCursor = null;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            ActiveLinkColor  = activeLinkColor;
            VisitedLinkColor = activeLinkColor;
        }
    }
}