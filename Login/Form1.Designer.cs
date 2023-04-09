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
        pbExit = new PictureBox();
        panel2 = new Panel();
        pbWorldCup = new PictureBox();
        pbUser = new PictureBox();
        pbPassword = new PictureBox();
        comboBox1 = new ComboBox();
        comboBox2 = new ComboBox();
        pnlTop.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbWorldCup).BeginInit();
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
        tbPassword.Location = new Point(395, 231);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(310, 23);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(395, 299);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(152, 43);
        btnRegister.TabIndex = 4;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(553, 299);
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
        panel1.Controls.Add(pbExit);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 377);
        panel1.TabIndex = 7;
        // 
        // pbExit
        // 
        pbExit.Image = Properties.Resources._switch;
        pbExit.Location = new Point(743, 12);
        pbExit.Name = "pbExit";
        pbExit.Size = new Size(45, 28);
        pbExit.SizeMode = PictureBoxSizeMode.Zoom;
        pbExit.TabIndex = 0;
        pbExit.TabStop = false;
        pbExit.Click += pbExit_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.DarkSlateGray;
        panel2.Controls.Add(pbWorldCup);
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 46);
        panel2.Name = "panel2";
        panel2.Size = new Size(194, 451);
        panel2.TabIndex = 7;
        // 
        // pbWorldCup
        // 
        pbWorldCup.Image = Properties.Resources.world_cup;
        pbWorldCup.Location = new Point(3, 90);
        pbWorldCup.Name = "pbWorldCup";
        pbWorldCup.Size = new Size(188, 206);
        pbWorldCup.SizeMode = PictureBoxSizeMode.Zoom;
        pbWorldCup.TabIndex = 0;
        pbWorldCup.TabStop = false;
        // 
        // pbUser
        // 
        pbUser.Image = Properties.Resources.User;
        pbUser.Location = new Point(327, 161);
        pbUser.Name = "pbUser";
        pbUser.Size = new Size(50, 35);
        pbUser.SizeMode = PictureBoxSizeMode.Zoom;
        pbUser.TabIndex = 9;
        pbUser.TabStop = false;
        // 
        // pbPassword
        // 
        pbPassword.Image = Properties.Resources.padlock1;
        pbPassword.Location = new Point(327, 219);
        pbPassword.Name = "pbPassword";
        pbPassword.Size = new Size(50, 35);
        pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
        pbPassword.TabIndex = 10;
        pbPassword.TabStop = false;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "English", "Croatian" });
        comboBox1.Location = new Point(395, 270);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 11;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Items.AddRange(new object[] { "Men", "Women" });
        comboBox2.Location = new Point(553, 270);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(121, 23);
        comboBox2.TabIndex = 12;
        comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGray;
        ClientSize = new Size(800, 497);
        ControlBox = false;
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Controls.Add(pbPassword);
        Controls.Add(pbUser);
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
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbWorldCup).EndInit();
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
    private PictureBox pbUser;
    private PictureBox pbPassword;
    private PictureBox pbExit;
    private PictureBox pbWorldCup;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
}
