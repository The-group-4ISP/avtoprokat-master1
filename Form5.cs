using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace register
{
    public partial class Form5 : Form
    {
        string filepath = "D:\\Documents\\rEPORTS\\report1.txt";
        int experience1;
        string finaltext;
        string FIO, id_license, car_name, series_number, experience, hours, cost, card_number, card_date, cvc, status_of_order;

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int expcar2;
        string exp3;
        int exp4;
        public Form5(string cena1, int expcar, string FIO2, string exp2, string ID2, string ser_nom, string time_using, string nom_card, string data_card, string cvc_card, string car)
        {
            expcar2 = expcar;
            experience1 = Convert.ToInt32(exp2);
            FIO = FIO2;
            experience = exp2; //стаж водителя
            
            cost = cena1;
            id_license = ID2;
            car_name = car;
            series_number = ser_nom;
            hours = time_using;
            card_number = nom_card;
            card_date = data_card;
            cvc = cvc_card;

            InitializeComponent();

            exp4 = Convert.ToInt32(exp3);

            if (experience1 < expcar)
            {
                MessageBox.Show("Аренда данного автомобиля для вас недоступна", "Заявка не активна");
                status_of_order = "Отклонено";
                pictureBox2.Visible = true;
                TextOutPut();

            }
            if (experience1 > expcar)
            {
                MessageBox.Show("Автомобиль арендован", "Заявка активна");
                status_of_order = "Принято";
                pictureBox1.Visible = true;
                TextOutPut();
            }
        }
        public void TextOutPut()
        {
            finaltext = "Заказчик: " + FIO + "\n" + "Номер и серия паспорта: " + series_number + "\n" + "Водительский стаж: " + experience + "\n" + "Номер водительского удостоверения: " + id_license + "\n" + "Автомобиль: " + car_name + "\n" + "Арендное время: " + hours + " ч." + "\n" + "Стоиомость арендной платы: " + cost + " руб." + "\n" + "Номер карты: " + card_number + "\n" + "Срок годности карты: " + card_date + "\n" + "СVC:" + cvc + "\n" + "Статус заказа: " + status_of_order + "\n\n";

            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine(finaltext);
            }
        }
    }
}
