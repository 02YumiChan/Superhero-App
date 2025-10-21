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
        private void Form1_Load(object sender, EventArgs e)
        {
            filePath = "C:/Users/wille/source/repos/Superhero-App/textfile folder/Superheros.txt";
            // Load data from file into DataGridView
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                var dataTable = new DataTable();
                // Assuming the first line contains headers
                var headers = lines[0].Split(',');
                foreach (var header in headers)
                {
                    dataTable.Columns.Add(header);
                }
                // Add remaining lines as rows
                for (int i = 1; i < lines.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lines[i]) && !lines[i].StartsWith("***"))
                    {
                        var rowValues = lines[i].Split(',');
                        dataTable.Rows.Add(rowValues);
                    }
                }
                dataGridView1.DataSource = dataTable;
            }
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
