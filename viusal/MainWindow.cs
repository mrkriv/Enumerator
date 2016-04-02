using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viusal
{
    public partial class Calculator : Form
    {
        Dictionary<List<bool>, List<bool>> table;
        int mod, step, size = 0;

        public Calculator(int mod, int step)
        {
            InitializeComponent();

            this.mod = mod;
            this.step = step;
            InitializeTable();
        }

        private void InitializeTable()
        {
            handel.Text = string.Format(handel.Text, mod, step);

            table = new Dictionary<List<bool>, List<bool>>(mod);

            for (int i = 1; i < int.MaxValue && i < mod; i = i << 1)
                size++;

            for (int i = 0; i < mod; i++)
            {
                int value = (i + step) % mod;
                var bI = intToByte(i);
                var bV = intToByte(value);
                table.Add(bI, bV);

                trunTableDA.Items.Add(i);
                trunTableDB.Items.Add(value);
                trunTableA.Items.Add(string.Join("", bI.Select(b => b ? 1 : 0)));
                trunTableB.Items.Add(string.Join("", bV.Select(b => b ? 1 : 0)));
            }

            ElementControl element = null;
            for (int i = 0; i < size; i++)
            {
                TabPage page = new TabPage(string.Format("{0}", (char)('A' + i)));
                element = new ElementControl(size, i, table);
                element.Dock = DockStyle.Fill;
                page.BorderStyle = BorderStyle.None;
                page.BackColor = element.BackColor;
                page.ForeColor = element.ForeColor;
                page.Controls.Add(element);
                tabs.TabPages.Add(page);
            }
        }

        List<bool> intToByte(int value)
        {
            var result = new BitArray(BitConverter.GetBytes(value)).Cast<bool>().ToList().GetRange(0, size);
            result.Reverse();

            return result;
        }

        private void trunTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            trunTableA.SelectedIndex = index;
            trunTableB.SelectedIndex = index;
            trunTableDA.SelectedIndex = index;
            trunTableDB.SelectedIndex = index;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Laucher.Instance.Show();
        }

        private void build_all(object sender, EventArgs e)
        {
            var ls = new List<List<string>>();
            foreach (TabPage page in tabs.TabPages)
            {
                TabControl tabs2 = (page.Controls[0] as ElementControl).pages;
                foreach (TabPage page2 in tabs2.TabPages)
                    ((PinControl)page2.Controls[0]).BuildAuto();
            }
        }

        private void makeDiagram_Click(object sender, EventArgs e)
        {
            new Diagramm(table).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maleSkhema(false);
        }

        private void maleSkhema_Click(object sender, EventArgs e)
        {
            maleSkhema(true);
        }

        private void maleSkhema(bool mode)
        {
            var ls = new List<List<string>>();
            bool auto = false;
            foreach (TabPage page in tabs.TabPages)
            {
                TabControl tabs2 = (page.Controls[0] as ElementControl).pages;
                foreach (TabPage page2 in tabs2.TabPages)
                {
                    if ((page2.Text != "D") == mode)
                        continue;

                    PinControl ec = page2.Controls[0] as PinControl;
                    if (!ec.CheckMForm())
                    {
                        if (!auto)
                        {
                            if (MessageBox.Show("Минимальная форма '" + page.Text + "." + page2.Text + "' не полная.\nПостроить все за тебя?", "Форма не полная", MessageBoxButtons.YesNo) != DialogResult.Yes)
                                return;
                            auto = true;
                        }
                        if (auto)
                            ec.BuildAuto();
                    }
                    ls.Add(ec.GetMForm());
                }
            }
            new Shema(ls, mode).Show();
        }
    }
}