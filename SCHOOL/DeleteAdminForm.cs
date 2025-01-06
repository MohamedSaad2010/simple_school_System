using System;
using System.Drawing;
using System.Windows.Forms;

public class DeleteAdminForm : Form
{
    // Define controls for the form
    private TextBox txtNationalID,txtName;
    private Button btnDelete, btnCancel;

    public DeleteAdminForm()
    {
        // Set form properties
        this.Text = "Administrative Delete";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 200;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create the Name label
        Label lblName = new Label();
        lblName.Text = "Administrator Name:";
        lblName.Location = new Point(20, 20);
        lblName.Size = new Size(100, 20);

        // Create the Name input field (TextBox)
        txtName = new TextBox();
        txtName.Location = new Point(130, 20);
        txtName.Size = new Size(200, 20);

        // Create the National ID labe
        Label lblNationalID = new Label();
        lblNationalID.Text = "National ID:";
        lblNationalID.Location = new Point(20, 60);
        lblNationalID.Size = new Size(100, 20);

        // Create the National ID input field (TextBox)
        txtNationalID = new TextBox();
        txtNationalID.Location = new Point(130, 60);
        txtNationalID.Size = new Size(200, 20);

        // Create the Delete button
        Button btnDelete = new Button();
        btnDelete.Text = "Delete";
        btnDelete.Size = new Size(100, 30);
        btnDelete.Location = new Point(50, 120); 
        btnDelete.FlatAppearance.BorderSize = 0; 
        btnDelete.BackColor = Color.White;
        btnDelete.Click += BtnDelete_Click;

        // Create the Cancel button
        Button btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Size = new Size(100, 30);
        btnCancel.Location = new Point(this.ClientSize.Width - 150, 120); 
        btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right; 
        btnCancel.BackColor = Color.White;
        btnCancel.FlatAppearance.BorderSize = 0; 
        btnCancel.Click += BtnCancel_Click;

        // Add controls to the form
        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblNationalID);
        this.Controls.Add(txtNationalID);
        this.Controls.Add(btnDelete);
        this.Controls.Add(btnCancel);
    }

    // Handles the Delete button click event. Validates the input and performs the deletion of the administrator.
    private void BtnDelete_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string nationalID = txtNationalID.Text.Trim();

        // Check if all required fields are filled
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nationalID))
        {
            MessageBox.Show("Please enter all required data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the administrator exists in the database (simulated)
        bool adminExists = CheckAdminExists(name, nationalID);

        // If the administrator exists, delete them
        if (adminExists)
        {
            DeleteAdmin(name, nationalID);
            MessageBox.Show("Administrator successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
        else
        {
            MessageBox.Show("There is no administrator with this name and national ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Handles the Cancel button click event. Closes the form and shows the parent form.
    private void BtnCancel_Click(object sender, EventArgs e)
    {
        this.Owner?.Show();
        this.Close(); 
    }

    // Simulated method to check if an administrator exists based on their name and national ID.
    private bool CheckAdminExists(string name, string nationalID)
    {
        return name == "Admin Name" && nationalID == "12345678901234";
    }

    // Function to delete the administrator (simulation)
    private void DeleteAdmin(string name, string nationalID)
    {
        
    }
}
