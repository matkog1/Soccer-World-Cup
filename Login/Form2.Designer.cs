namespace Login
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pbExit = new PictureBox();
            panel3 = new Panel();
            lbPlayers = new Label();
            btnSave = new Button();
            lbFavoriteTeam = new Label();
            cbTeams = new ComboBox();
            panel2 = new Panel();
            cbPlayers = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pbExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 8;
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
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(cbPlayers);
            panel3.Controls.Add(lbPlayers);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(lbFavoriteTeam);
            panel3.Controls.Add(cbTeams);
            panel3.Location = new Point(197, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(603, 410);
            panel3.TabIndex = 10;
            // 
            // lbPlayers
            // 
            lbPlayers.AutoSize = true;
            lbPlayers.ForeColor = Color.Black;
            lbPlayers.Location = new Point(144, 91);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(44, 15);
            lbPlayers.TabIndex = 6;
            lbPlayers.Text = "Players";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(261, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbFavoriteTeam
            // 
            lbFavoriteTeam.AutoSize = true;
            lbFavoriteTeam.ForeColor = Color.Black;
            lbFavoriteTeam.Location = new Point(144, 52);
            lbFavoriteTeam.Name = "lbFavoriteTeam";
            lbFavoriteTeam.Size = new Size(80, 15);
            lbFavoriteTeam.TabIndex = 1;
            lbFavoriteTeam.Text = "Favorite Team";
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(261, 44);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(211, 23);
            cbTeams.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 400);
            panel2.TabIndex = 9;
            // 
            // cbPlayers
            // 
            cbPlayers.FormattingEnabled = true;
            cbPlayers.Location = new Point(261, 83);
            cbPlayers.Name = "cbPlayers";
            cbPlayers.Size = new Size(211, 23);
            cbPlayers.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbExit;
        private Panel panel3;
        private ComboBox cbTeams;
        private Panel panel2;
        private Label lbFavoriteTeam;
        private Button btnSave;
        private Label lbPlayers;
        private ComboBox cbPlayers;
    }
}