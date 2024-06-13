using _2;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.f1 = f1;

        }
        private desctop f1;

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            DB dB = new DB();
            string qeripass = $" SELECT userpas FROM [userinfo].[dbo].[adminuser]";
            SqlCommand command = new SqlCommand(qeripass, dB.GetConnection());
            dB.openConnection();
            string qeriueser = $" select userlog FROM [userinfo].[dbo].[adminuser] ";
            SqlCommand commandu = new SqlCommand(qeriueser, dB.GetConnection());
            dB.openConnection();
            string login = commandu.ExecuteScalar().ToString();
            string key = command.ExecuteScalar().ToString();
            //   SqlDataReader reader = command.ExecuteReader();

            if (user == login && key == password)
            {
                Form1.ActiveForm.Hide();
                Server MyForm2 = new Server();
                MyForm2.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный пароль или логин");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string insert = "";
            Form1.ActiveForm.Hide();
            desctop MyForm2 = new desctop();
            MyForm2.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
