using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;

namespace viusal
{
    public partial class PinControl : UserControl
    {
        private static Random rand = new Random();
        private readonly int sizeW;
        private readonly int sizeH;
        private readonly TriggerType mode;
        private readonly string[] forms = { "dnf", "knf" };
        private readonly Color TextColor_Hover = Color.FromArgb(240, 240, 240);
        private readonly Color TextColor_Default = Color.FromArgb(180, 180, 180);
        private readonly Color BackColor_Hover = Color.FromArgb(48, 48, 49);
        private readonly Color BackColor_Default = Color.FromArgb(28, 28, 28);
        private readonly Color[] Pallete =
        {
            Color.LightPink,
            Color.DarkMagenta,
            Color.Thistle,
            Color.MediumSlateBlue,
            Color.CornflowerBlue,
            Color.DarkTurquoise,
            Color.MediumSpringGreen,
            Color.Lime,
            Color.GreenYellow,
            Color.Yellow,
            Color.Orange,
            Color.LightSalmon,
            Color.Red,
            Color.Silver,
        };

        private List<Color> colorsBuffer;
        private bool isDown = false;
        private bool dnf;
        private int size;
        private List<Label> nodeChangeColor = new List<Label>();
        private Color nodeSetColor;

        public PinControl(int size, int index, Dictionary<List<bool>, List<bool>> table, TriggerType mode)
        {
            InitializeComponent();

            sizeW = (int)Math.Pow(2, Math.Max(0, size - 2));
            sizeH = Math.Min(4, size * 2);

            this.mode = mode;
            this.size = size;
            dnf = mode == TriggerType.D;
            modeTitle.Text = dnf ? "ДНФ" : "КНФ";
            finalOpName.Text = (dnf ? "Штрих шеффера" : "Стрелка Пирса") + ":";

            colorDialog.Color = picColor.BackColor;
            colorsBuffer = new List<Color>(sizeW * sizeH);

            finalOp.Text = "";

            Size btnSize = new Size(mapBtns.Width / 8, mapBtns.Height / 4);

            for (int j = 0; j < sizeH; j++)
            {
                for (int i = 0; i < sizeW; i++)
                {
                    string tag = "";
                    tag += j > 1 ? 'A' : 'a';
                    if (size > 1)
                        tag += (j == 1 || j == 2) ? 'B' : 'b';
                    if (size > 2)
                        tag += i > 3 ? 'C' : 'c';
                    if (size > 3)
                        tag += i % 4 > 1 ? 'D' : 'd';
                    if (size > 4)
                        tag += ((i % 4) == 1 || (i % 4) == 2) ? 'E' : 'e';

                    string tagKnf = Invert(tag);

                    Label node = new Label();
                    node.Size = btnSize;
                    node.Tag = tag;
                    node.TextAlign = ContentAlignment.MiddleCenter;
                    node.FlatStyle = FlatStyle.Flat;
                    node.BackColor = BackColor_Default;
                    node.ForeColor = TextColor_Default;
                    node.MouseEnter += Node_MouseEnter;
                    node.MouseLeave += (s, e) => node.ForeColor = TextColor_Default;
                    node.MouseDown += Node_MouseDown;
                    node.MouseUp += Node_MouseUp;
                    node.MouseMove += Node_MouseMove;
                    node.Location = new Point(i * node.Size.Width, j * node.Size.Height);

                    var bLs = GetBoolArrayFromString(tag);

                    bool flag = false;
                    foreach (var k in table)
                    {
                        if (k.Key.SequenceEqual(bLs))
                        {
                            var key = new ExcitationTable.Key(k.Key[index], k.Value[index]);
                            node.Text = ExcitationTable.Table[mode][key].ToString();
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                        node.Text = "X";

                    mapBtns.Controls.Add(node);
                }
            }

            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.Text == "1" && dnf || btn.Text == "0" && !dnf)
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
            }
        }

        private void Node_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDown)
                return;

            Point downPos = ((Label)sender).Location;
            Point downPos2 = mapBtns.PointToClient(Cursor.Position);
            Point lt = new Point(Math.Min(downPos.X, downPos2.X), Math.Min(downPos.Y, downPos2.Y));
            Point rb = new Point(Math.Max(downPos.X, downPos2.X), Math.Max(downPos.Y, downPos2.Y));

            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.Text == "1" && !dnf || btn.Text == "0" && dnf)
                    continue;

                if (btn.Location.X < lt.X || btn.Location.X > rb.X ||
                    btn.Location.Y < lt.Y || btn.Location.Y > rb.Y)
                {
                    if (nodeChangeColor.Contains(btn))
                    {
                        btn.BackColor = nodeSetColor == BackColor_Default ? colorDialog.Color : BackColor_Default;
                        nodeChangeColor.Remove(btn);
                    }
                }
                else
                {
                    if (btn.BackColor != nodeSetColor)
                    {
                        btn.BackColor = nodeSetColor;
                        nodeChangeColor.Add(btn);
                    }
                }
            }
        }

        private void Node_MouseUp(object sender, MouseEventArgs e)
        {
            Node_MouseMove(sender, e);
            nodeChangeColor.Clear();
            isDown = false;
        }

        private void Node_MouseDown(object sender, EventArgs e)
        {
            Label self = sender as Label;
            nodeSetColor = self.BackColor == BackColor_Default ? colorDialog.Color : BackColor_Default;
            isDown = true;
        }

        private void Node_MouseEnter(object sender, EventArgs e)
        {
            Label self = sender as Label;

            string tag = self.Tag as string;
            self.ForeColor = TextColor_Hover;

            foreach (Control c in map.Controls)
            {
                if (!(c is Label) || !(c.Tag is string))
                    continue;

                if (tag.Contains(c.Tag as string))
                {
                    c.ForeColor = TextColor_Hover;
                    c.BackColor = BackColor_Hover;
                }
                else
                {
                    c.ForeColor = TextColor_Default;
                    c.BackColor = BackColor_Default;
                }
            }
        }

        private void picColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                picColor.BackColor = colorDialog.Color;

            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.BackColor != BackColor_Default)
                    btn.BackColor = colorDialog.Color;
            }
        }

        private void addBlock_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.BackColor != BackColor_Default)
                    list.Add(btn.Tag as string);
            }

            if (list.Count == 0 || list.Count == sizeW * sizeH)
                return;

            string result = string.Join("", list.First().Where(c => list.All(str => str.Contains(c))));

            int csum = 0;
            foreach (Label btn in mapBtns.Controls)
            {
                string tag = btn.Tag as string;
                if (result.All(g => tag.Contains(g)))
                {
                    if (!list.Contains(tag))
                    {
                        MessageBox.Show("Так нельзя делать");
                        return;
                    }
                    csum++;
                }
            }

            if (csum != list.Count)
            {
                MessageBox.Show("Так нельзя делать");
                return;
            }

            AddToMxnf(result);

            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.BackColor != BackColor_Default)
                    btn.BackColor = BackColor_Default;
            }

            int index = rand.Next(0, Pallete.Count() - 1);
            var labels = Mxnf.Controls.Cast<Label>();

            if (labels.Count() < Pallete.Count())
            {
                while (labels.Any(g => g.ForeColor == Pallete[index]))
                    index = rand.Next(0, Pallete.Count() - 1);
            }

            picColor.BackColor = Pallete[index];
            colorDialog.Color = picColor.BackColor;
        }

        private void AddToMxnf(string text, bool update = true)
        {
            Label label = new Label();
            label.ForeColor = picColor.BackColor;
            label.AutoSize = true;
            label.Font = picColor.Font;
            label.Tag = "";
            label.MouseEnter += Label_MouseEnter;
            label.MouseLeave += Label_MouseLeave;

            if (dnf)
                label.Text = text;
            else
                label.Text = "(" + string.Join("+", Invert(text).ToArray()) + ")";

            Label label2 = null;
            if (Mxnf.Controls.Count != 0)
            {
                label2 = new Label();
                label2.ForeColor = TextColor_Default;
                label2.AutoSize = true;
                label2.Tag = null;
                label2.Font = picColor.Font;
                label2.Text = dnf ? "+" : "&&";
            }

            label.MouseClick += (s, ev) =>
            {
                if (ev.Button != MouseButtons.Right)
                    return;

                Mxnf.Controls.Remove(label);
                if (label2 != null)
                    Mxnf.Controls.Remove(label2);

                FinalOpUpdate();
            };

            if (label2 != null)
                Mxnf.Controls.Add(label2);

            Mxnf.Controls.Add(label);

            if (update)
                FinalOpUpdate();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Control self = sender as Control;
            Highlight(self.Text, self.ForeColor);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Unhighlight();
        }

        private void showMxnf_MouseEnter(object sender, EventArgs e)
        {
            var listTag = new List<string>();
            Color color = Color.AliceBlue;

            foreach (Label l in Mxnf.Controls)
            {
                if (l.Tag != null)
                {
                    color = l.ForeColor;
                    listTag.Add(l.Text);
                }
            }

            Highlight(listTag, color);

        }

        public void Highlight(string tag, Color color)
        {
            var list = new List<string>();
            list.Add(tag);

            Highlight(list, color);
        }

        public void Highlight(List<string> tags, Color color)
        {
            colorsBuffer.Clear();
            foreach (Label btn in mapBtns.Controls)
                colorsBuffer.Add(btn.BackColor);

            foreach (string tg in tags)
            {
                string tag = tg.Replace("(", "").Replace(")", "").Replace("+", "");
                if (!dnf)
                    tag = Invert(tag);

                foreach (Label btn in mapBtns.Controls)
                {
                    if (tag.All(g => (btn.Tag as string).Contains(g)))
                        btn.BackColor = color;
                }
            }
        }

        public void Unhighlight()
        {
            for (int i = 0; i < colorsBuffer.Count; i++)
                mapBtns.Controls[i].BackColor = colorsBuffer[i];
        }

        private void mapClear_Click(object sender, EventArgs e)
        {
            foreach (Label btn in mapBtns.Controls)
                btn.BackColor = BackColor_Default;
        }

        static string ToKnf(string tag)
        {
            return string.Join("+", Invert(tag));
        }

        static string Invert(string tag)
        {
            return string.Concat(tag.Select(c => (char)(c > 'Z' ? c - ('z' - 'Z') : c + ('z' - 'Z'))));
        }

        private void FinalOpUpdate()
        {
            finalOp.Text = "";
            int count = 0;

            foreach (Label l in Mxnf.Controls)
            {
                if (l.Tag == null)
                    continue;
                if (dnf)
                    finalOp.Text += string.Format("({0})/", string.Join("/", l.Text.ToArray()));
                else
                {
                    string s = l.Text;
                    if (s.Length == 3)
                        s = Invert(s[1].ToString());
                    else
                        s = s.Replace('+', '|');

                    finalOp.Text += string.Format("{0}|", s);
                    count++;
                }
            }

            if (count == 1)
                finalOp.Text = string.Format("{0}{0}", finalOp.Text);

            if (finalOp.Text.Length != 0)
                finalOp.Text = finalOp.Text.Remove(finalOp.Text.Length - 1);
        }

        public bool CheckMForm()
        {
            var ls = new List<Label>();

            foreach (Label btn in mapBtns.Controls)
            {
                if ((btn.Text == "1" && dnf )|| (btn.Text == "0" && !dnf))
                    ls.Add(btn);
            }

            foreach (Label l in Mxnf.Controls)
            {
                if (l.Tag == null)
                    continue;

                foreach (Label btn in mapBtns.Controls)
                {
                    string text = l.Text.Replace("(", "").Replace(")", "").Replace("+", "");
                    if (!dnf)
                        text = Invert(text);

                    if (text.All(g => (btn.Tag as string).Contains(g)) && ls.Contains(btn))
                        ls.Remove(btn);
                }
            }

            return ls.Count == 0;
        }

        public List<string> GetMForm()
        {
            var result = new List<string>();

            if (finalOp.Text != "")
            {
                foreach (string s in finalOp.Text.Split(')'))
                {
                    if (s != "")
                        result.Add(s.Replace("(", "").Replace("|", "").Replace("/", ""));
                }
            }
            else
            {
                if (dnf)
                    result.Add("Aa");
                else
                {
                    result.Add("AA");
                    result.Add("AA");
                }
            }

            return result;
        }

        public static List<bool> GetBoolArrayFromString(string s)
        {
            List<bool> result = new List<bool>();
            foreach (char c in s)
                result.Add(c == char.ToUpper(c));
            return result;
        }

        public void BuildAuto()
        {
            Mxnf.Controls.Clear();
            mapClear_Click(null, null);

            List<string> task = new List<string>();
            foreach (Label btn in mapBtns.Controls)
            {
                if (btn.Text == "1" && dnf || btn.Text == "0" && !dnf)
                    task.Add(btn.Tag as string);
            }

            string target = dnf ? "0" : "1";

            while (task.Count != 0)
            {
                var variants = VariantGenirator.GerVariant(task[0]);
                var trueVars = new Dictionary<string, int>();

                foreach (string variant in variants)
                {
                    bool valid = true;
                    int weight = 0;
                    foreach (Label btn in mapBtns.Controls)
                    {
                        string tag = btn.Tag as string;
                        if (variant.All(g => tag.Contains(g)))
                        {
                            if (btn.Text == target)
                            {
                                valid = false;
                                break;
                            }
                            weight++;
                        }
                    }
                    if (valid)
                        trueVars.Add(variant, weight);
                }

                int max_i = -1;
                string max = null;
                foreach (var i in trueVars)
                {
                    if (max_i < i.Value)
                    {
                        max_i = i.Value;
                        max = i.Key;
                    }
                }

                foreach (Label btn in mapBtns.Controls)
                {
                    string tag = btn.Tag as string;
                    if (max.All(g => tag.Contains(g)))
                        task.Remove(tag);
                }
                AddToMxnf(max, false);
            }

            FinalOpUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildAuto();
        }
    }
}