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
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblShirtNumber = new Label();
            lblPosition = new Label();
            lblCaptain = new Label();
            lblFavorite = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(20, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 118);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(202, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name ";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Location = new Point(202, 66);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(81, 15);
            lblShirtNumber.TabIndex = 2;
            lblShirtNumber.Text = "Shirt Number ";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(202, 95);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 15);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position ";
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.Location = new Point(202, 124);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(51, 15);
            lblCaptain.TabIndex = 4;
            lblCaptain.Text = "Captain ";
            // 
            // lblFavorite
            // 
            lblFavorite.AutoSize = true;
            lblFavorite.Location = new Point(202, 155);
            lblFavorite.Name = "lblFavorite";
            lblFavorite.Size = new Size(52, 15);
            lblFavorite.TabIndex = 5;
            lblFavorite.Text = "Favorite ";
            // 
            // PlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblFavorite);
            Controls.Add(lblCaptain);
            Controls.Add(lblPosition);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Name = "PlayerControl";
            Size = new Size(427, 231);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblName;
        private Label lblShirtNumber;
        private Label lblPosition;
        private Label lblCaptain;
        private Label lblFavorite;
    }
}
