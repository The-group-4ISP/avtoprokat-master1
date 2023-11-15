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
    public partial class Form4 : Form
    {
        int expcar1;
        string FIO2;
        string exp2;
        string ID2;
        int costhour1;
        string ser_nom;
        string time_using;
        string nom_card;
        string data_card;
        string cvc_card;
        string cena1;
        string car1;

        public Form4(int costhour, int expcar, string FIO1, string exp1, string ID1, string car)
        {
            InitializeComponent();
            FIO2 = FIO1;
            exp2 = exp1;
            ID2 = ID1;
            expcar1 = expcar;
            costhour1 = costhour;
            car1 = car;
            if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ser_nom = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            time_using = textBox2.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int time_using1 = Convert.ToInt32(time_using);
            int cena = costhour1 * time_using1;
            cena1 = Convert.ToString(cena);
            label6.Text = cena1 + "руб";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nom_card = textBox3.Text;
            data_card = textBox5.Text;
            cvc_card = textBox4.Text;
            Form5 frm5 = new Form5(cena1, expcar1, FIO2, exp2, ID2, ser_nom, time_using, nom_card, data_card, cvc_card, car1);
            frm5.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string nom_card = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string data_card = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string cvc_card = textBox4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
