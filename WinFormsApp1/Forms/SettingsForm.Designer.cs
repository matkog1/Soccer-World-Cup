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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            resources.ApplyResources(groupboxLogin, "groupboxLogin");
            groupboxLogin.Name = "groupboxLogin";
            groupboxLogin.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            resources.ApplyResources(cbLanguage, "cbLanguage");
            cbLanguage.Name = "cbLanguage";
            // 
            // cbChampionship
            // 
            cbChampionship.FormattingEnabled = true;
            resources.ApplyResources(cbChampionship, "cbChampionship");
            cbChampionship.Name = "cbChampionship";
            // 
            // lbLanguage
            // 
            resources.ApplyResources(lbLanguage, "lbLanguage");
            lbLanguage.ForeColor = SystemColors.ButtonHighlight;
            lbLanguage.Name = "lbLanguage";
            // 
            // lbChampionship
            // 
            resources.ApplyResources(lbChampionship, "lbChampionship");
            lbChampionship.ForeColor = SystemColors.ButtonHighlight;
            lbChampionship.Name = "lbChampionship";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 43, 60);
            ControlBox = false;
            Controls.Add(groupboxLogin);
            Name = "SettingsForm";
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