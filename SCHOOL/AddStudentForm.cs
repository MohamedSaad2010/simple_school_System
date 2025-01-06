using System;
using System.Windows.Forms;
public class AddStudentForm : Form
{
    // Text fields to capture student data
    private TextBox txtName, txtAge, txtNationalID, txtAddress, txtFatherName, txtCourses, txtClass;
    // Buttons for saving or cancelling the operation
    private Button btnSave, btnCancel;

    public AddStudentForm()
    {
        // Form setup
        this.Text = "Add Student";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 400;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Labels and input fields for student information
        Label lblName = new Label { Text = "Student Name:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtName = new TextBox { Dock = DockStyle.Top };

        Label lblAge = new Label { Text = "Age:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAge = new TextBox { Dock = DockStyle.Top };

        Label lblNationalId = new Label { Text = "National ID:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtNationalId = new TextBox { Dock = DockStyle.Top };

        Label lblAddress = new Label { Text = "Address:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAddress = new TextBox { Dock = DockStyle.Top };

        Label lblFatherName = new Label { Text = "Father's Name:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtFatherName = new TextBox { Dock = DockStyle.Top };

        Label lblCourses = new Label { Text = "Courses:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtCourses = new TextBox { Dock = DockStyle.Top };

        Label lblClass = new Label { Text = "Grade:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtClass = new TextBox { Dock = DockStyle.Top };

        // Create buttons
        Button btnSave = new Button
        {
            Text = "Save",
            Width = 100,
            Height = 30,
            BackColor = System.Drawing.Color.White,
            Dock = DockStyle.Left
        };

        Button btnCancel = new Button
        {
            Text = "Cancel",
            Width = 100,
            Height = 30,
            BackColor = System.Drawing.Color.White,
            Dock = DockStyle.Right
        };

        // Add events to buttons
        btnSave.Click += (sender, e) =>
        {
            // Validation: Ensure all fields are filled in
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtNationalId.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtFatherName.Text) ||
                string.IsNullOrWhiteSpace(txtCourses.Text) ||
                string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("All fields must be filled in before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Student data saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        };
        
        // Close the form without saving
        btnCancel.Click += (sender, e) => this.Close();

        // Create a Panel to format the buttons
        Panel buttonPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 30
        };

        buttonPanel.Controls.Add(btnSave);
        buttonPanel.Controls.Add(btnCancel);

        // Add fields and buttons to the form
        this.Controls.Add(lblClass);
        this.Controls.Add(txtClass);
        this.Controls.Add(lblCourses);
        this.Controls.Add(txtCourses);
        this.Controls.Add(lblFatherName);
        this.Controls.Add(txtFatherName);
        this.Controls.Add(lblAddress);
        this.Controls.Add(txtAddress);
        this.Controls.Add(lblNationalId);
        this.Controls.Add(txtNationalId);
        this.Controls.Add(lblAge);
        this.Controls.Add(txtAge);
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(buttonPanel);
    }

}