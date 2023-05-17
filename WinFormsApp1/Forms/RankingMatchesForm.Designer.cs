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
            dataGridRanking = new DataGridView();
            cbTeamsRanking = new ComboBox();
            lblCountryRanking = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRanking).BeginInit();
            SuspendLayout();
            // 
            // dataGridRanking
            // 
            dataGridRanking.BackgroundColor = Color.White;
            dataGridRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRanking.GridColor = SystemColors.ControlText;
            dataGridRanking.Location = new Point(69, 157);
            dataGridRanking.Name = "dataGridRanking";
            dataGridRanking.RowTemplate.Height = 25;
            dataGridRanking.Size = new Size(546, 184);
            dataGridRanking.TabIndex = 0;
            // 
            // cbTeamsRanking
            // 
            cbTeamsRanking.FormattingEnabled = true;
            cbTeamsRanking.Location = new Point(69, 107);
            cbTeamsRanking.Name = "cbTeamsRanking";
            cbTeamsRanking.Size = new Size(142, 23);
            cbTeamsRanking.TabIndex = 1;
            cbTeamsRanking.SelectedIndexChanged += cbTeamsRanking_SelectedIndexChanged;
            // 
            // lblCountryRanking
            // 
            lblCountryRanking.AutoSize = true;
            lblCountryRanking.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountryRanking.ForeColor = Color.White;
            lblCountryRanking.Location = new Point(69, 60);
            lblCountryRanking.Name = "lblCountryRanking";
            lblCountryRanking.Size = new Size(240, 29);
            lblCountryRanking.TabIndex = 2;
            lblCountryRanking.Text = "Country Matches";
            // 
            // RankingMatchesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(lblCountryRanking);
            Controls.Add(cbTeamsRanking);
            Controls.Add(dataGridRanking);
            ForeColor = SystemColors.ControlText;
            Name = "RankingMatchesForm";
            Text = "RankingMatchesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRanking;
        private ComboBox cbTeamsRanking;
        private Label lblCountryRanking;
    }
}