﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textPassword.UseSystemPasswordChar = true;
            this.AcceptButton = buttonLogin;
    
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textPassword.Text == "testlozinka")
            {

                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();




            }
            else
            {
                MessageBox.Show("Внесовте погрешна лозинка. \nОбидете се повторно.");

            }
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
