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
        SqlCommand command;
        SqlConnection cn;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project_1\Database.mdf;Integrated Security=True");
            cn.Open();
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


                command = new SqlCommand("select * from LoginTable where Username='" + textusername.Text + "' and Password='" + textpassword.Text + "'", cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    dr.Close();
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
    }
}
