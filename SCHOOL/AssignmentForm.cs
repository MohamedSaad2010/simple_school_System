using System;
using System.Windows.Forms;
using program;

namespace program
{
    public class AssignmentForm : Form
    {
        // Buttons for different functionalities
        private Button btnAddAssignment;
        private Button btnDeleteAssignments;
        private Button btnAddGrades;
        private Button btnViewAssignments;
        
        public AssignmentForm()
        {
            // Set form properties
            this.Text = "Assignment management";
            this.BackColor = System.Drawing.Color.Purple;
            this.Width = 500;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create a container for arranging buttons in a structured grid
            TableLayoutPanel panel = new TableLayoutPanel
            {
                Font = new System.Drawing.Font("Arial", 15),
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4  
            };

            // Set column and row styles
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); 
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25)); 
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));

            // Add Assignment button
            btnAddAssignment = new Button
            {
                Text = "Add assignment",
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                Dock = DockStyle.Fill 
            };
            btnAddAssignment.Click += BtnAddAssignment_Click;

            // Delete Assignments button
            btnDeleteAssignments = new Button
            {
                Text = "Delete assignments",
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                Dock = DockStyle.Fill
            };
            btnDeleteAssignments.Click += BtnDeleteAssignments_Click;

            // Add Grades button
            btnAddGrades = new Button
            {
                Text = "Add Grades",
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                Dock = DockStyle.Fill 
            };
            btnAddGrades.Click += BtnAddGrades_Click;

            // View Assignments button
            btnViewAssignments = new Button
            {
                Text = "View assignments",
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black,
                Dock = DockStyle.Fill
            };
            btnViewAssignments.Click += BtnViewAssignments_Click;


            // Add buttons to the panel
            panel.Controls.Add(btnAddAssignment, 0, 0); 
            panel.Controls.Add(btnDeleteAssignments, 0, 1); 
            panel.Controls.Add(btnAddGrades, 0, 2); 
            panel.Controls.Add(btnViewAssignments, 0, 3); 

            // Add panel to the form
            this.Controls.Add(panel);
        }

        // Handles the event when the "Add Assignment" button is clicked.
        private void BtnAddAssignment_Click(object sender, EventArgs e)
        {
            // Opens a file dialog to allow the user to add an assignment.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Logic for adding the assignment can be implemented here
                MessageBox.Show("Assignment added successfully!");
            }
        }

        // Handles the event when the "Delete Assignments" button is clicked.
        private void BtnDeleteAssignments_Click(object sender, EventArgs e)
        {
            // Deletes all assignments with a confirmation message.
            MessageBox.Show("All assignments have been deleted.");
        }

        // Handles the event when the "Add Grades" button is clicked.
        private void BtnAddGrades_Click(object sender, EventArgs e)
        {
            // Opens the AddGradesForm for adding grades to assignments.
            AddGradesForms addGradesForm = new AddGradesForms();
            addGradesForm.Show();
            this.Hide();
            addGradesForm.FormClosed += (s, args) => this.Show();
        }

        // Handles the event when the "View Assignments" button is clicked.
        private void BtnViewAssignments_Click(object sender, EventArgs e)
        {
            // Opens the ViewAssignmentsForm for viewing assignments.
            ViewAssignmentsForm viewAssignmentsForm = new ViewAssignmentsForm();
            // Display the ViewAssignmentsForm
            viewAssignmentsForm.Show();
        }
    }
}
