using System;
using System.Drawing;
using System.Windows.Forms;

public class AdminManagementForm : Form
{
    public AdminManagementForm()
    {
        // Setting form properties
        this.Text = "Full management";
        this.BackColor = System.Drawing.Color.Purple;
        this.Size = new Size(400, 430); 
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create "Add Admin" button
        Button btnAddAdmin = new Button();
        btnAddAdmin.Text = "Add Administrator";
        btnAddAdmin.Size = new Size(200, 50); 
        btnAddAdmin.Location = new Point((this.ClientSize.Width - btnAddAdmin.Width) / 2, 
                                         (this.ClientSize.Height - btnAddAdmin.Height) / 2 - 150); 
        btnAddAdmin.BackColor = Color.White; 
        btnAddAdmin.FlatStyle = FlatStyle.Flat; 
        btnAddAdmin.Click += BtnAddAdmin_Click;

        // Create "Delete Admin" button
        Button btnDeleteAdmin = new Button();
        btnDeleteAdmin.Text = "Delete Administrator";
        btnDeleteAdmin.Size = new Size(200, 50); 
        btnDeleteAdmin.Location = new Point((this.ClientSize.Width - btnDeleteAdmin.Width) / 2, 
                                            btnAddAdmin.Bottom + 5); 
        btnDeleteAdmin.BackColor = Color.White; 
        btnDeleteAdmin.FlatStyle = FlatStyle.Flat; 
        btnDeleteAdmin.Click += BtnDeleteAdmin_Click;

        // Create "Add Student" button
        Button btnAddStudent = new Button();
        btnAddStudent.Text = "Add Student";
        btnAddStudent.Size = new Size(200, 50);
        btnAddStudent.Location = new Point((this.ClientSize.Width - btnAddStudent.Width) / 2, 
                                           btnDeleteAdmin.Bottom + 5); 
        btnAddStudent.BackColor = Color.White; 
        btnAddStudent.FlatStyle = FlatStyle.Flat; 
        btnAddStudent.Click += BtnAddStudent_Click;

        // Create a "Delete Student" button
        Button btnDeleteStudent = new Button();
        btnDeleteStudent.Text = "Delete Student";
        btnDeleteStudent.Size = new Size(200, 50);
        btnDeleteStudent.Location = new Point((this.ClientSize.Width - btnDeleteStudent.Width) / 2, 
                                              btnAddStudent.Bottom + 5);
        btnDeleteStudent.BackColor = Color.White; 
        btnDeleteStudent.FlatStyle = FlatStyle.Flat; 
        btnDeleteStudent.Click += BtnDeleteStudent_Click;

        // Create a "Add Teacher" button
        Button btnAddTeacher = new Button();
        btnAddTeacher.Text = "Add Teacher";
        btnAddTeacher.Size = new Size(200, 50); 
        btnAddTeacher.Location = new Point((this.ClientSize.Width - btnAddTeacher.Width) / 2, 
                                           btnDeleteStudent.Bottom + 5); 
        btnAddTeacher.BackColor = Color.White; 
        btnAddTeacher.FlatStyle = FlatStyle.Flat; 
        btnAddTeacher.Click += BtnAddTeacher_Click;

        // Create a "Delete Teacher" button
        Button btnDeleteTeacher = new Button();
        btnDeleteTeacher.Text = "Delete Teacher";
        btnDeleteTeacher.Size = new Size(200, 50); 
        btnDeleteTeacher.Location = new Point((this.ClientSize.Width - btnDeleteTeacher.Width) / 2, 
                                              btnAddTeacher.Bottom + 5); 
        btnDeleteTeacher.BackColor = Color.White; 
        btnDeleteTeacher.FlatStyle = FlatStyle.Flat; 
        btnDeleteTeacher.Click += BtnDeleteTeacher_Click;

        // Create a "Back" button
        Button btnBack = new Button();
        btnBack.Text = "Back";
        btnBack.Size = new Size(100, 30); 
        btnBack.Location = new Point((this.ClientSize.Width - btnBack.Width) / 2, 
                             this.ClientSize.Height - btnBack.Height - 10);
        btnBack.BackColor = Color.White; 
        btnBack.FlatStyle = FlatStyle.Flat; 
        btnBack.Click += BtnBack_Click;
        

        // Add buttons to the form
        this.Controls.Add(btnAddAdmin);
        this.Controls.Add(btnDeleteAdmin);
        this.Controls.Add(btnAddStudent);
        this.Controls.Add(btnDeleteStudent);
        this.Controls.Add(btnAddTeacher);
        this.Controls.Add(btnDeleteTeacher);
        this.Controls.Add(btnBack);
    }
    
    // Event handler for the "Add Administrator" button.
    private void BtnAddAdmin_Click(object sender, EventArgs e)
    {
        //  the AddAdminForm.
        AddAdminForm addAdminForm = new AddAdminForm();
        addAdminForm.Show();
        this.Hide();
    }

    // Event handler for the "Delete Administrator" button.
    private void BtnDeleteAdmin_Click(object sender, EventArgs e)
    {
        // Opens the DeleteAdminForm.
        DeleteAdminForm deleteAdminForm = new DeleteAdminForm();
        deleteAdminForm.Show();
        deleteAdminForm.Owner = this; 
        this.Hide(); 
        deleteAdminForm.ShowDialog(); 
        this.Show(); 
    }

    // Event handler for the "Add Student" button.
    private void BtnAddStudent_Click(object sender, EventArgs e)
    {
        // Open the student addition screen
        AddStudentForm addStudentForm = new AddStudentForm
        {
            Owner = this 
        };
        this.Hide(); 
        addStudentForm.ShowDialog(); 
        this.Show();
    }

    // Event handler for the "Delete Student" button.
    private void BtnDeleteStudent_Click(object sender, EventArgs e)
    {
        // Opens the DeleteStudentForm.
        DeleteStudentForm deleteStudentForm = new DeleteStudentForm();
        deleteStudentForm.Owner = this; 
        this.Hide(); 
        deleteStudentForm.ShowDialog(); 
        this.Show(); 
    }

    // Event handler for the "Add Teacher" button.
    private void BtnAddTeacher_Click(object sender, EventArgs e)
    {
        // Opens the AddTeacherForm.
        AddTeacherForm addTeacherForm = new AddTeacherForm
        {
            Owner = this
        };
        this.Hide(); 
        addTeacherForm.ShowDialog(); 
        this.Show(); 
    }

    // Event handler for the "Delete Teacher" button.
    private void BtnDeleteTeacher_Click(object sender, EventArgs e)
    {
        // Opens the DeleteTeacherForm.
        DeleteTeacherForm deleteTeacherForm = new DeleteTeacherForm();
        deleteTeacherForm.Owner = this; 
        this.Hide(); 
        deleteTeacherForm.ShowDialog(); 
        this.Show(); 
    }

    // Event handler for the "Back" button.
    private void BtnBack_Click(object sender, EventArgs e)
    {
        // Navigates back to the LoginForm. 
        LoginForm loginForm = new LoginForm(); 
        loginForm.Show(); 
        this.Close(); 
    }

}