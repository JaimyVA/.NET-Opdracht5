using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAndControls
{
    public partial class Form1 : Form
    {
        childForm childForm = new childForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            childForm.Show();
        }
    }
}
