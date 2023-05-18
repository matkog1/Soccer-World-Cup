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
            dataGridPlayers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lbTeams = new Label();
            lbPlayers = new Label();
            btnRemove = new Button();
            btnSave = new Button();
            cbTeams = new ComboBox();
            button1 = new Button();
            cbCountryPlayers = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 43, 60);
            panel2.Controls.Add(dataGridPlayers);
            panel2.Controls.Add(lbTeams);
            panel2.Controls.Add(lbPlayers);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(cbTeams);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbCountryPlayers);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // dataGridPlayers
            // 
            dataGridPlayers.BackgroundColor = Color.White;
            dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlayers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridPlayers.GridColor = Color.Black;
            resources.ApplyResources(dataGridPlayers, "dataGridPlayers");
            dataGridPlayers.Name = "dataGridPlayers";
            dataGridPlayers.RowTemplate.Height = 25;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(Column5, "Column5");
            Column5.Name = "Column5";
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
            // btnRemove
            // 
            resources.ApplyResources(btnRemove, "btnRemove");
            btnRemove.Name = "btnRemove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // cbTeams
            // 
            cbTeams.FormattingEnabled = true;
            resources.ApplyResources(cbTeams, "cbTeams");
            cbTeams.Name = "cbTeams";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            ControlBox = false;
            Controls.Add(panel2);
            Name = "FormCountries";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ComboBox cbCountryPlayers;
        private ComboBox cbTeams;
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