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
    public partial class Diagramm : Form
    {
        List<List<bool>> timeline;

        public Diagramm(Dictionary<List<bool>, List<bool>> table)
        {
            InitializeComponent();

            timeline = new List<List<bool>>();
            var current = table.First().Key;
            for (int i = 0; i < table.Count; i++)
            {
                foreach (var t in table)
                {
                    if (t.Key.SequenceEqual(current))
                    {
                        current = t.Value;
                        timeline.Add(t.Value);
                        break;
                    }
                }
            }
            timeline.Insert(0, timeline.Last());
            timeline.RemoveAt(timeline.Count - 1);
            viewport.Paint += Viewport_Paint;

            for (int i = 0; i < timeline.Count; i++)
            {
                string line = i.ToString() + ":\t";
                for (int j = 0; j < timeline[i].Count; j++)
                    line += timeline[i][j] ? "1" : "0";
                this.table.Items.Add(line);
            }
        }

        private void Viewport_Paint(object sender, PaintEventArgs e)
        {
            int y = 0;
            int x = 0;
            int h = (int)stepH.Value;
            int dy = (int)delta.Value + h;
            int dx = (int)stepW.Value;
            int endX = (int)(loopCount.Value * timeline.Count * dx);
            Pen pen = new Pen(color1.BackColor);
            Brush brush = new SolidBrush(color2.BackColor);


            for (int j = 0; j < timeline.First().Count; j++)
            {
                e.Graphics.DrawString(string.Format("{0}", (char)('A' + j)), Font, brush, 0, y);
                y += dy;
            }
            e.Graphics.DrawString("clock", Font, brush, 0, y + dy);

            while (x < endX)
            {
                for (int i = 0; i < timeline.Count; i++)
                {
                    y = (int)stepH.Value;

                    for (int j = 0; j < timeline[i].Count; j++)
                    {
                        int _y = timeline[i][j] ? y - h : y;

                        if (enableText.Checked)
                            e.Graphics.DrawString(timeline[i][j] ? "1" : "0", Font, brush, x + (int)stepW.Value/3, y + h / 2 - dy);

                        e.Graphics.DrawLine(pen, x, _y, x + dx, _y);

                        if (i != 0 && timeline[i][j] != timeline[i - 1][j])
                            e.Graphics.DrawLine(pen, x, y - h, x, y);
                        if (i == 0 && timeline[i][j] != timeline.Last()[j])
                            e.Graphics.DrawLine(pen, x, y - h, x, y);

                        y += dy;
                    }

                    e.Graphics.DrawLine(pen, x, y - h, x + dx / 2, y - h);
                    e.Graphics.DrawLine(pen, x + dx / 2, y, x + dx / 2, y - h);
                    e.Graphics.DrawLine(pen, x + dx / 2, y, x + dx, y);
                    e.Graphics.DrawLine(pen, x + dx, y - h, x + dx, y);

                    x += dx;
                }
            }
        }

        private void Setting_ValueChanged(object sender, EventArgs e)
        {
            viewport.Invalidate(false);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            viewport.BorderStyle = BorderStyle.None;

            Bitmap bmp = new Bitmap(viewport.Width, viewport.Height);
            viewport.DrawToBitmap(bmp, new Rectangle(0, 0, viewport.Width, viewport.Height));
            bmp.Save(saveDialog.FileName);

            viewport.BorderStyle = BorderStyle.Fixed3D;
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            ((Control)sender).BackColor = colorDialog1.Color;
            viewport.Invalidate(false);
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;

            viewport.BackColor = colorDialog1.Color;
            ((Control)sender).BackColor = colorDialog1.Color;
        }
    }
}