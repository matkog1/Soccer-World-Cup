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
            btnOrderByGoals = new Button();
            btnOrderByYellowCards = new Button();
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
            // 
            // btnOrderByGoals
            // 
            btnOrderByGoals.Location = new Point(85, 100);
            btnOrderByGoals.Name = "btnOrderByGoals";
            btnOrderByGoals.Size = new Size(101, 32);
            btnOrderByGoals.TabIndex = 1;
            btnOrderByGoals.Text = "Order by Goals";
            btnOrderByGoals.UseVisualStyleBackColor = true;
            // 
            // btnOrderByYellowCards
            // 
            btnOrderByYellowCards.Location = new Point(207, 100);
            btnOrderByYellowCards.Name = "btnOrderByYellowCards";
            btnOrderByYellowCards.Size = new Size(101, 32);
            btnOrderByYellowCards.TabIndex = 2;
            btnOrderByYellowCards.Text = "Order By Yellow Cards";
            btnOrderByYellowCards.UseVisualStyleBackColor = true;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrderByYellowCards);
            Controls.Add(btnOrderByGoals);
            Controls.Add(dataGridPlayers);
            Name = "PlayerForm";
            Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPlayers;
        private Button btnOrderByGoals;
        private Button btnOrderByYellowCards;
    }
}