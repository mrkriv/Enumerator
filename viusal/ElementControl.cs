using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viusal
{
    public partial class ElementControl : UserControl
    {
        public ElementControl(int size, int index, Dictionary<List<bool>, List<bool>> table)
        {
            InitializeComponent();

            var sdnf = new List<string>();
            var sknf = new List<string>();

            foreach (var line in table)
            {
                string buff = "";
                if (line.Value[index])
                {
                    for (int j = 0; j < size; j++)
                        buff += (char)(line.Key[j] ? 'A' + j : 'a' + j);
                    sdnf.Add(buff);
                }
                else
                {
                    for (int j = 0; j < size; j++)
                        buff += (char)(line.Key[j] ? 'a' + j : 'A' + j);
                    sknf.Add(buff);
                }
            }


            Sdnf.Text = string.Join(" + ", sdnf);
            Sknf.Text = "(" + string.Join(")(", sknf.Select(e => string.Join("+", e.ToArray()))) + ")";

            foreach (TriggerType k in Enum.GetValues(typeof(TriggerType)))
            {
                TabPage page = new TabPage(k.ToString());
                PinControl element = new PinControl(size, index, table, k);
                page.BorderStyle = BorderStyle.None;
                element.Dock = DockStyle.Fill;
                page.BackColor = element.BackColor;
                page.ForeColor = ForeColor;
                page.Controls.Add(element);
                pages.TabPages.Add(page);
            }
        }
    }
}
