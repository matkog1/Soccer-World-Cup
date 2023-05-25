namespace WinFormsApp1.Forms
{
    partial class PlayerRankingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerRankingForm));
            dataGridPlayers = new DataGridView();
            lblPlayerRanking = new Label();
            btnPrint = new Button();
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
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.Name = "btnPrint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // PlayerRankingForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ControlBox = false;
            Controls.Add(btnPrint);
            Controls.Add(lblPlayerRanking);
            Controls.Add(dataGridPlayers);
            Name = "PlayerRankingForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPlayers;
        private Label lblPlayerRanking;
        private Button btnPrint;
    }
}