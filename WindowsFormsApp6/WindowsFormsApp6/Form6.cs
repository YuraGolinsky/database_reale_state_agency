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
    

    public partial class Form6 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Недвижимость 2022.mdb"; //Рядок підключення БД без паролю
        private OleDbConnection myConnection;
 

        public Form6()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();
       
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet.Співробітники". При необходимости она может быть перемещена или удалена.
            this.співробітникиTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Співробітники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet.Власник". При необходимости она может быть перемещена или удалена.
            this.власникTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Власник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet._Об_єкт". При необходимости она может быть перемещена или удалена.
            this.об_єктTableAdapter.Fill(this.бД_Недвижимость_2022DataSet._Об_єкт);

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


            string query = "SELECT [Об'єкт].[ID  об'єкта], [Об'єкт].Город, [Об'єкт].Адрес, [Об'єкт].[Кол-во комнат], [Об'єкт].Площадь, [Об'єкт].Этаж, [Об'єкт].Этажность, [Об'єкт].Описание, [Об'єкт].[Тип нерухомості], [Об'єкт].[ID співробітника], Власник.ПІБ, [Об'єкт].[Цена $], [Об'єкт].[Статус об'єкта] FROM Власник INNER JOIN[Об'єкт] ON Власник.[ID власника] = [Об'єкт].[ID власника]    WHERE((([Об'єкт].[ID  об'єкта]) = 152243));  ";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
         this.dataGridView1.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
              int index = this.dataGridView1.Columns.Add(item.ColumnName, item.Caption);
               this.dataGridView1.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.dataGridView1.DataSource = source;

        }


        private void iD_власникаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT [Об'єкт].[ID  об'єкта], [Об'єкт].[Город], [Об'єкт].[Адрес], [Об'єкт].[Кол-во комнат], [Об'єкт].[Площадь], [Об'єкт].[Этаж], [Об'єкт].[Этажность], [Об'єкт].[Описание], [Об'єкт].[Тип нерухомості], [Об'єкт].[ID власника], [Об'єкт].[ID співробітника], [Об'єкт].[Цена $], [Об'єкт].[Статус об'єкта] FROM[Об'єкт] WHERE((([Об'єкт].[ID співробітника])=164245)); ";

            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.dataGridView1.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.dataGridView1.Columns.Add(item.ColumnName, item.Caption);
                this.dataGridView1.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.dataGridView1.DataSource = source;
        }

        private void iD_співробітникаComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString =
"provider=Microsoft.Jet.OLEDB.4.0;data source=" + System.IO.Path.Combine(Application.StartupPath, "БД Недвижимость 2022.mdb");
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "SELECT DISTINCTROW Avg([Об'єкт].[Цена $]) AS[Avg - Цена $] FROM [Об'єкт]";

            con.Open();

            textBox1.Text = Convert.ToString(com.ExecuteScalar());

            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {



            string query = " SELECT* FROM[Об'єкт]WHERE [Цена $]  = (SELECT Max([Цена $]) FROM [Об'єкт])";
            OleDbDataAdapter dA = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dA.Fill(ds, "[C]");
            DataView source = ds.Tables[0].DefaultView; //Данні з запиту
            this.dataGridView1.Columns.Clear(); //Прибираємо стовпці, мабуть варто їх зберігти, щоб потім відновити
            foreach (DataColumn item in source.Table.Columns)
            {
                int index = this.dataGridView1.Columns.Add(item.ColumnName, item.Caption);
                this.dataGridView1.Columns[index].DataPropertyName = item.ColumnName; //Без цього дані не будуть відображені
            }
            this.dataGridView1.DataSource = source;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox3.Text);
            string query = "DELETE FROM [Об'єкт] WHERE [ID  об'єкта] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про об'єкт видалені");
            this.об_єктTableAdapter.Fill(this.бД_Недвижимость_2022DataSet._Об_єкт);

        }
    }
}
