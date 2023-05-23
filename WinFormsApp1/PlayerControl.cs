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
        }

        private string _playerName;
        private bool _playerCaptain;
        private int _playerNumber;
        private string _playerPosition;
        private bool _playerFavorite;
        private Image _icon;

        public string PlayerName { get => _playerName; set => lblName.Text = value; }
        public bool PlayerCaptain { get => _playerCaptain; set => lblCaptain.Text = value.ToString(); }
        public int PlayerNumber { get => _playerNumber; set => lblShirtNumber.Text = value.ToString(); }
        public string PlayerPosition { get => _playerPosition; set => lblPosition.Text = value; }
        public bool PlayerFavorite { get => _playerFavorite; set => lblFavorite.Text = value.ToString(); }
        public Image Icon { get => _icon; set => _icon = value; }
    }
}
