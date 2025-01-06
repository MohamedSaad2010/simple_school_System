using System;
using System.IO;
using System.Windows.Forms;
using program;

namespace program
{
    public class AddGradesForms : Form
    {
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;

        public AddGradesForms()
        {
            InitializeComponent();
            ShowData();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();

            button1.BackColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 55, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(422, 540);
            button1.Size = new System.Drawing.Size(105, 45);
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(button1_Click);

            
            button2.BackColor = System.Drawing.Color.White;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 55, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(140, 544);
            button2.Size = new System.Drawing.Size(108, 41);
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new EventHandler(button2_Click);

            
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Size = new System.Drawing.Size(653, 519);
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);

            
            Column1.HeaderText = "Student Name";
            Column1.Width = 400;

            Column2.HeaderText = "Class Number";
            Column2.Width = 150;

            Column3.HeaderText = "Grade";

            
            BackColor = System.Drawing.Color.DarkViolet;
            ClientSize = new System.Drawing.Size(653, 606);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Grades Form";
        }

        private void ShowData()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (StreamReader reader = new StreamReader("Students.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] splitLine = line.Split(',');
                        if (splitLine.Length == 3)
                        {
                            string studentName = splitLine[0];
                            string className = splitLine[1];
                            string grade = splitLine[2];
                            dataGridView1.Rows.Add(studentName, className, grade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string studentName = row.Cells[0].Value.ToString();
                string className = row.Cells[1].Value.ToString();
                string grade = row.Cells[2].Value.ToString();
                UpdateFile(studentName, className, grade, e.RowIndex);
            }
        }

        private void UpdateFile(string studentName, string className, string grade, int rowIndex)
        {
            string[] lines = File.ReadAllLines("Students.txt");
            lines[rowIndex] = $"{studentName},{className},{grade}";
            File.WriteAllLines("Students.txt", lines);
        }
    }
}
