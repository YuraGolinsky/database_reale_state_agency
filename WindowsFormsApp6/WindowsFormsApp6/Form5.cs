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
    public partial class Form5 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Недвижимость 2022.mdb"; //Рядок підключення БД без паролю
        private OleDbConnection myConnection;

        public Form5()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_Недвижимость_2022DataSet.Угода". При необходимости она может быть перемещена или удалена.
            this.угодаTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Угода);

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
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "Select*FROM Угода WHERE [ID угода] =" + kod;
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM Угода  WHERE [ID угода] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про угодy видалені");
            this.угодаTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Угода);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string query = "SELECT DISTINCTROW Угода.[ID угода], Угода.[ID об'єкта], Угода.[ID співробітника], Угода.[ID клієнта], Угода.[Тип нерухомість], Угода.[Тип угоди], Avg(Угода.[Ціна об'єкту без комісії $]) AS [Avg - Ціна об'єкту без комісії $], Avg(Угода.[Ціна комісії агентства $]) AS [Avg - Ціна комісії агентства $], Avg(Угода.[Ціна угоди общ $]) AS [Avg - Ціна угоди общ $]FROM Угода GROUP BY Угода.[ID угода], Угода.[ID об'єкта], Угода.[ID співробітника], Угода.[ID клієнта], Угода.[Тип нерухомість], Угода.[Тип угоди];";

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

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT Угода.[ID угода], Угода.[ID об'єкта], Угода.[ID співробітника], Угода.[ID клієнта], Клієнт.ПІБ, Клієнт.Телефон, Угода.[Тип нерухомість], Угода.[Тип угоди], Угода.[Ціна об'єкту без комісії $], Угода.[Ціна комісії агентства $], Угода.[Ціна угоди общ $] FROM Клієнт INNER JOIN Угода ON Клієнт.[ID клієнта] = Угода.[ID клієнта] WHERE(((Угода.[ID клієнта]) = 301));";

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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
         //   int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Угода  WHERE [ID співробітника] = 158958";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
       //     MessageBox.Show("Дані про термінал видалені");
            this.угодаTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Угода);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Угода SET [Ціна комісії агентства $] = [Ціна комісії агентства $]*1.-10 WHERE [ID клієнта] = 301 ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.угодаTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Угода);

        }
    }
}
