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
    public partial class Form2 : Form
    {
        string FIO1;
        string exp1;
        string ID1;
        public Form2(string FIO, string exp, string ID)
        {
            InitializeComponent();
            FIO1 = FIO;
            ID1 = ID;
            exp1 = exp;
        }
        private void Просмотр_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int costhour = 2269;
            int expcar = 10;
            string car_name = "Exeed TXL Flagship";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int costhour = 264;
            int expcar = 9;
            string car_name = "Skoda Rapid rest.";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int costhour = 295;
            int expcar = 5;
            string car_name = "Renault Arkana Style";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int costhour = 502;
            int expcar = 2;
            string car_name = "Volkswagen Polo sedan AT";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int costhour = 350;
            int expcar = 3;
            string car_name = "Hyundai Solaris II 1.4 rest.";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int costhour = 455;
            int expcar = 6;
            string car_name = "BMW 320 G20";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int costhour = 865;
            int expcar = 5;
            string car_name = "Mercedes CLA 200 Sport";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int costhour = 628;
            int expcar = 3;
            string car_name = "Chery Tiggo 7 Pro Elite";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int costhour = 996;
            int expcar = 4;
            string car_name = "KIA Carnival IV 8 мест";
            Form4 frm4 = new Form4(costhour, expcar, FIO1, exp1, ID1, car_name);
            this.Hide();
            frm4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
