using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_1
{
    public partial class Korzina : Form
    {
        private int currentImageIndex = 0;
        private List<Image> images = new List<Image>();
        private Timer timer;
        public Korzina()
        {
            InitializeComponent();
            images.Add(Properties.Resources.image1);
            images.Add(Properties.Resources.image2);

            // Создаем таймер, который будет переключать изображения
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += timer1_Tick;
            timer.Start();

            // Отображаем первое изображение
            pictureBox3.Image = images[currentImageIndex];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;

            // Если мы дошли до конца списка изображений, начинаем сначала
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0;
            }

            // Отображаем текущее изображение
            pictureBox3.Image = images[currentImageIndex];
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(Tag);
            textBoxResult.Text = result.ToString();

            int result1 = Convert.ToInt32(Tag);
            itog.Text = result1.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Korzina korzina = new Korzina();
            korzina.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            textBoxResult.ReadOnly = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void itog_TextChanged(object sender, EventArgs e)
        {
            textBoxResult.ReadOnly = true;
            int startNumber = 120;
            int userInput = Convert.ToInt32(textBoxResult.Text);
            int result = startNumber * userInput;
            itog.Text = result.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxResult1.ReadOnly = true;
            int startNumber1 = 2306;
            int userInput1 = Convert.ToInt32(textBoxResult1.Text);
            int result1 = startNumber1 * userInput1;
            textBox1.Text = result1.ToString();
        }

        private void textBoxResult1_TextChanged(object sender, EventArgs e)
        {
            textBoxResult.ReadOnly = true;
        }
    }
}
