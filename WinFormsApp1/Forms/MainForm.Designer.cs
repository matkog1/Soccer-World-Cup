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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlTop = new Panel();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            button1 = new Button();
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
            resources.ApplyResources(pnlTop, "pnlTop");
            pnlTop.BackColor = Color.FromArgb(76, 75, 105);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Name = "pnlTop";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.worldcup;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            resources.ApplyResources(pnlLeft, "pnlLeft");
            pnlLeft.BackColor = Color.FromArgb(50, 49, 69);
            pnlLeft.Controls.Add(button1);
            pnlLeft.Controls.Add(button3);
            pnlLeft.Controls.Add(button2);
            pnlLeft.Controls.Add(btnSettings);
            pnlLeft.ForeColor = Color.FromArgb(44, 43, 60);
            pnlLeft.Name = "pnlLeft";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += button1_Click;
            // 
            // pnl
            // 
            resources.ApplyResources(pnl, "pnl");
            pnl.BackColor = Color.FromArgb(44, 43, 60);
            pnl.Controls.Add(pnlMain);
            pnl.Controls.Add(pnlLeft);
            pnl.Controls.Add(pnlTop);
            pnl.Name = "pnl";
            // 
            // pnlMain
            // 
            resources.ApplyResources(pnlMain, "pnlMain");
            pnlMain.Name = "pnlMain";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl);
            ForeColor = Color.FromArgb(44, 43, 60);
            Name = "MainForm";
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
        private Button button1;
    }
}