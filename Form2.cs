using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
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
                // Validating the required fields //
                if (string.IsNullOrWhiteSpace(btnSaveHero.Text))
                    string.IsNullOrWhiteSpace(txtName.Text);
                string.IsNullOrWhiteSpace(txtAge.Text);
                string.IsNullOrWhiteSpace(txtSuperpower.Text);
                    string.IsNullOrWhiteSpace(txtExamScore.Text);
                zq












































            }
            catch 
            { 
                
            }
        }
    }
}
