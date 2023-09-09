namespace WinFormsApp1
{
    partial class PlayerControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblShirtNumber = new Label();
            lblPosition = new Label();
            lblCaptain = new Label();
            lblFavorite = new Label();
            pictureBox1 = new PictureBox();
            lbName = new Label();
            lbShirtNumber = new Label();
            lbPosition = new Label();
            lbCaptain = new Label();
            lbFavorite = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(270, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblShirtNumber.ForeColor = Color.White;
            lblShirtNumber.Location = new Point(270, 65);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(117, 21);
            lblShirtNumber.TabIndex = 2;
            lblShirtNumber.Text = "Shirt Number ";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(270, 97);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(77, 21);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position ";
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptain.ForeColor = Color.White;
            lblCaptain.Location = new Point(270, 132);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(73, 21);
            lblCaptain.TabIndex = 4;
            lblCaptain.Text = "Captain ";
            // 
            // lblFavorite
            // 
            lblFavorite.AutoSize = true;
            lblFavorite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavorite.ForeColor = Color.White;
            lblFavorite.Location = new Point(270, 166);
            lblFavorite.Name = "lblFavorite";
            lblFavorite.Size = new Size(76, 21);
            lblFavorite.TabIndex = 5;
            lblFavorite.Text = "Favorite ";
            lblFavorite.Click += lblFavorite_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(20, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(192, 41);
            lbName.Name = "lbName";
            lbName.Size = new Size(40, 15);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbShirtNumber
            // 
            lbShirtNumber.AutoSize = true;
            lbShirtNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbShirtNumber.ForeColor = Color.White;
            lbShirtNumber.Location = new Point(193, 71);
            lbShirtNumber.Name = "lbShirtNumber";
            lbShirtNumber.Size = new Size(53, 15);
            lbShirtNumber.TabIndex = 7;
            lbShirtNumber.Text = "Number";
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPosition.ForeColor = Color.White;
            lbPosition.Location = new Point(192, 102);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(51, 15);
            lbPosition.TabIndex = 8;
            lbPosition.Text = "Position";
            // 
            // lbCaptain
            // 
            lbCaptain.AutoSize = true;
            lbCaptain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptain.ForeColor = Color.White;
            lbCaptain.Location = new Point(192, 137);
            lbCaptain.Name = "lbCaptain";
            lbCaptain.Size = new Size(48, 15);
            lbCaptain.TabIndex = 9;
            lbCaptain.Text = "Captain";
            // 
            // lbFavorite
            // 
            lbFavorite.AutoSize = true;
            lbFavorite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbFavorite.ForeColor = Color.White;
            lbFavorite.Location = new Point(193, 166);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(53, 15);
            lbFavorite.TabIndex = 10;
            lbFavorite.Text = "Favorite";
            // 
            // PlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 75, 105);
            Controls.Add(lbFavorite);
            Controls.Add(lbCaptain);
            Controls.Add(lbPosition);
            Controls.Add(lbShirtNumber);
            Controls.Add(lbName);
            Controls.Add(lblFavorite);
            Controls.Add(lblCaptain);
            Controls.Add(lblPosition);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Name = "PlayerControl";
            Size = new Size(440, 213);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblShirtNumber;
        private Label lblPosition;
        private Label lblCaptain;
        private Label lblFavorite;
        private PictureBox pictureBox1;
        private Label lbName;
        private Label lbShirtNumber;
        private Label lbPosition;
        private Label lbCaptain;
        private Label lbFavorite;
    }
}
