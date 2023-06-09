﻿using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using SoccerDAL.Comparer;
using SoccerDAL.Models;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SoccerDAL.Utility
{
    public static class Utility
    {
        public static void Print<T>(IList<T> lista) => lista.ToList().ForEach(item => Console.WriteLine(item));

        public static void PrintDictionaryPlayers(Dictionary<string, List<Player>> pairs)
        {
            foreach (KeyValuePair<string, List<Player>> pair in pairs)
            {
                Console.WriteLine($"Country: {pair.Key}");
                Console.WriteLine("Players:");

                // Loop through the players in the list associated with the current country
                foreach (Player player in pair.Value)
                {
                    Console.WriteLine($"- Name: {player.Name}, Country: {player.Country}");
                }

                Console.WriteLine();
            }
        }

        public static void CompareColumns<T>(List<T> matchesList, string propertyForComparison, bool order)
        {
            matchesList.Sort(new PropertyComparer<T>(propertyForComparison, order));
        }

    }


}
