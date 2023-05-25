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
            btnRefresh = new Button();
            pbMinimize = new PictureBox();
            pbMaximize = new PictureBox();
            pbExit = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            btnPlayerRanking = new Button();
            btnrankingMatches = new Button();
            btnFavorite = new Button();
            btnSettings = new Button();
            pnl = new Panel();
            pnlMain = new Panel();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            resources.ApplyResources(pnlTop, "pnlTop");
            pnlTop.BackColor = Color.FromArgb(76, 75, 105);
            pnlTop.Controls.Add(btnRefresh);
            pnlTop.Controls.Add(pbMinimize);
            pnlTop.Controls.Add(pbMaximize);
            pnlTop.Controls.Add(pbExit);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Name = "pnlTop";
            // 
            // btnRefresh
            // 
            resources.ApplyResources(btnRefresh, "btnRefresh");
            btnRefresh.Name = "btnRefresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pbMinimize
            // 
            resources.ApplyResources(pbMinimize, "pbMinimize");
            pbMinimize.Image = Properties.Resources.minimize;
            pbMinimize.Name = "pbMinimize";
            pbMinimize.TabStop = false;
            pbMinimize.Click += pictureBox2_Click_2;
            // 
            // pbMaximize
            // 
            resources.ApplyResources(pbMaximize, "pbMaximize");
            pbMaximize.Image = Properties.Resources.maximize;
            pbMaximize.Name = "pbMaximize";
            pbMaximize.TabStop = false;
            pbMaximize.Click += pbMaximize_Click;
            // 
            // pbExit
            // 
            resources.ApplyResources(pbExit, "pbExit");
            pbExit.Image = Properties.Resources.cancel;
            pbExit.Name = "pbExit";
            pbExit.TabStop = false;
            pbExit.Click += pictureBox2_Click_1;
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
            pnlLeft.Controls.Add(btnPlayerRanking);
            pnlLeft.Controls.Add(btnrankingMatches);
            pnlLeft.Controls.Add(btnFavorite);
            pnlLeft.Controls.Add(btnSettings);
            pnlLeft.ForeColor = Color.FromArgb(44, 43, 60);
            pnlLeft.Name = "pnlLeft";
            // 
            // btnPlayerRanking
            // 
            resources.ApplyResources(btnPlayerRanking, "btnPlayerRanking");
            btnPlayerRanking.Name = "btnPlayerRanking";
            btnPlayerRanking.UseVisualStyleBackColor = true;
            btnPlayerRanking.Click += btnPlayerRanking_Click;
            // 
            // btnrankingMatches
            // 
            resources.ApplyResources(btnrankingMatches, "btnrankingMatches");
            btnrankingMatches.Name = "btnrankingMatches";
            btnrankingMatches.UseVisualStyleBackColor = true;
            btnrankingMatches.Click += btnRankingMatches_Click;
            // 
            // btnFavorite
            // 
            resources.ApplyResources(btnFavorite, "btnFavorite");
            btnFavorite.Name = "btnFavorite";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
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
            ControlBox = false;
            Controls.Add(pnl);
            ForeColor = Color.FromArgb(44, 43, 60);
            Name = "MainForm";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
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
        private Button btnFavorite;
        private Button btnrankingMatches;
        private Button btnPlayerRanking;
        private Button btnRefresh;
        private PictureBox pbMinimize;
        private PictureBox pbMaximize;
        private PictureBox pbExit;
    }
}