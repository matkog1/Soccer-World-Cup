namespace WinFormsApp1.Forms
{
    partial class RankingMatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingMatchesForm));
            dataGridRanking = new DataGridView();
            cbTeamsRanking = new ComboBox();
            lblCountryRanking = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRanking).BeginInit();
            SuspendLayout();
            // 
            // dataGridRanking
            // 
            resources.ApplyResources(dataGridRanking, "dataGridRanking");
            dataGridRanking.BackgroundColor = Color.White;
            dataGridRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRanking.GridColor = SystemColors.ControlText;
            dataGridRanking.Name = "dataGridRanking";
            dataGridRanking.RowTemplate.Height = 25;
            // 
            // cbTeamsRanking
            // 
            resources.ApplyResources(cbTeamsRanking, "cbTeamsRanking");
            cbTeamsRanking.FormattingEnabled = true;
            cbTeamsRanking.Name = "cbTeamsRanking";
            cbTeamsRanking.SelectedIndexChanged += cbTeamsRanking_SelectedIndexChanged;
            // 
            // lblCountryRanking
            // 
            resources.ApplyResources(lblCountryRanking, "lblCountryRanking");
            lblCountryRanking.ForeColor = Color.White;
            lblCountryRanking.Name = "lblCountryRanking";
            // 
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.Name = "btnPrint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // RankingMatchesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ControlBox = false;
            Controls.Add(btnPrint);
            Controls.Add(lblCountryRanking);
            Controls.Add(cbTeamsRanking);
            Controls.Add(dataGridRanking);
            ForeColor = SystemColors.ControlText;
            Name = "RankingMatchesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRanking;
        private ComboBox cbTeamsRanking;
        private Label lblCountryRanking;
        private Button btnPrint;
    }
}