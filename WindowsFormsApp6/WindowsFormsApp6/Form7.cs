using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Недвижимость 2022.mdb"; //Рядок підключення БД без паролю
        private OleDbConnection myConnection;
        public Form7()
        {

            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();

            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet._Об_єкт". При необходимости она может быть перемещена или удалена.
            this.об_єктTableAdapter.Fill(this.бД_Недвижимость_2022DataSet._Об_єкт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet.Співробітники". При необходимости она может быть перемещена или удалена.
            this.співробітникиTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Співробітники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet.Власник". При необходимости она может быть перемещена или удалена.
            this.власникTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Власник);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            int kol = Convert.ToInt32(textBox4.Text);
            int P = Convert.ToInt32(textBox5.Text);
            int E1 = Convert.ToInt32(textBox6.Text);
            int E2 = Convert.ToInt32(textBox7.Text);
            int Price = Convert.ToInt32(textBox11.Text);
            string owner = iD_власникаComboBox.Text;
            string employee = iD_співробітникаComboBox.Text;
            string Description = textBox8.Text;
            string type = textBox9.Text;
            string Object_status = comboBox3.Text;
            string city = textBox2.Text;
            string address = textBox3.Text;

            string query = "INSERT INTO Об'єкт ([ID об'єкта], Город, Адрес, [Кол-во комнат], Площадь, Этаж, Этажность, Описание, [Тип нерухомості], [ID власника], [ID cпівробітник], [Цена $], [Статус об'єкта]) VALUES (" + ID + ", '" + city + "', '" + address + "', " + kol + ", " + P + ", " + E1 + ", " + E2 + ", '" + Description + "', '" + type + "', " + owner + ", " + employee + ", " + Price + ", '" + Object_status + "')";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Об'єкт успішно додано");


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_власникаLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}