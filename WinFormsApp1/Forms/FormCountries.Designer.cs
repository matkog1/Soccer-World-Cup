namespace WinFormsApp1
{
    partial class FormCountries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountries));
            panel2 = new Panel();
            lblFavoritePlayers = new Label();
            lblAllPlayers = new Label();
            flp2 = new FlowLayoutPanel();
            flp1 = new FlowLayoutPanel();
            btnSave = new Button();
            lbTeams = new Label();
            lbPlayers = new Label();
            cbTeams = new ComboBox();
            cbCountryPlayers = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 43, 60);
            panel2.Controls.Add(lblFavoritePlayers);
            panel2.Controls.Add(lblAllPlayers);
            panel2.Controls.Add(flp2);
            panel2.Controls.Add(flp1);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(lbTeams);
            panel2.Controls.Add(lbPlayers);
            panel2.Controls.Add(cbTeams);
            panel2.Controls.Add(cbCountryPlayers);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.ContextMenuStripChanged += btnSave_Click;
            // 
            // lblFavoritePlayers
            // 
            resources.ApplyResources(lblFavoritePlayers, "lblFavoritePlayers");
            lblFavoritePlayers.ForeColor = Color.White;
            lblFavoritePlayers.Name = "lblFavoritePlayers";
            // 
            // lblAllPlayers
            // 
            resources.ApplyResources(lblAllPlayers, "lblAllPlayers");
            lblAllPlayers.ForeColor = Color.White;
            lblAllPlayers.Name = "lblAllPlayers";
            // 
            // flp2
            // 
            flp2.AllowDrop = true;
            flp2.BackColor = Color.White;
            resources.ApplyResources(flp2, "flp2");
            flp2.Name = "flp2";
            // 
            // flp1
            // 
            flp1.AllowDrop = true;
            resources.ApplyResources(flp1, "flp1");
            flp1.BackColor = Color.White;
            flp1.Name = "flp1";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbTeams
            // 
            resources.ApplyResources(lbTeams, "lbTeams");
            lbTeams.ForeColor = Color.White;
            lbTeams.Name = "lbTeams";
            // 
            // lbPlayers
            // 
            resources.ApplyResources(lbPlayers, "lbPlayers");
            lbPlayers.ForeColor = Color.White;
            lbPlayers.Name = "lbPlayers";
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            resources.ApplyResources(cbTeams, "cbTeams");
            cbTeams.Name = "cbTeams";
            // 
            // cbCountryPlayers
            // 
            cbCountryPlayers.FormattingEnabled = true;
            resources.ApplyResources(cbCountryPlayers, "cbCountryPlayers");
            cbCountryPlayers.Name = "cbCountryPlayers";
            // 
            // FormCountries
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "FormCountries";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ComboBox cbCountryPlayers;
        private ComboBox cbTeams;
        private Label lbPlayers;
        private Label lbTeams;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private FlowLayoutPanel flp1;
        private FlowLayoutPanel flp2;
        private Label lblFavoritePlayers;
        private Label lblAllPlayers;
    }
}