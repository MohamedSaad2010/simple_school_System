using System;
using System.Windows.Forms;

public class DeleteStudentForm : Form
{
    //Define fields for data entry
    private TextBox txtNationalID,txtName;
    //Define the delete and cancel buttons
    private Button btnDelete, btnCancel;

    public DeleteStudentForm()
    {
        // Setting the properties
        this.Text = "Delete Student";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 200;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create fields for student name and national ID number
        Label lblName = new Label();
        lblName.Text = "Student Name:";
        lblName.Location = new Point(20, 20);
        lblName.Size = new Size(100, 20);

        txtName = new TextBox();
        txtName.Location = new Point(130, 20);
        txtName.Size = new Size(200, 20);

        Label lblNationalID = new Label();
        lblNationalID.Text = "National ID:";
        lblNationalID.Location = new Point(20, 60);
        lblNationalID.Size = new Size(100, 20);

        txtNationalID = new TextBox();
        txtNationalID.Location = new Point(130, 60);
        txtNationalID.Size = new Size(200, 20);

        // Create buttons
        Button btnDelete = new Button();
        btnDelete.Text = "Delete";
        btnDelete.Size = new Size(100, 30);
        btnDelete.Location = new Point(50, 120); 
        btnDelete.FlatAppearance.BorderSize = 0; 
        btnDelete.BackColor = Color.White;
        btnDelete.Click += BtnDelete_Click;

        Button btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Size = new Size(100, 30);
        btnCancel.Location = new Point(this.ClientSize.Width - 150, 120);
        btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancel.BackColor = Color.White;
        btnCancel.FlatAppearance.BorderSize = 0; 
        btnCancel.Click += BtnCancel_Click;

        // Add items to the form
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblNationalID);
        this.Controls.Add(txtNationalID);
        this.Controls.Add(btnDelete);
        this.Controls.Add(btnCancel);
    }

    // Student deletion event
    private void BtnDelete_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string nationalID = txtNationalID.Text.Trim();

        // Check if data exists in fields
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID))
        {
            MessageBox.Show("Please enter all required data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the student exists in the database (data simulation)
        bool adminExists = CheckStudentExists(name, nationalID);

        // If the student exists in the database
        if (adminExists)
        {
            DeleteStudent(name, nationalID);
            MessageBox.Show("The student was successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
        else
        {
            MessageBox.Show("There is no student with this name and national number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
 
    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.Owner?.Show();
        this.Close(); 
    }

    // Function to check if the student exists in the database
    private bool CheckStudentExists(string name, string nationalID)
    {
        
        return name == "Student Name" && nationalID == "12345678901234";
    }

    // Function to delete student (simulation)
    private void DeleteStudent(string name, string nationalID)
    {
        
    }
}