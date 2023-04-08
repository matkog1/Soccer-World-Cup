using Microsoft.VisualBasic.ApplicationServices;
using SoccerDAL.Models;
using User = SoccerDAL.Models.User;

namespace Login;

public partial class Form1 : Form
{
     private readonly UserManager userManager;

    public Form1()
    {
        InitializeComponent();

        IUserRepositoryFactory userRepositoryFactory = new UserFactory();
        IUserFactory userFactory = new UserFactory();
        userManager = new UserManager(userRepositoryFactory, userFactory);
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = tbUsername.Text;
        string password = tbPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        User newUser = userManager.RegisterUser(username, password);

        if (newUser != null)
        {
            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("User registration failed. The username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = tbUsername.Text;
        string password = tbPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        User user = userManager.LoginUser(username, password);

        if (user != null)
        {
            MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Perform any additional actions after successful login, such as opening a new form.
        }
        else
        {
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
