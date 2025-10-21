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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string filePath;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Hero form will open here.");
            Form2 addHeroForm = new Form2();
            addHeroForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Heroes form will open here");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report generation feature coming soon");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hero to delete.");
                return;
            }

            // Get selected Hero ID
            string heroIdToDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            // Confirm delete
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this hero?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                var lines = File.ReadAllLines(filePath).ToList();

                // Remove the line that starts with the hero’s ID
                lines = lines.Where(line =>
                    !line.StartsWith(heroIdToDelete + ",") &&
                    !line.StartsWith("***") &&
                    !string.IsNullOrWhiteSpace(line)
                ).ToList();

                // Write back to file
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Hero deleted successfully!");
               
            }
        }
    }
    
}
