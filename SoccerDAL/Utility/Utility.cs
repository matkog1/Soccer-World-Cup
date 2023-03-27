using Microsoft.VisualBasic;
using SoccerDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Utility
{
    public static class Utility
    {
        public static void Print<T>(IList<T> lista)
        {
           foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }

 
}
