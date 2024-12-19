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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Расчёт_заплаты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public string razr;
        private void par5name_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //уверен ли пользователь в очистке
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите очистить все поля?","Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                //очистка полей

                //Поле выбора стажа
                stajBox.Text = "";
                //Поле выбора разряда
                razr1.Checked = false;
                razr2.Checked = false;
                razr3.Checked = false;
                //поле почас. оплаты
                oneHrPay.Text = "";
                //очистка рабоч дня
                dayLength.Text = "";
                //очистка кол-ва раб.дней
                kolDay.Text = "";
                //очистка налоговой ставки
                txtNalogi.Text = "";
            }
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void oneHrPay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void oneHrPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение на ввод только цифр
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNalogi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничение на ввод только цифр
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void razr1_CheckedChanged(object sender, EventArgs e)
        {
            razr = "1";
        }

        private void razr2_CheckedChanged(object sender, EventArgs e)
        {
            razr = "2";
        }

        private void razr3_CheckedChanged(object sender, EventArgs e)
        {
            razr = "3";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Results frm2 = new Results();
            frm2.Show(this);
        }
    }
}
