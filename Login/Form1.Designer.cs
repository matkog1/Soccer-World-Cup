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
        tbUsername = new TextBox();
        tbPassword = new TextBox();
        btnRegister = new Button();
        btnLogin = new Button();
        pnlTop = new Panel();
        panel1 = new Panel();
        panel2 = new Panel();
        panel3 = new Panel();
        pbUser = new PictureBox();
        pbPassword = new PictureBox();
        pnlTop.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
        SuspendLayout();
        // 
        // tbUsername
        // 
        tbUsername.Location = new Point(395, 171);
        tbUsername.Name = "tbUsername";
        tbUsername.Size = new Size(310, 23);
        tbUsername.TabIndex = 2;
        // 
        // tbPassword
        // 
        tbPassword.Location = new Point(395, 223);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(310, 23);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(395, 273);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(152, 43);
        btnRegister.TabIndex = 4;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(553, 273);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(152, 43);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.DarkSlateGray;
        pnlTop.Controls.Add(panel1);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(800, 46);
        pnlTop.TabIndex = 6;
        // 
        // panel1
        // 
        panel1.BackColor = Color.DarkSlateGray;
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 377);
        panel1.TabIndex = 7;
        // 
        // panel2
        // 
        panel2.BackColor = Color.DarkSlateGray;
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 46);
        panel2.Name = "panel2";
        panel2.Size = new Size(194, 451);
        panel2.TabIndex = 7;
        // 
        // panel3
        // 
        panel3.BackColor = Color.DarkSlateGray;
        panel3.Location = new Point(191, 444);
        panel3.Name = "panel3";
        panel3.Size = new Size(609, 53);
        panel3.TabIndex = 8;
        // 
        // pbUser
        // 
        pbUser.Image = Properties.Resources.User;
        pbUser.Location = new Point(327, 161);
        pbUser.Name = "pbUser";
        pbUser.Size = new Size(46, 33);
        pbUser.SizeMode = PictureBoxSizeMode.Zoom;
        pbUser.TabIndex = 9;
        pbUser.TabStop = false;
        // 
        // pbPassword
        // 
        pbPassword.Image = Properties.Resources.padlock1;
        pbPassword.Location = new Point(323, 219);
        pbPassword.Name = "pbPassword";
        pbPassword.Size = new Size(50, 27);
        pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
        pbPassword.TabIndex = 10;
        pbPassword.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGray;
        ClientSize = new Size(800, 497);
        ControlBox = false;
        Controls.Add(pbPassword);
        Controls.Add(pbUser);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(pnlTop);
        Controls.Add(btnLogin);
        Controls.Add(btnRegister);
        Controls.Add(tbPassword);
        Controls.Add(tbUsername);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        pnlTop.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox tbUsername;
    private TextBox tbPassword;
    private Button btnRegister;
    private Button btnLogin;
    private Panel pnlTop;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private PictureBox pbUser;
    private PictureBox pbPassword;
}
