using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Личный кабинет", pictureBox2);

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Корзина", pictureBox4);
            Korzina korzina = new Korzina();
            korzina.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.korzinka;
            int value = Convert.ToInt32(textBoxValue.Text);
            MessageBox.Show("Значение: " + value.ToString());
            Korzina korzina = new Korzina();
            korzina.Tag = value;
            korzina.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "2427";
            label9.Font = new Font(label9.Font, FontStyle.Strikeout);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.BackColor = Color.White; // устанавливаем белый цвет фона Label

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            MessageBox.Show("Значение: " + value1.ToString());
            Korzina korzina = new Korzina();
            korzina.Tag = value1;
            korzina.Show();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
