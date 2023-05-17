using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class PlayerStats
    {
        public string Player { get; set; }

        public int Goals { get; set; }

        public int YellowCards { get; set; }

        public override string ToString() => $"{Player}, {Goals},{YellowCards}";
    }
}
