using Project_1.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Registration : Form
    {
        SqlCommand command;
        SqlConnection cn;
        SqlDataReader dr;
        private readonly DbRepository repository;

        public Registration(DbRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }


        private void Registaration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project_1\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void BtnRegister_Click_1(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty || textmail.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    command = new SqlCommand("select * from LoginTable where Username='" + txtusername.Text + textmail.Text + "'", cn);
                    command.Connection = cn;
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Имя пользователя или почта уже существуют, пожалуйста, попробуйте другой.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        command = new SqlCommand("insert into LoginTable values(@Username,@Password,@Mail)", cn);
                        command.Parameters.AddWithValue("Username", txtusername.Text);
                        command.Parameters.AddWithValue("Password", txtpassword.Text);
                        command.Parameters.AddWithValue("Mail", textmail.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Поздравляю, вы успешно зарегестрировались в аптеке 'Будь здоров'.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите оба пароля одинаково.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значение во все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(repository);
            login.ShowDialog();
        }
    }
}
