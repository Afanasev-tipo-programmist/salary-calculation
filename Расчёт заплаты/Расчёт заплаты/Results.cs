using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расчёт_заплаты
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            
        }
        int razrBonus;
        int stajBonus;
        int daylength;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gлучение данных из 1 формы

            Form1 frm1 = this.Owner as Form1;

            stajRes.Text = frm1.stajBox.Text;
            oneHrPayRes.Text = frm1.oneHrPay.Text;
            dayLengthRes.Text = frm1.dayLength.Text;
            kolWorkDaysRes.Text = frm1.kolDay.Text;
            NalogRes.Text = frm1.txtNalogi.Text;
            //перенос разряда + Бонус
            if (frm1.razr == "1")
            {
                razrRes.Text = "Первый(нет доплаты)";
                razrBonus = 0;
            }
            else if (frm1.razr == "2")
            {
                razrRes.Text = "Второй (доплата 1000)";
                razrBonus = 1000;
            }
            else if (frm1.razr == "3")
            {
                razrRes.Text = "Третий (доплата 2000)";
                razrBonus = 2000;
            }

            //бонус Стажа
            if (frm1.stajBox.SelectedIndex == 0)
            {
                razrRes.Text = "Менее 5 лет (нет доплаты)";
                stajBonus = 0;
            }
            else if (frm1.stajBox.SelectedIndex == 1)
            {
                razrRes.Text = "От 5 до 10 лет (доплата 2000)";
                stajBonus = 2000;
            }
            else if (frm1.stajBox.SelectedIndex == 2)
            {
                razrRes.Text = "Более 10 лет (доплата 4000)";
                stajBonus = 4000;
            }
            //расчёт рабочего дня
            if(frm1.dayLength.SelectedIndex == 0)
            {
                daylength = 6;
            }
            if( frm1.dayLength.SelectedIndex == 1) 
            { 
                daylength = 8; 
            }

            //открытие кнопок во 2 форме
            calcPayBtn.Enabled = true;
            delBtn.Enabled = true;
            SaveResBtn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itogo = (stajBonus + razrBonus + (Convert.ToInt32(oneHrPayRes.Text) * daylength * Convert.ToInt32(kolWorkDaysRes.Text)));
            itogRes.Text = itogo.ToString() + " ₽";
            double nalogprocent = 0.01;
            double uderZ = (Convert.ToInt32(NalogRes.Text)* nalogprocent)*itogo;
            uderZ = Math.Round(uderZ,2);
            UderZRes.Text = uderZ.ToString() + " ₽";
            double given = itogo - uderZ;
            givenRes.Text = given.ToString() + " ₽";




        }

        private void SaveResBtn_Click(object sender, EventArgs e)
        {
            //Соглашение на сохранение
            DialogResult result1 = MessageBox.Show("Вы уверенны, что хотите сохранить данные?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result1 == DialogResult.Yes)
            {


                //Сохранение 
                Directory.CreateDirectory("C:\\Users\\isip\\Desktop\\sotr");
                //File.Create("C:\\Users\\isip\\Desktop\\pass\\pswrd.txt");
                FileStream fs0 = new FileStream("C:\\Users\\isip\\Desktop\\sotr\\zp1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs0.Close();
                FileStream fs = new FileStream("C:\\Users\\isip\\Desktop\\sotr\\zp1.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(" Стаж работника: " + stajRes.Text + "\n" + " Разряд работника: " + razrRes.Text +"\n"+ " Оплата 1 часа: " + oneHrPayRes.Text + "\n" + " Налоговая ставка: " + NalogRes.Text + "%" + "\n" + " Продолжительность рабочего дня " + dayLengthRes.Text + "\n" + " Кол-во рабочих дней: "+ kolWorkDaysRes.Text + "\n" + " Итого: " + itogRes.Text + "\n" + " Удержанно: " + UderZRes.Text + "\n"+ " Выданно: " + givenRes.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show($"Данные сотрудника сохранены");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Вы уверенны, что хотите УДАЛИТЬ данные?", "ВНИМАНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result2 == DialogResult.Yes)
            {
                File.Delete("C:\\Users\\isip\\Desktop\\sotr\\zp1.txt");
            }
            MessageBox.Show("Удаление успешно");
        }
    }
}
