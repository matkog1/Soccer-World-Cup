using Microsoft.VisualBasic.ApplicationServices;
using SoccerDAL.Models;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;
using User = SoccerDAL.Models.User;

namespace Login;

public partial class LoginForm : Form
{
    private readonly UserManager userManager;

    public LoginForm()
    {
        InitializeComponent();
        IUserRepositoryFactory userRepositoryFactory = new UserFactory();
        IUserFactory userFactory = new UserFactory();
        userManager = new UserManager(userRepositoryFactory, userFactory);
        this.AcceptButton = btnLogin;
        this.KeyPreview = true;

    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = tbUsername.Text;
        string password = tbPassword.Text;

        bool validated = UserValidation(username, password);
        if (validated)
        {
            RegisterUser(username, password);
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = tbUsername.Text;
        string password = tbPassword.Text;

        UserValidation(username, password);
        UserLogin(username, password);
    }

    private void UserLogin(string username, string password)
    {
        User user = userManager.LoginUser(username, password);

        if (user != null)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        else
        {
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void RegisterUser(string username, string password)
    {
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
    private bool UserValidation(string username, string password)
    {
        if (password.Trim().Length < 6)
        {
            MessageBox.Show("Password must be longer then 6 charachters!");
            return false;
        }

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }


    private void pbExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void LoginForm_KeyDown(object sender, KeyEventArgs e)
    {

        if (e.KeyCode == Keys.Escape)
        {
            Application.Exit();
        }
    }
}
