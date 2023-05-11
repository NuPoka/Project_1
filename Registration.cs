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
using System.Text.RegularExpressions;
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
                //Паттерн для почты
                    if (textmail.TextLength < 5)
                {
                    MessageBox.Show("Почта меньше 5-ти символов", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Regex d = new Regex(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)");
                bool isMailCorrect = true;
                for (int i = 0; i < textmail.Text.Length; i++)
                {
                    if (((textmail.Text[i] >= 'a') && (textmail.Text[i] <= 'z')) || ((textmail.Text[i] >= 'A') && (textmail.Text[i] <= 'Z')) || d.Match(textmail.Text[i].ToString()).Success == true)
                    {

                    }
                    else
                    {
                        isMailCorrect = false;
                    }
                }
                if (!isMailCorrect)
                {
                    MessageBox.Show("Почта должна содержать только латиницу", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Паттерн для логина
                if (txtusername.TextLength < 5)
                {
                    MessageBox.Show("Логин меньше 5-ти символов", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Regex v = new Regex(@"[\d!#h\S*[0-9a-z]*\]");
                bool isLoginCorrect = true;
                for (int i = 0; i < txtusername.Text.Length; i++)
                {
                    if (((txtusername.Text[i] >= 'a') && (txtusername.Text[i] <= 'z')) || ((txtusername.Text[i] >= 'A') && (txtusername.Text[i] <= 'Z')) || v.Match(txtusername.Text[i].ToString()).Success == true)
                    {

                    }
                    else
                    {
                        isLoginCorrect = false;
                    }
                }
                if (!isLoginCorrect)
                {
                    MessageBox.Show("Логин должен содержать только латиницу", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Паттерн для пароля
                if (txtpassword.TextLength < 8 || txtconfirmpassword.TextLength < 8)
                {
                    MessageBox.Show("Пароль меньше 8-ми символов", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Regex r = new Regex(@"[\d!#h]");
                bool isPasswdCorrect = true;
                for (int i = 0; i < txtpassword.Text.Length; i++)
                {
                    if (((txtpassword.Text[i] >= 'a') && (txtpassword.Text[i] <= 'z')) || ((txtpassword.Text[i] >= 'A') && (txtpassword.Text[i] <= 'Z')) || r.Match(txtpassword.Text[i].ToString()).Success == true)
                    {

                    }
                    else
                    {
                        isPasswdCorrect = false;
                    }
                }
                if (!isPasswdCorrect)
                {
                    MessageBox.Show("Пароль должен содержать только латиницу", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                        command = new SqlCommand("insert into LoginTable (Username, Password, Mail) values(@Username,@Password,@Mail)", cn);
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
