using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbText.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font(tbText.Font.FontFamily, 5);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font(tbText.Font.FontFamily, 9);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.Font = new Font(tbText.Font.FontFamily, 15);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbText.ForeColor = Color.Black;
            tbText.BackColor = Color.White;
            tbText.Font = new Font(tbText.Font.FontFamily, 9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            greenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            blueToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;

            smallToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            normalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            largeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
        }
    }
}
