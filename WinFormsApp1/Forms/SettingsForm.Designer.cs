namespace WinFormsApp1.Forms
{
    partial class SettingsForm
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
            components = new System.ComponentModel.Container();
            groupboxLogin = new GroupBox();
            btnSave = new Button();
            cbLanguage = new ComboBox();
            cbChampionship = new ComboBox();
            lbLanguage = new Label();
            lbChampionship = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupboxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupboxLogin
            // 
            groupboxLogin.Controls.Add(btnSave);
            groupboxLogin.Controls.Add(cbLanguage);
            groupboxLogin.Controls.Add(cbChampionship);
            groupboxLogin.Controls.Add(lbLanguage);
            groupboxLogin.Controls.Add(lbChampionship);
            groupboxLogin.ForeColor = SystemColors.ButtonHighlight;
            groupboxLogin.Location = new Point(130, 75);
            groupboxLogin.Name = "groupboxLogin";
            groupboxLogin.Size = new Size(471, 179);
            groupboxLogin.TabIndex = 0;
            groupboxLogin.TabStop = false;
            groupboxLogin.Text = "Login";
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(339, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(286, 99);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(128, 23);
            cbLanguage.TabIndex = 5;
            // 
            // cbChampionship
            // 
            cbChampionship.FormattingEnabled = true;
            cbChampionship.Location = new Point(286, 46);
            cbChampionship.Name = "cbChampionship";
            cbChampionship.Size = new Size(128, 23);
            cbChampionship.TabIndex = 4;
            // 
            // lbLanguage
            // 
            lbLanguage.AutoSize = true;
            lbLanguage.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbLanguage.ForeColor = SystemColors.ButtonHighlight;
            lbLanguage.Location = new Point(22, 93);
            lbLanguage.Name = "lbLanguage";
            lbLanguage.Size = new Size(144, 29);
            lbLanguage.TabIndex = 1;
            lbLanguage.Text = "Language";
            // 
            // lbChampionship
            // 
            lbChampionship.AutoSize = true;
            lbChampionship.Font = new Font("Bitstream Vera Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbChampionship.ForeColor = SystemColors.ButtonHighlight;
            lbChampionship.Location = new Point(22, 48);
            lbChampionship.Name = "lbChampionship";
            lbChampionship.Size = new Size(203, 29);
            lbChampionship.TabIndex = 0;
            lbChampionship.Text = "Championship";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ClientSize = new Size(714, 346);
            ControlBox = false;
            Controls.Add(groupboxLogin);
            Name = "SettingsForm";
            Text = "SettingsForm";
            groupboxLogin.ResumeLayout(false);
            groupboxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupboxLogin;
        private ComboBox cbLanguage;
        private ComboBox cbChampionship;
        private Label lbLanguage;
        private Label lbChampionship;
        private Button button2;
        private Button btnSave;
        private ContextMenuStrip contextMenuStrip1;
    }
}