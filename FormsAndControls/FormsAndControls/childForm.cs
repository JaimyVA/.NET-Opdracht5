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
    public partial class childForm : Form
    {
        Form2 Form2 = new Form2();
        public childForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.Show();
        }

        private void childForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.SetValueForGetal;
        }
    }
}
