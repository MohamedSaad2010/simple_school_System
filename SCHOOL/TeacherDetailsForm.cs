using System;
using System.Windows.Forms;

namespace program
{
public class TeacherDetailsForm : Form
{
    // Button for handling assignments
    private Button btnAssignments;
    public TeacherDetailsForm(User teacher)
    {
        // Set up form properties
        this.Text = "Teacher's data";
        this.Width = 400;
        this.Height = 400;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create the panel for displaying teacher data
        TableLayoutPanel panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 9, 
            BackColor = System.Drawing.Color.Purple 
        };

        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        for (int i = 0; i < 9; i++) 
        {
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f)); 
        }

        // Method to add labels displaying teacher data
        void AddLabel(string text)
        {
            Label label = new Label
            {
                Text = text,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Arial", 10),
                Width = 400,
                ForeColor = System.Drawing.Color.Black, 
                BackColor = System.Drawing.Color.White
            };
            // Add the label to the panel
            panel.Controls.Add(label);
        }

        // Add teacher information to the form as labels
        AddLabel($"Name: {teacher.FullName}");
        AddLabel($"Username: {teacher.Username}");
        AddLabel($"Password: {teacher.Password}");
        AddLabel($"NationalID: {teacher.NationalID}");
        AddLabel($"Position: {teacher.Position}");
        AddLabel($"Phone Number: {teacher.PhoneNumber}");
        AddLabel($"Address: {teacher.Address}");
        AddLabel($"Students Count: {teacher.StudentsCount}");
        AddLabel($"Classes Count: {teacher.ClassesCount}");

        // Create the TableLayoutPanel for the buttons
        TableLayoutPanel buttonsPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Bottom, // وضع الأزرار في الأسفل
            RowCount = 1, // صف واحد
            ColumnCount = 2, // عمودين
            Height = 50 // تعيين ارتفاع ثابت
        };

        // ضبط توزيع الأعمدة ليكون متساوي
        buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 50% من العرض للأزرار
        buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 50% من العرض للأزرار

        // Create and configure the Attendance button (on the right side)
        Button btnAttendance = new Button
        {
            Text = "Attendance",
            BackColor = System.Drawing.Color.White,
            ForeColor = System.Drawing.Color.Black,
            Dock = DockStyle.Fill // ملء المساحة المتاحة داخل العمود
        };
        btnAttendance.Click += BtnAttendance_Click;

        // Create and configure the Assignment button (on the left side)
        btnAssignments = new Button
        {
            Text = "Assignment",
            BackColor = System.Drawing.Color.White,
            ForeColor = System.Drawing.Color.Black,
            Dock = DockStyle.Fill // ملء المساحة المتاحة داخل العمود
        };
        btnAssignments.Click += BtnAssignments_Click;

        // إضافة الأزرار إلى الـ TableLayoutPanel
        buttonsPanel.Controls.Add(btnAssignments, 0, 0); // زر الأسايمنت في العمود الأول
        buttonsPanel.Controls.Add(btnAttendance, 1, 0); // زر الغياب في العمود الثاني

        // إضافة الـ TableLayoutPanel إلى الـ Panel الأساسي
        panel.Controls.Add(buttonsPanel);

        // Add the panel to the form
        this.Controls.Add(panel);
    }

     // Event handler for the Assignment button click
    private void BtnAssignments_Click(object sender, EventArgs e)
    {
        AssignmentForm assignmentForm = new AssignmentForm();
        assignmentForm.Show(); 
        this.Hide(); 
        assignmentForm.FormClosed += (s, args) => this.Show(); 
    }


    // Event handler for the Attendance button click
    private void BtnAttendance_Click(object sender, EventArgs e)
    {
        AttendanceForm attendanceForm = new AttendanceForm();
        attendanceForm.Show();  
        this.Hide(); 
        attendanceForm.FormClosed += (s, args) => this.Show(); 
    }

    // Override method to handle form closing event
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // Call the base class method
        base.OnFormClosing(e);
         // Check if the form was closed by the user
        if (e.CloseReason == CloseReason.UserClosing)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
}