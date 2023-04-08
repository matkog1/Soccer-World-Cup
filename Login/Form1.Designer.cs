namespace Login;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        tbUsername = new TextBox();
        tbPassword = new TextBox();
        btnRegister = new Button();
        btnLogin = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(220, 131);
        label1.Name = "label1";
        label1.Size = new Size(60, 15);
        label1.TabIndex = 0;
        label1.Text = "Username";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(220, 197);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 1;
        label2.Text = "Password";
        // 
        // tbUsername
        // 
        tbUsername.Location = new Point(296, 131);
        tbUsername.Name = "tbUsername";
        tbUsername.Size = new Size(253, 23);
        tbUsername.TabIndex = 2;
        // 
        // tbPassword
        // 
        tbPassword.Location = new Point(296, 189);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(253, 23);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(226, 240);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(152, 43);
        btnRegister.TabIndex = 4;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(397, 240);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(152, 43);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnLogin);
        Controls.Add(btnRegister);
        Controls.Add(tbPassword);
        Controls.Add(tbUsername);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox tbUsername;
    private TextBox tbPassword;
    private Button btnRegister;
    private Button btnLogin;
}
