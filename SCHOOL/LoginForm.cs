using System;
using System.Windows.Forms;
using program;

public class LoginForm : Form
{
    // Define variables for elements in the user interface
    private TextBox txtUsername;
    private TextBox txtPassword;
    private ComboBox cmbRole;
    private Button btnLogin;

    //Dummy data instead of database
    private List<User> users = new List<User>
    {
        // teachers
        // teacher 1
        new User 
        { 
            Username = "t1", Password = "t1", Role = "Teacher", 
            FullName = "Ahmed Mohammed", NationalID = "12345678901234", Position = "Senior Arabic Language Teacher", 
            PhoneNumber = "01012345678", Address = "Al gaz Street, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 2
        new User 
        { 
            Username = "t2", Password = "t2", Role = "Teacher", 
            FullName = "Ahmed Ali", NationalID = "12345678901234", Position = "Senior English Language Teacher", 
            PhoneNumber = "01052345678", Address = "Al basha Street, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 3
        new User 
        { 
            Username = "t3", Password = "t3", Role = "Teacher", 
            FullName = "Yousef Sameh", NationalID = "98765432109876", Position = "Mathematics Teacher", 
            PhoneNumber = "01123456789", Address = "Elm Street, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 4
        new User 
        { 
            Username = "t4", Password = "t4", Role = "Teacher", 
            FullName = "Mohamed Hamdy", NationalID = "12547896543210", Position = "Physics Teacher", 
            PhoneNumber = "01011223344", Address = "Tanta Road, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 5
        new User 
        { 
            Username = "t5", Password = "t5", Role = "Teacher", 
            FullName = "Sarah Ahmed", NationalID = "65432198765432", Position = "Biology Teacher", 
            PhoneNumber = "01234567890", Address = "bahr Street, Tanta", StudentsCount = 360, ClassesCount = 8
        },
        // teacher 6
        new User 
        { 
            Username = "t6", Password = "t6", Role = "Teacher", 
            FullName = "Kareem Hassan", NationalID = "78965412308652", Position = "Computer Science Teacher", 
            PhoneNumber = "01523344556", Address = "Masr El-Gedida, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 7
        new User 
        { 
            Username = "t7", Password = "t7", Role = "Teacher", 
            FullName = "Nashwa Mohamed", NationalID = "32165498765431", Position = "Chemistry Teacher", 
            PhoneNumber = "01098765432", Address = "El-gazera Street, Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 8
        new User 
        { 
            Username = "t8", Password = "t8", Role = "Teacher", 
            FullName = "Fady El Zohery", NationalID = "14578965432100", Position = "History Teacher", 
            PhoneNumber = "01287654321", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 9
        new User 
        { 
            Username = "t9", Password = "t9", Role = "Teacher", 
            FullName = "Yara Badr", NationalID = "98732165498732", Position = "Arabic Language Teacher", 
            PhoneNumber = "01111223344", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 10
        new User 
        { 
            Username = "t10", Password = "t10", Role = "Teacher", 
            FullName = "Ali Mostafa", NationalID = "10020030040050", Position = "Geography Teacher",
            PhoneNumber = "01055667788", Address = "Tanta", StudentsCount = 360, ClassesCount = 8
        },
        // teacher 11
        new User 
        { 
            Username = "t11", Password = "t11", Role = "Teacher", 
            FullName = "Amr Ali", NationalID = "56781234567891", Position = "English Teacher", 
            PhoneNumber = "01567788990", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 12
        new User 
        { 
            Username = "t12", Password = "t12", Role = "Teacher", 
            FullName = "Dina Samy", NationalID = "32145698709873", Position = "Music Teacher", 
            PhoneNumber = "01021223344", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 13
        new User 
        { 
            Username = "t13", Password = "t13", Role = "Teacher", 
            FullName = "Tamer Omar", NationalID = "65412378965432", Position = "Art Teacher", 
            PhoneNumber = "01554433211", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 14
        new User 
        { 
            Username = "t14", Password = "t14", Role = "Teacher", 
            FullName = "Farah Nabil", NationalID = "87654321098765", Position = "Physical Education Teacher", 
            PhoneNumber = "01134567890", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 15
        new User 
        { 
            Username = "t15", Password = "ramynewpass", Role = "Teacher", 
            FullName = "Ramy Salah", NationalID = "12398765432100", Position = "Literature Teacher", 
            PhoneNumber = "01553322100", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 16
        new User 
        { 
            Username = "t16", Password = "t16", Role = "Teacher", 
            FullName = "Hanan Youssef", NationalID = "98765432109876", Position = "French Teacher", 
            PhoneNumber = "01211122334", Address = "Tanta", StudentsCount = 360, ClassesCount = 8
        },
        // teacher 17
        new User 
        { 
            Username = "t17", Password = "t17", Role = "Teacher", 
            FullName = "Sara Ahmed", NationalID = "45678965432109", Position = "Philosophy Teacher", 
            PhoneNumber = "01145678901", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 18
        new User 
        { 
            Username = "t18", Password = "t18", Role = "Teacher", 
            FullName = "Osman Mohamed", NationalID = "33322211144455", Position = "Economics Teacher", 
            PhoneNumber = "01559887766", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 19
        new User 
        { 
            Username = "t19", Password = "t19", Role = "Teacher", 
            FullName = "Nada Khaled", NationalID = "12345678901231", Position = "Social Studies Teacher", 
            PhoneNumber = "01234567788", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 20
        new User 
        { 
            Username = "t20", Password = "t20", Role = "Teacher", 
            FullName = "Sherif Mohamed", NationalID = "65432109876543", Position = "Religious Studies Teacher", 
            PhoneNumber = "01098764532", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // teacher 21
        new User 
        { 
            Username = "t21", Password = "t21", Role = "Teacher", 
            FullName = "Karim Mahmoud", NationalID = "90987654321098", Position = "Physical Education Teacher", 
            PhoneNumber = "01567788900", Address = "Tanta", StudentsCount = 360, ClassesCount = 8 
        },
        // admins
        // admins 1
        new User 
        { 
            Username = "a1", Password = "a1", Role = "Administrator", 
            FullName = "Mohamed Abdullah", NationalID = "98765432109876", Position = "Director of Affairs",
            PhoneNumber = "01198765432", Address = "Tanta", StudentsCount = 0, ClassesCount = 0
        },
        // admins 2
        new User 
        { 
            Username = "a2", Password = "a2", Role = "Administrator", 
            FullName = "Sara Khaled", NationalID = "87654321098765", Position = "Assistant Director",
            PhoneNumber = "01052345678", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 3
        new User 
        { 
            Username = "a3", Password = "a3", Role = "Administrator", 
            FullName = "Ali Hassan", NationalID = "76543210987654", Position = "Head of Operations", 
            PhoneNumber = "01234567890", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 4
        new User 
        { 
            Username = "a4", Password = "a4", Role = "Administrator", 
            FullName = "Dina Youssef", NationalID = "65432109876543", Position = "Senior Administrator",
            PhoneNumber = "01122334455", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 5
        new User 
        { 
            Username = "a5", Password = "a5", Role = "Administrator", 
            FullName = "Ahmed Fathi", NationalID = "54321098765432", Position = "Administrative Manager", 
            PhoneNumber = "01045678901", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 6
        new User 
        { 
            Username = "a6", Password = "a6", Role = "Administrator", 
            FullName = "Mona Sherif", NationalID = "43210987654321", Position = "General Secretary", 
            PhoneNumber = "01567890123", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 7
        new User 
        { 
            Username = "a7", Password = "a7", Role = "Administrator", 
            FullName = "Khaled Ahmed", NationalID = "32109876543210", Position = "IT Director", 
            PhoneNumber = "01123456789", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 8
        new User 
        { 
            Username = "a8", Password = "a8", Role = "Administrator", 
            FullName = "Yara Mostafa", NationalID = "21098765432109", Position = "Finance Manager", 
            PhoneNumber = "01098765432", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 9
        new User 
        { 
            Username = "a9", Password = "a9", Role = "Administrator", 
            FullName = "Fady Nabil", NationalID = "10987654321098", Position = "Head of HR", 
            PhoneNumber = "01223344556", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        },
        // admins 10
        new User 
        { 
            Username = "a10", Password = "a10", Role = "Administrator", 
            FullName = "Tamer Khalil", NationalID = "09876543210987", Position = "Admin Coordinator", 
            PhoneNumber = "01555667788", Address = "Tanta", StudentsCount = 0, ClassesCount = 0 
        }
    };

    public LoginForm()
    {
        
        // UI Format
        this.Text = "Log in";
        this.BackColor = System.Drawing.Color.Purple;
        this.Width = 400;
        this.Height = 300;
        this.StartPosition = FormStartPosition.CenterScreen;

        // Define the components of the model
        txtUsername = new TextBox { PlaceholderText = "Username", Width = 200, Anchor = AnchorStyles.None };
        txtPassword = new TextBox { PlaceholderText = "Password", PasswordChar = '*', Width = 200, Anchor = AnchorStyles.None };
        cmbRole = new ComboBox { Width = 200, Anchor = AnchorStyles.None };
        cmbRole.Items.AddRange(new string[] { "Teacher", "Administrator" });
        btnLogin = new Button { Text = "Log in", BackColor = System.Drawing.Color.White, ForeColor = System.Drawing.Color.Black, Anchor = AnchorStyles.None };

        btnLogin.Click += BtnLogin_Click;

        // Panel settings
        TableLayoutPanel panel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 4,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.None // Remove borders between cells
        };

        // Customize the size of columns and rows
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); 
        for (int i = 0; i < 4; i++) 
        {
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
        }

        // Add items to the Panel
        panel.Controls.Add(txtUsername, 0, 0); // Add Username Field
        panel.Controls.Add(txtPassword, 0, 1); // Add Password Field
        panel.Controls.Add(cmbRole, 0, 2); // Add Role List
        panel.Controls.Add(btnLogin, 0, 3); // Add Login Button

        // Add the Panel to the form
        this.Controls.Add(panel);
    }

    // Event "Login" button
    private void BtnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text; // Get username from field
        string password = txtPassword.Text; // Get password from field
        // Get the role (teacher or administrator)
        string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";

        // Make sure you enter your username and password.
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.");
            return;
        }

        // Check that the role has been selected.
        if (string.IsNullOrEmpty(role))
        {
            MessageBox.Show("Please select a role (teacher or administrator)");
            return;
        }

        // Verify user data
        var user = users.FirstOrDefault(u => u.Username == username && u.Password == password && u.Role == role);

        if (user != null) // true
        {
            RedirectUser(user);
        }
        else // false
        {
            MessageBox.Show("The username or password is incorrect");
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;

        }
    }

    // Function to direct the user to the appropriate screen based on their role
    private void RedirectUser(User user)
    {
        switch (user.Role)
        {
            case "Teacher":
                TeacherDetailsForm teacherForm = new TeacherDetailsForm(user);
                teacherForm.Show();
                this.Hide(); 
                break;
            case "Administrator":
                AdminManagementForm  adminDashboard = new AdminManagementForm ();
                adminDashboard.Show();
                this.Hide(); 
                break;
            default:
                MessageBox.Show("The username or password is incorrect", "Login Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        break;
        }
    }
}