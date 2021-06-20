using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            player.Play();
            label12.Text = DateTime.Now.ToShortDateString();


        }




        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter writer = new StreamWriter(path + @"\Kalendar\podatoci.txt", true))
            {
                try
                {
                    comboBox1.Items.Add(comboBox1.SelectedItem);
                    comboBox2.Items.Add(comboBox2.SelectedItem);
                    comboBox3.Items.Add(comboBox3.SelectedItem);
                    writer.Write(comboBox1.SelectedItem);
                    writer.Write(" ");
                    writer.Write(comboBox2.SelectedItem);
                    writer.Write(" ");
                    writer.WriteLine(comboBox3.SelectedItem);
                    writer.Flush();
                    writer.Dispose();
                    writer.Close();
                    MessageBox.Show("Успешно зачувавте податок");



                }
                catch
                {
                    MessageBox.Show("Внесете ги сите потребни информации");

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.StreamReader file = new System.IO.StreamReader(path + @"\Kalendar\podatoci.txt");
            while ((line = file.ReadLine()) != null)
            {     
               using (StreamWriter writer = new StreamWriter(path + @"\Kalendar\zacuvano.txt", true))
               {
                    if (line.Contains(comboBox4.SelectedItem.ToString()))
                    {
                        if (line.Contains(comboBox5.SelectedItem.ToString()))
                        {
                            listBox1.Items.Clear();
                            writer.WriteLine(line);
                            listBox1.Items.Add(line);
                        }
                        
                    }
                counter++;

            }
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}