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
    public partial class Report : Form
    {
        string heroesFile;
        string summaryFile;
        public Report()
        {
            InitializeComponent();
            LoadHeroes();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadHeroes();
        }
        private void LoadHeroes()
        {
            heroesFile = "C:\\Users\\wille\\source\\repos\\Superhero-App\\textfile folder\\Superheros.txt";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (!File.Exists(heroesFile))
            {
                MessageBox.Show("No superhero file found. Please add heroes first.");
                return;
            }

            var lines = File.ReadAllLines(heroesFile)
                            .Where(line => !string.IsNullOrWhiteSpace(line) && !line.StartsWith("***"))
                            .ToList();

            if (lines.Count == 0)
            {
                MessageBox.Show("No heroes in the file.");
                return;
            }

            // Create columns
            dataGridView1.Columns.Add("HeroID", "Hero ID");
            dataGridView1.Columns.Add("HeroName", "Hero Name");
            dataGridView1.Columns.Add("HeroAge", "Age");
            dataGridView1.Columns.Add("HeroPowers", "Superpower");
            dataGridView1.Columns.Add("ExamScore", "Exam Score");
            dataGridView1.Columns.Add("HeroRank", "Rank");
            dataGridView1.Columns.Add("ThreatLevel", "Threat Level");

            foreach (string line in lines)
            {
                string[] hero = line.Split(',');
                if (hero.Length >= 7)
                    dataGridView1.Rows.Add(hero);
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to summarize.");
                return;
            }

            int totalHeroes = dataGridView1.Rows.Count;
            int totalAge = 0;
            int totalScore = 0;
            int sRank = 0, aRank = 0, bRank = 0, cRank = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int age = Convert.ToInt32(row.Cells["HeroAge"].Value);
                int score = Convert.ToInt32(row.Cells["ExamScore"].Value);
                string rank = row.Cells["HeroRank"].Value.ToString();

                totalAge += age;
                totalScore += score;

                if (rank == "S-Rank") sRank++;
                else if (rank == "A-Rank") aRank++;
                else if (rank == "B-Rank") bRank++;
                else cRank++;
            }

            double avgAge = (double)totalAge / totalHeroes;
            double avgScore = (double)totalScore / totalHeroes;

            string summary = $"Total Heroes: {totalHeroes}\n" +
                             $"Average Age: {avgAge:F1}\n" +
                             $"Average Exam Score: {avgScore:F1}\n" +
                             $"S-Rank: {sRank}, A-Rank: {aRank}, B-Rank: {bRank}, C-Rank: {cRank}";

           

            // Save to summary.txt
            using (StreamWriter sw = new StreamWriter(summaryFile))
            {
                sw.WriteLine("=== Superhero Summary Report ===");
                sw.WriteLine(summary);
                sw.WriteLine("===============================");
                sw.WriteLine($"Generated on: {DateTime.Now}");
            }

            MessageBox.Show("Report generated and saved to summary.txt!");
        
    }
    }
}
