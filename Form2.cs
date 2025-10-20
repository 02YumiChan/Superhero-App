using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string file = "C:/Users/wille/source/repos/Superhero-App/textfile folder/Superheros.txt";
        
        public Form2()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(file))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        // Write headers as first line
                        sw.WriteLine("Hero ID,Name,Age,Superpower,ExamScore,Rank,ThreatLevel");
                    }
                    MessageBox.Show("File created successfully!");
                }
                else
                {
                    MessageBox.Show("File already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating file: " + ex.Message);
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }
    }
}
