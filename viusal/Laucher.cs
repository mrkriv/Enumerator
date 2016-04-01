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
    public partial class Laucher : Form
    {
        private static List<Calculator> cInstances = new List<Calculator>();
        public static Laucher Instance { get; private set; }
        private bool animState = false;

        public Laucher()
        {
            InitializeComponent();
            FormClosing += Laucher_FormClosing;
            Instance = this;
        }

        private void Laucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cInstances.Count != 0)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void run(object sender, EventArgs e)
        {
            Hide();
            Calculator c = new Calculator((int)mod.Value, (int)step.Value);
            cInstances.Add(c);
            c.FormClosed += Calculator_FormClosed;
            c.Show();
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            cInstances.Remove(sender as Calculator);
            if (cInstances.Count == 0)
                Show();
        }
        
        private void anim_Tick(object sender, EventArgs e)
        {
            int d = 0;
            if (animState == true && author.Location.Y != 0)
                d = -1;
            else if (animState == false && author.Location.Y != 14)
                d = 1;

            if (d == 0)
                anim.Stop();

            author.Location = new Point(author.Location.X, author.Location.Y + d);

            byte g = (byte)(author.ForeColor.R - d * 13);
            author.ForeColor = Color.FromArgb(g, g,g);
        }

        private void author_MouseEnter(object sender, EventArgs e)
        {
            animState = true;
            anim.Start();
        }

        private void author_MouseLeave(object sender, EventArgs e)
        {
            animState = false;
            anim.Start();
        }
    }
}