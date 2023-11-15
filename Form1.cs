using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        public static string FIO;
        public static string exp;
        public static string ID;
        private void button1_Click(object sender, EventArgs e)
        {
            FIO = textBox1.Text;
            exp = textBox2.Text;
            ID = textBox3.Text;

            Form2 frrm = new Form2(FIO, exp, ID);
            this.Hide();
              frrm.Show();
        }
    }
}
