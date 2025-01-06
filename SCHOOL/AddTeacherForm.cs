using System;
using System.Windows.Forms;

public class AddTeacherForm : Form
{
    // Fields to capture teacher's information
    private TextBox txtName, txtAge, txtNationalID, txtAddress, txtPosition, txtPhoneNumber, txtCourses, txtStudentsCount, txtClassesCount;
    private Button btnSave, btnCancel;

    public AddTeacherForm()
    {
        // Form setup
        this.Text = "Add teacher";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 500;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create labels and text fields for teacher's details
        Label lblName = new Label { Text = "Teacher's Name:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtName = new TextBox { Dock = DockStyle.Top };

        Label lblAge = new Label { Text = "Age:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAge = new TextBox { Dock = DockStyle.Top };

        Label lblNationalID = new Label { Text = "National ID:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtNationalID = new TextBox { Dock = DockStyle.Top };

        Label lblAddress = new Label { Text = "Address:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAddress = new TextBox { Dock = DockStyle.Top };

        Label lblPosition = new Label { Text = "Job:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtPosition = new TextBox { Dock = DockStyle.Top };

        Label lblPhoneNumber = new Label { Text = "Phone Number:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtPhoneNumber = new TextBox { Dock = DockStyle.Top };

        Label lblCourses = new Label { Text = "Courses:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtCourses = new TextBox { Dock = DockStyle.Top };

        Label lblStudentsCount = new Label { Text = "Number of Students:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtStudentsCount = new TextBox { Dock = DockStyle.Top };

        Label lblClassesCount = new Label { Text = "Number of Classes:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtClassesCount = new TextBox { Dock = DockStyle.Top };

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

        // Event handlers for the buttons
        btnSave.Click += (sender, e) =>
        {
            MessageBox.Show("Teacher data saved successfully!");
            this.Close();
        };

        btnCancel.Click += (sender, e) =>
        {
            this.Close();
        };

        // Add fields to the form
        this.Controls.Add(lblClassesCount);
        this.Controls.Add(txtClassesCount);
        this.Controls.Add(lblStudentsCount);
        this.Controls.Add(txtStudentsCount);
        this.Controls.Add(lblCourses);
        this.Controls.Add(txtCourses);
        this.Controls.Add(lblPhoneNumber);
        this.Controls.Add(txtPhoneNumber);
        this.Controls.Add(lblPosition);
        this.Controls.Add(txtPosition);
        this.Controls.Add(lblAddress);
        this.Controls.Add(txtAddress);
        this.Controls.Add(lblNationalID);
        this.Controls.Add(txtNationalID);
        this.Controls.Add(lblAge);
        this.Controls.Add(txtAge);
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);

        // Add buttons to the form
        Panel buttonPanel = new Panel { Dock = DockStyle.Bottom, Height = 30 };
        buttonPanel.Controls.Add(btnSave);
        buttonPanel.Controls.Add(btnCancel);
        this.Controls.Add(buttonPanel);
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Teacher data has been saved.");
        this.Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}