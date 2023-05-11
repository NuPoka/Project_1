namespace Project_1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLogin1 = new System.Windows.Forms.Button();
            this.Btnregister1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(75, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 44);
            this.label8.TabIndex = 1;
            this.label8.Text = "Авторизация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 18.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(33, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Логин";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 18.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(33, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Пароль";
            // 
            // BtnLogin1
            // 
            this.BtnLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.BtnLogin1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin1.ForeColor = System.Drawing.Color.White;
            this.BtnLogin1.Location = new System.Drawing.Point(38, 165);
            this.BtnLogin1.Name = "BtnLogin1";
            this.BtnLogin1.Size = new System.Drawing.Size(331, 59);
            this.BtnLogin1.TabIndex = 4;
            this.BtnLogin1.Text = "Войти";
            this.BtnLogin1.UseVisualStyleBackColor = false;
            this.BtnLogin1.Click += new System.EventHandler(this.BtnLogin1_Click);
            // 
            // Btnregister1
            // 
            this.Btnregister1.AutoSize = true;
            this.Btnregister1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btnregister1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.Btnregister1.Location = new System.Drawing.Point(274, 282);
            this.Btnregister1.Name = "Btnregister1";
            this.Btnregister1.Size = new System.Drawing.Size(124, 24);
            this.Btnregister1.TabIndex = 7;
            this.Btnregister1.TabStop = true;
            this.Btnregister1.Text = "Регистрация";
            this.Btnregister1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Btnregister1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, -192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1201, 852);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textusername.Location = new System.Drawing.Point(38, 49);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(331, 32);
            this.textusername.TabIndex = 9;
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpassword.Location = new System.Drawing.Point(38, 113);
            this.textpassword.MaxLength = 100;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(331, 32);
            this.textpassword.TabIndex = 10;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(363, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textusername);
            this.panel2.Controls.Add(this.Btnregister1);
            this.panel2.Controls.Add(this.textpassword);
            this.panel2.Controls.Add(this.BtnLogin1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(363, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 311);
            this.panel2.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(38, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 23);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Запомнить пароль?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.linkLabel2.Location = new System.Drawing.Point(3, 282);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(159, 24);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Забыли пароль?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1177, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel BtnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLogin1;
        private System.Windows.Forms.LinkLabel Btnregister1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}