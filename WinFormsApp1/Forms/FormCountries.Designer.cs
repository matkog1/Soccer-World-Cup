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
            panel2 = new Panel();
            groupboxFavoriteTeams = new GroupBox();
            btnRemove = new Button();
            dataGridPlayers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnSave = new Button();
            lbPlayers = new Label();
            lbTeams = new Label();
            cbTeams = new ComboBox();
            cbCountryPlayers = new ComboBox();
            panel2.SuspendLayout();
            groupboxFavoriteTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 43, 60);
            panel2.Controls.Add(groupboxFavoriteTeams);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 537);
            panel2.TabIndex = 4;
            // 
            // groupboxFavoriteTeams
            // 
            groupboxFavoriteTeams.Controls.Add(btnRemove);
            groupboxFavoriteTeams.Controls.Add(dataGridPlayers);
            groupboxFavoriteTeams.Controls.Add(button1);
            groupboxFavoriteTeams.Controls.Add(btnSave);
            groupboxFavoriteTeams.Controls.Add(lbPlayers);
            groupboxFavoriteTeams.Controls.Add(lbTeams);
            groupboxFavoriteTeams.Controls.Add(cbTeams);
            groupboxFavoriteTeams.Controls.Add(cbCountryPlayers);
            groupboxFavoriteTeams.ForeColor = Color.Black;
            groupboxFavoriteTeams.Location = new Point(44, 31);
            groupboxFavoriteTeams.Name = "groupboxFavoriteTeams";
            groupboxFavoriteTeams.Size = new Size(610, 481);
            groupboxFavoriteTeams.TabIndex = 2;
            groupboxFavoriteTeams.TabStop = false;
            groupboxFavoriteTeams.Text = "Favorite Teams";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(176, 136);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(83, 23);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridPlayers
            // 
            dataGridPlayers.BackgroundColor = Color.White;
            dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlayers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridPlayers.GridColor = Color.Black;
            dataGridPlayers.Location = new Point(22, 203);
            dataGridPlayers.Name = "dataGridPlayers";
            dataGridPlayers.RowTemplate.Height = 25;
            dataGridPlayers.Size = new Size(566, 259);
            dataGridPlayers.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Shirt Number";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Position";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Captain";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Favorite";
            Column5.Name = "Column5";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(332, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(438, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // lbPlayers
            // 
            lbPlayers.AutoSize = true;
            lbPlayers.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlayers.ForeColor = Color.White;
            lbPlayers.Location = new Point(22, 93);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(113, 29);
            lbPlayers.TabIndex = 3;
            lbPlayers.Text = "Players";
            // 
            // lbTeams
            // 
            lbTeams.AutoSize = true;
            lbTeams.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTeams.ForeColor = Color.White;
            lbTeams.Location = new Point(22, 48);
            lbTeams.Name = "lbTeams";
            lbTeams.Size = new Size(100, 29);
            lbTeams.TabIndex = 2;
            lbTeams.Text = "Teams";
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(176, 48);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(231, 23);
            cbTeams.TabIndex = 0;
            // 
            // cbCountryPlayers
            // 
            cbCountryPlayers.FormattingEnabled = true;
            cbCountryPlayers.Location = new Point(176, 99);
            cbCountryPlayers.Name = "cbCountryPlayers";
            cbCountryPlayers.Size = new Size(231, 23);
            cbCountryPlayers.TabIndex = 1;
            // 
            // FormCountries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 537);
            Controls.Add(panel2);
            Name = "FormCountries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            groupboxFavoriteTeams.ResumeLayout(false);
            groupboxFavoriteTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ComboBox cbCountryPlayers;
        private ComboBox cbTeams;
        private GroupBox groupboxFavoriteTeams;
        private Label lbPlayers;
        private Label lbTeams;
        private Button btnSave;
        private Button button1;
        private DataGridView dataGridPlayers;
        private Button btnRemove;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}