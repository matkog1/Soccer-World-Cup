using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
            this.MouseDown += PlayerControl_MouseDown;
        }

        public PlayerControl(string playerName, bool playerCaptain, int playerNumber, string playerPosition, bool playerFavorite, Image icon)
        {
            _playerName = playerName;
            _playerCaptain = playerCaptain;
            _playerNumber = playerNumber;
            _playerPosition = playerPosition;
            _playerFavorite = playerFavorite;
            _icon = icon;
        }

        private string _playerName;
        private bool _playerCaptain;
        private int _playerNumber;
        private string _playerPosition;
        private bool _playerFavorite;
        private Image _icon;

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.Move);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        public string PlayerName { get => _playerName; set => lblName.Text = value; }
        public bool PlayerCaptain { get => _playerCaptain; set => lblCaptain.Text = value.ToString(); }
        public int PlayerNumber { get => _playerNumber; set => lblShirtNumber.Text = value.ToString(); }
        public string PlayerPosition { get => _playerPosition; set => lblPosition.Text = value; }
        public bool PlayerFavorite { get => _playerFavorite; set => lblFavorite.Text = value.ToString(); }
        public Image Icon { get => pictureBox1.Image; set => pictureBox1.Image = value; }

        public override string ToString()
        {
            return $"Name:{PlayerName},Captain:{PlayerCaptain},Shirt number:{PlayerNumber},Position:{PlayerPosition},Favorite:{PlayerFavorite}";
        }

        private void lblFavorite_Click(object sender, EventArgs e)
        {

        }
    }
}
