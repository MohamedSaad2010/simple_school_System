using System;
using System.Windows.Forms;
using program;

namespace program
{
public class ViewAssignmentsForm : Form
{
    private ListView listViewAssignments;
    
    public ViewAssignmentsForm()
    {
        // Set the form properties
        this.Text = "View assignments";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 600;
        this.Height = 400;

        // Initialize the ListView control
        listViewAssignments = new ListView
        {
            BackColor = System.Drawing.Color.Purple,
            View = View.Details,
            FullRowSelect = true,
            Dock = DockStyle.Fill
        };

        // Adding columns to the ListView
        listViewAssignments.Columns.Add("Assignment Name", 200);
        listViewAssignments.Columns.Add("Date Added", 150);

        // Adding sample data to the ListView
        listViewAssignments.Items.Add(new ListViewItem(new[] { "Assignment 1", "01/01/2024" }));
        listViewAssignments.Items.Add(new ListViewItem(new[] { "Assignment 2", "02/01/2024" }));
        listViewAssignments.Items.Add(new ListViewItem(new[] { "Assignment 3", "03/01/2024" }));

        // Add ListView to the form
        this.Controls.Add(listViewAssignments);
    }
}
}