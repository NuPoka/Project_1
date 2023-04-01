using Project_1.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Remember : Form
    {
        SqlCommand command;
        SqlConnection cn;
        SqlDataReader dr;
        private readonly DbRepository repository;

        public Remember(DbRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }
        private void Remember_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project_1\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(repository);
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {


                command = new SqlCommand("select * from LoginTable where Username='" + textBox1.Text + "' and Mail='" + textBox2.Text + "'", cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Login login = new Login(repository);
                    login.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Такой комбинации логина и почты не существует.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значение во все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
