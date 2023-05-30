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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД Недвижимость 2022.mdb"; //Рядок підключення БД без паролю
        private OleDbConnection myConnection;

        public Form2()
        {
            myConnection = new OleDbConnection(connectString);
            // відкрити з’єднання з БД
            myConnection.Open();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Власник  WHERE [ID власника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про власник видалені");
            this.власникTableAdapter.Fill(this.бД_Недвижимость_2022DataSet.Власник);
        }
    }
}
