using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viusal
{
    public partial class Shema : Form
    {
        List<List<string>> mxnf;
        Brush brush1, brush2;
        Pen pen1, pen2;

        public Shema(List<List<string>> mxnf)
        {
            InitializeComponent();

            this.mxnf = mxnf;
            updateBrushs();
            viewport.Paint += Viewport_Paint;
        }

        private void Setting_ValueChanged(object sender, EventArgs e)
        {
            viewport.Size = new Size((int)sizeW.Value, (int)sizeH.Value);
            viewport.Invalidate(false);
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            ((Control)sender).BackColor = colorDialog1.Color;
            updateBrushs();

            viewport.Invalidate(false);
        }

        private void updateBrushs()
        {
            pen1 = new Pen(color1.BackColor);
            pen2 = new Pen(color2.BackColor);
            brush1 = new SolidBrush(color1.BackColor);
            brush2 = new SolidBrush(color2.BackColor);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            Bitmap bmp = new Bitmap(viewport.Width, viewport.Height);
            viewport.DrawToBitmap(bmp, new Rectangle(0, 0, viewport.Width, viewport.Height));
            bmp.Save(saveDialog.FileName);
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            viewport.BackColor = colorDialog1.Color;
            panel1.BackColor = colorDialog1.Color;
            ((Control)sender).BackColor = colorDialog1.Color;
        }

        private void Viewport_Paint(object sender, PaintEventArgs e)
        {
            int d = (int)grid.Value;

            int x;
            if(useInvert.Checked)
                x = d * (mxnf.Count * 2 + 2);
            else
                x = d * (mxnf.Count + 3);

            int _x = 0;
            int sx = x - d * 3;
            int _y = 0;
            int y = x;
            int mx = 0;

            var outputT = new List<Point>();
            for (int i = 0; i < mxnf.Count; i++)
            {
                var output = new List<int>();

                for (int j = 0; j < mxnf[i].Count; j++)
                {
                    _y = y;
                    foreach (char c in mxnf[i][j])
                    {
                        if (useInvert.Checked)
                        {
                            if (c < 'a')
                                _x = sx - d * (c - 'A') * 2 + d;
                            else
                                _x = sx - d * (c - 'a') * 2;
                        }
                        else
                        {
                            _x = sx - d * (char.ToLower(c) - 'a');
                            if (c >= 'a')
                                e.Graphics.DrawEllipse(pen1, x - d / 3, y - d / 3, d / 3 * 2, d / 3 * 2);
                        }

                        e.Graphics.DrawLine(pen1, _x, y, x, y);
                        e.Graphics.FillEllipse(brush1, _x - 3, y - 3, d / 3 * 2, d / 3 * 2);
                        y += d;
                    }

                    e.Graphics.DrawRectangle(pen1, x, _y - d / 2, d * 3, y - _y);
                    e.Graphics.DrawString("&", Font, brush2, x + d / 3 * 2, _y - d / 3);

                    _x = x + d * 3;
                    _y = y - d / 2 - (y - _y) / 2;
                    e.Graphics.DrawEllipse(pen1, _x - 3, _y - 3, d / 3 * 2, d / 3 * 2);
                    e.Graphics.DrawLine(pen1, _x, _y, _x + d, _y);

                    output.Add(_y);
                    y += d * 2;
                }

                _x += d;
                int _mx = _x + d * (4 + output.Count);

                if (output.Count != 1)
                {
                    int _sx = _x;
                    _x += d;
                    for (int j = 0; j < output.Count; j++)
                    {
                        _x += d;
                        _y = output[0] - d + d * (j + 1);
                        e.Graphics.DrawLine(pen1, _sx, output[j], _x, output[j]);
                        e.Graphics.DrawLine(pen1, _x, output[j], _x, _y);
                        e.Graphics.DrawLine(pen1, _x, _y, _mx, _y);
                    }
                    _y = output[0] - d + (output.Count + 1) * d;
                    e.Graphics.DrawRectangle(pen1, _mx, output[0] - d, d * 3, (output.Count + 1) * d);
                    e.Graphics.DrawString("&", Font, brush2, _mx + d / 3, output[0] - d + d / 3);
                    _y -= (output.Count + 1) * d / 2;
                    e.Graphics.DrawEllipse(pen1, _mx + d * 3 - d / 3, _y - d / 3, d / 3 * 2, d / 3 * 2);

                    output.Clear();
                    output.Add(_y);
                }

                _x = _mx + d * 3;
                if (mx < _x)
                    mx = _x;

                outputT.Add(new Point(_x, _y));
                y += d * 3;
            }
            mx += d * 4;

            bool first = true;
            var outputT2 = new List<int>();
            foreach (Point p in outputT)
            {
                e.Graphics.DrawLine(pen1, p.X, p.Y, mx, p.Y);

                _x = mx + d * 2;
                _y = p.Y + d * 7;
                e.Graphics.DrawLine(pen1, _x, p.Y - d, _x, _y);
                e.Graphics.DrawRectangle(pen1, mx, p.Y - d, d * 7, d * 8);
                e.Graphics.DrawString("TT", Font, brush2, _x + d / 3, p.Y - d / 3 * 2);
                e.Graphics.DrawString("D", Font, brush2, mx + d / 3, p.Y - d / 3 * 2);

                if (useInvert.Checked)
                    outputT2.Add(_y - d * 6);

                outputT2.Add(_y - d * 2);

                e.Graphics.DrawEllipse(pen1, mx + d * 7 - 3, _y - d * 2 - 3, d / 3 * 2, d / 3 * 2);

                _y -= d * 2;
                e.Graphics.DrawLine(pen1, mx, _y, _x, _y);
                e.Graphics.DrawString("C", Font, brush2, mx + d / 3, _y);
                _y += d;
                _x = mx - d * 2;
                e.Graphics.DrawLine(pen1, _x, _y, mx, _y);

                if (first)
                {
                    int _y2 = y + d;
                    int _x2 = _x - d * 10;

                    e.Graphics.DrawLine(pen1, _x, _y, _x, _y2);
                    e.Graphics.DrawLine(pen1, _x2, _y2, _x, _y2);
                    e.Graphics.DrawEllipse(pen1, _x2 - 6, _y2 - 3, d / 3 * 2, d / 3 * 2);
                    e.Graphics.DrawString("Clock", Font, brush2, _x2, _y2 - d * 2);
                    first = false;
                }
                else
                    e.Graphics.FillEllipse(brush1, _x - 3, _y - 3, d / 3 * 2, d / 3 * 2);
            }

            int my = y;
            int n = 1;
            mx += d * 7;
            x = d;
            y = d;

            outputT2.Reverse();
            foreach (int oy in outputT2)
            {
                int _n = outputT2.Count - n;
                char c = n % 2 == 0 ? 'A' : 'a';
                _x = mx + d * (_n+1);

                e.Graphics.DrawLine(pen1, x, y, x, my);
                e.Graphics.DrawLine(pen1, x, y, _x, y);
                e.Graphics.DrawLine(pen1, mx, oy, _x, oy);
                e.Graphics.DrawLine(pen1, _x, y, _x, oy);
                e.Graphics.DrawEllipse(pen1, x - 3, my, 6, 6);
                e.Graphics.DrawString(string.Format("{0}", (char)(c + _n / 2)), Font, brush2, x - d / 2, my + d);

                y += d;
                x += d;
                n++;
            }
        }
    }
}