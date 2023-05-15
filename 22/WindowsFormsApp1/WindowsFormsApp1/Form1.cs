using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = groupBox1;
            string sexValue = "";
            foreach (var control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    sexValue = radioButton.Text;
                    break;
                }
                else sexValue = "[ПОЛ НЕ ВЫБРАН]";
            }

            GroupBox workExpirience = groupBox3;
            string exp = "";

            foreach (var control in workExpirience.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    exp = radioButton.Text;
                    break;
                }
                else exp = "[ОПЫТ НЕ ВЫБРАН]";
            }

            GroupBox drivingFactor = groupBox4;

            string isCar;

            if (checkBox1.Checked) isCar = "Да"; else isCar = "Нет";

            string isDriver;
            if (checkBox2.Checked) isDriver = "есть";
            else isDriver = "отсутствуют";

            decimal valueFrom = numericUpDown1.Value;
            decimal valueTo = numericUpDown2.Value;

            DateTime birth = dateTimePicker1.Value;
            richTextBox1.Text =
                $"{textBox1.Text} " +
                $"{textBox2.Text} " +
                $"{textBox3.Text}, " +
                $"{sexValue}, " +
                $"у которого день рождения: {birth.ToString("dd.MM.yyyy HH:mm:ss")}, " +
                $"проживающий по адресу {textBox4.Text}, " +
                $"эл. почта: {textBox5.Text}, " +
                $"моб. телефон: МТС, {textBox6.Text}. " +
                $"Опыт работы: {exp}. " +
                $"Водительские: {isDriver}, наличие авто: {isCar}. " +
                $"Желаемая зп от: {valueFrom} до: {valueTo}";
        }
    }
}
