namespace WinFormsApp1.Forms
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            dataGridPlayers = new DataGridView();
            lblPlayerRanking = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
            SuspendLayout();
            // 
            // dataGridPlayers
            // 
            dataGridPlayers.BackgroundColor = SystemColors.Control;
            dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridPlayers, "dataGridPlayers");
            dataGridPlayers.Name = "dataGridPlayers";
            dataGridPlayers.RowTemplate.Height = 25;
            dataGridPlayers.ColumnHeaderMouseClick += dataGridPlayers_ColumnHeaderMouseClick;
            // 
            // lblPlayerRanking
            // 
            resources.ApplyResources(lblPlayerRanking, "lblPlayerRanking");
            lblPlayerRanking.ForeColor = Color.White;
            lblPlayerRanking.Name = "lblPlayerRanking";
            // 
            // PlayerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ControlBox = false;
            Controls.Add(lblPlayerRanking);
            Controls.Add(dataGridPlayers);
            Name = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPlayers;
        private Label lblPlayerRanking;
    }
}