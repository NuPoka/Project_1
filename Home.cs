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
    public partial class Home : Form
    {
        SqlCommand command;
        SqlConnection cn;
        SqlDataReader dr;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project_1\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty || comboBox2.Text != string.Empty || comboBox3.Text != string.Empty || comboBox4.Text != string.Empty)
            {
                command = new SqlCommand("select * from LoginTable where Dr='" + comboBox1.Text + "' and Dr='" + comboBox2.Text + "' and Dr='" + comboBox3.Text + "' and Dr='" + comboBox4.Text + "'", cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите значение во все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
