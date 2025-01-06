using System;
using System.Linq;
using System.Windows.Forms;

public class AttendanceForm : Form
{
    // DataGridView to display attendance
    private DataGridView dgvAttendance;
    public AttendanceForm()
    {
        // Set form properties
        this.Text = "Absence Management";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 750;
        this.Height = 300;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create a container panel for organizing controls
        TableLayoutPanel panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 1
        };
        
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        // Create the DataGridView for displaying attendance
        dgvAttendance = new DataGridView
        {
            Dock = DockStyle.Fill,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        };
        
        // Create columns for the DataGridView
        for (int i = 0; i < 18; i++)
        {
            dgvAttendance.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = $"C {i + 1}" });
        }
        
        // Create rows for the DataGridView 
        for (int i = 0; i < 30; i++)
        {
            dgvAttendance.Rows.Add(false, false, false, false, false, false);
        }

        // Create a FlowLayoutPanel to hold the buttons at the bottom of the form
        FlowLayoutPanel buttonsPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            FlowDirection = FlowDirection.LeftToRight,
            Padding = new Padding(60),
            AutoSize = true
        };

        // Create and configure the Save button
        Button btnSave = new Button
        {
            Text = "Save",
            BackColor = System.Drawing.Color.White,
            ForeColor = System.Drawing.Color.Black,
            Margin = new Padding(10)
        };
        btnSave.Click += BtnSave_Click;

        // Create and configure the Cancel button
        Button btnCancel = new Button
        {
            Text = "Cancel",
            BackColor = System.Drawing.Color.White,
            ForeColor = System.Drawing.Color.Black,
            Margin = new Padding(10)
        };
        // Event handler for cancelling the operation
        btnCancel.Click += BtnCancel_Click;

        // Add controls to the panel
        panel.Controls.Add(dgvAttendance);
        panel.Controls.Add(btnSave);
        panel.Controls.Add(btnCancel);

        // Add the panel to the form's controls
        this.Controls.Add(panel);
    }

    // Handles the data error event for the DataGridView.
    private void dgvAttendance_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        // Displays an error message if an issue occurs while processing data.
        MessageBox.Show("An error occurred while processing data in the table.");
        e.ThrowException = false;  
    }


    // Handles the click event for the Save button.
    private void BtnSave_Click(object sender, EventArgs e)
    {
        // Get all checked cells (attendance marked as present)
        var checkedCells = dgvAttendance.Rows.Cast<DataGridViewRow>()
            .SelectMany(row => row.Cells.Cast<DataGridViewCell>())
            .Where(cell => cell is DataGridViewCheckBoxCell && Convert.ToBoolean(cell.Value) == true);

        // Count the checked cells (absences)
        int count = checkedCells.Count();
        // Show a message box confirming the number of absences saved
        MessageBox.Show("${count} absences saved");
        // Close the form after saving
        this.Close();
        // If the form has an owner, show it again
        if (this.Owner != null)
        {
            // Reopen the parent form (TeacherDetailsForm)
            this.Owner.Show(); 
        }
        
    }

    // Handles the click event for the Cancel button.
    private void BtnCancel_Click(object sender, EventArgs e)
    {
        // Closes the attendance form without saving any changes.
        this.Close(); 
    }
}