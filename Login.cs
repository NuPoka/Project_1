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
    public partial class Login : Form
    {
        private DbRepository repository;

        public Login(DbRepository repository)
        {
            InitializeComponent();

            this.repository = repository;
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
        private void Btnregister1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BtnLogin1_Click(object sender, EventArgs e)
        {
            if (textpassword.Text != string.Empty || textusername.Text != string.Empty)
            {


                var userExist = repository.GetUser(textusername.Text, textpassword.Text);
                if (userExist)
                {
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значение во все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Remember remember = new Remember();
            remember.ShowDialog();
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            textpassword.UseSystemPasswordChar = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
