using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace viusal
{
    public class STabControl : TabControl
    {
        private Container components = null;

        public STabControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }
        
        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr HWND;
            public uint idFrom;
            public int code;
            public override string ToString()
            {
                return string.Format("Hwnd: {0}, ControlID: {1}, Code: {2}", HWND, idFrom, code);
            }
        }

        private const int TCN_FIRST = 0 - 550;
        private const int TCN_SELCHANGING = (TCN_FIRST - 2);

        private const int WM_USER = 0x400;
        private const int WM_NOTIFY = 0x4E;
        private const int WM_REFLECT = WM_USER + 0x1C00;

        private Color m_Backcolor = Color.Empty;

        [Description("Occurs as a tab is being changed.")]
        public event SelectedTabPageChangeEventHandler SelectedIndexChanging;

        [Browsable(true), Description("The background color used to display text and graphics in a control.")]
        public override Color BackColor
        {
            get
            {
                if (m_Backcolor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Control.DefaultBackColor;
                    else
                        return Parent.BackColor;
                }
                return m_Backcolor;
            }
            set
            {
                if (m_Backcolor.Equals(value)) return;
                m_Backcolor = value;
                Invalidate();

                base.OnBackColorChanged(EventArgs.Empty);
            }
        }

        public bool ShouldSerializeBackColor()
        {
            return !m_Backcolor.Equals(Color.Empty);
        }

        public override void ResetBackColor()
        {
            m_Backcolor = Color.Empty;
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
        
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            if (TabCount == 0)
                return;

            Rectangle r = ClientRectangle;
            r = SelectedTab.Bounds;
            r.Inflate(3, 3);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            TabPage page = TabPages[SelectedIndex];
            SolidBrush PaintBrush = new SolidBrush(page.BackColor);
            Color color2 = Color.FromArgb(
                page.BackColor.R + 30,
                page.BackColor.G + 30,
                page.BackColor.B + 30);

            e.Graphics.FillRectangle(PaintBrush, r);
            e.Graphics.DrawRectangle(new Pen(color2), r);

            for (int i = 0; i < TabCount; i++)
            {
                page = TabPages[i];
                r = GetTabRect(i);

                ButtonBorderStyle bs = i == SelectedIndex ? ButtonBorderStyle.Outset : ButtonBorderStyle.Inset;
                PaintBrush.Color = i == SelectedIndex ? color2 : page.BackColor;

                e.Graphics.FillRectangle(PaintBrush, r);
                ControlPaint.DrawBorder(e.Graphics, r, PaintBrush.Color, bs);

                if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
                {
                    float RotateAngle = Alignment == TabAlignment.Left ? 270 : 90;
                    PointF cp = new PointF(r.Left + (r.Width >> 1), r.Top + (r.Height >> 1));
                    e.Graphics.TranslateTransform(cp.X, cp.Y);
                    e.Graphics.RotateTransform(RotateAngle);
                    r = new Rectangle(r.Height / -2, r.Width / -2, r.Height, r.Width);
                }

                e.Graphics.DrawString(page.Text, Font, new SolidBrush(page.ForeColor), r, sf);
                e.Graphics.ResetTransform();
            }

            PaintBrush.Dispose();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (WM_REFLECT + WM_NOTIFY))
            {
                NMHDR hdr = (NMHDR)(Marshal.PtrToStructure(m.LParam, typeof(NMHDR)));
                if (hdr.code == TCN_SELCHANGING)
                {
                    TabPage tp = TestTab(PointToClient(Cursor.Position));
                    if (tp != null)
                    {
                        TabPageChangeEventArgs e = new TabPageChangeEventArgs(SelectedTab, tp);
                        if (SelectedIndexChanging != null)
                            SelectedIndexChanging(this, e);
                        if (e.Cancel || tp.Enabled == false)
                        {
                            m.Result = new IntPtr(1);
                            return;
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }
        
        private TabPage TestTab(Point pt)
        {
            for (int index = 0; index <= TabCount - 1; index++)
            {
                if (GetTabRect(index).Contains(pt.X, pt.Y))
                    return TabPages[index];
            }
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion
    }


    public class TabPageChangeEventArgs : EventArgs
    {
        private TabPage _Selected = null;
        private TabPage _PreSelected = null;
        public bool Cancel = false;

        public TabPage CurrentTab
        {
            get
            {
                return _Selected;
            }
        }

        public TabPage NextTab
        {
            get
            {
                return _PreSelected;
            }
        }

        public TabPageChangeEventArgs(TabPage CurrentTab, TabPage NextTab)
        {
            _Selected = CurrentTab;
            _PreSelected = NextTab;
        }
    }


    public delegate void SelectedTabPageChangeEventHandler(Object sender, TabPageChangeEventArgs e);

}