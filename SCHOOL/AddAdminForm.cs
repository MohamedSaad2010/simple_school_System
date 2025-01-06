using System;
using System.Windows.Forms;

public class AddAdminForm : Form
{
    private TextBox txtName, txtAge, txtNationalID, txtAddress, txtPosition, txtPhoneNumber;
    private Button btnSave, btnCancel;

    // Constructor to initialize the form
    public AddAdminForm()
    {
        // Initialize form properties
        this.Text = "Add Administrator";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 300;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Initialize labels and text boxes for data input
        Label lblName = new Label { Text = "Administrator's Name:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtName = new TextBox { Dock = DockStyle.Top };

        Label lblAge = new Label { Text = "Age:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAge = new TextBox { Dock = DockStyle.Top };

        Label lblNationalId = new Label { Text = "National ID:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtNationalId = new TextBox { Dock = DockStyle.Top };

        Label lblAddress = new Label { Text = "Address:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtAddress = new TextBox { Dock = DockStyle.Top };

        Label lblJobTitle = new Label { Text = "Job:", ForeColor = System.Drawing.Color.White, Dock = DockStyle.Top };
        TextBox txtJobTitle = new TextBox { Dock = DockStyle.Top };

        // Initialize buttons
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

        // Add event handlers for buttons
        btnSave.Click += (sender, e) =>
        {
            // Check that all fields are filled in
            if (string.IsNullOrWhiteSpace(txtName.Text) || 
                string.IsNullOrWhiteSpace(txtAge.Text) || 
                string.IsNullOrWhiteSpace(txtNationalId.Text) || 
                string.IsNullOrWhiteSpace(txtAddress.Text) || 
                string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("All fields must be filled in before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Save Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                AdminManagementForm adminManagementForm = new AdminManagementForm();
                adminManagementForm.Show();
            }
        };

        btnCancel.Click += (sender, e) =>
        {
            this.Hide();
            AdminManagementForm adminManagementForm = new AdminManagementForm();
            adminManagementForm.Show();
        };

        // Create a panel for buttons layout
        Panel buttonPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 30
        };

        buttonPanel.Controls.Add(btnSave);
        buttonPanel.Controls.Add(btnCancel);

        // Add labels, text boxes, and buttons to the form
        this.Controls.Add(lblJobTitle);
        this.Controls.Add(txtJobTitle);
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