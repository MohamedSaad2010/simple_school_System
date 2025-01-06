using System;
using System.Windows.Forms; // Import classes from Forms folder
using System.Linq;

static class Program
{
    [STAThread] // for Windows Forms (UI)
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginForm()); // Assume that LoginForm is the main form you start with
    }
}

