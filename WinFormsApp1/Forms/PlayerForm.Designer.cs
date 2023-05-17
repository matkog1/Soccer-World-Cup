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
            dataGridPlayers = new DataGridView();
            lblPlayerRanking = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
            SuspendLayout();
            // 
            // dataGridPlayers
            // 
            dataGridPlayers.BackgroundColor = SystemColors.Control;
            dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlayers.Location = new Point(85, 160);
            dataGridPlayers.Name = "dataGridPlayers";
            dataGridPlayers.RowTemplate.Height = 25;
            dataGridPlayers.Size = new Size(648, 231);
            dataGridPlayers.TabIndex = 0;
            dataGridPlayers.ColumnHeaderMouseClick += dataGridPlayers_ColumnHeaderMouseClick;
            // 
            // lblPlayerRanking
            // 
            lblPlayerRanking.AutoSize = true;
            lblPlayerRanking.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerRanking.ForeColor = Color.White;
            lblPlayerRanking.Location = new Point(85, 104);
            lblPlayerRanking.Name = "lblPlayerRanking";
            lblPlayerRanking.Size = new Size(216, 29);
            lblPlayerRanking.TabIndex = 1;
            lblPlayerRanking.Text = "Player Ranking";
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(lblPlayerRanking);
            Controls.Add(dataGridPlayers);
            Name = "PlayerForm";
            Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPlayers;
        private Label lblPlayerRanking;
    }
}