namespace WinFormsApp1
{
    partial class MainForm
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
            pnlTop = new Panel();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnSettings = new Button();
            pnl = new Panel();
            pnlMain = new Panel();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(76, 75, 105);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1026, 69);
            pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.worldcup;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(50, 49, 69);
            pnlLeft.Controls.Add(button3);
            pnlLeft.Controls.Add(button2);
            pnlLeft.Controls.Add(btnSettings);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.ForeColor = Color.FromArgb(44, 43, 60);
            pnlLeft.Location = new Point(0, 69);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(127, 530);
            pnlLeft.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 139);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 3;
            button3.Text = "Ranking";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 88);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 1;
            button2.Text = "Favorite Teams";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Location = new Point(0, 37);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(130, 45);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += button1_Click;
            // 
            // pnl
            // 
            pnl.BackColor = Color.FromArgb(44, 43, 60);
            pnl.Controls.Add(pnlMain);
            pnl.Controls.Add(pnlLeft);
            pnl.Controls.Add(pnlTop);
            pnl.Dock = DockStyle.Fill;
            pnl.Location = new Point(0, 0);
            pnl.Name = "pnl";
            pnl.Size = new Size(1026, 599);
            pnl.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(127, 69);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(899, 530);
            pnlMain.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 599);
            Controls.Add(pnl);
            ForeColor = Color.FromArgb(44, 43, 60);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlLeft;
        private Panel pnl;
        private Panel pnlMain;
        private Button btnSettings;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}