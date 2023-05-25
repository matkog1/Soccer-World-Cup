using RazorEngine;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using SoccerDAL.Comparer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Utility
{
    public static class Utility
    {
        public static void SetLanguage(Form form, string optionsFile)
        {
            string filePath = Path.Combine(Application.StartupPath, optionsFile);
            if (!File.Exists(filePath))
            {
                string defaultLanguage = "English";
                string defaultChampionship = "Men";
                string content = defaultChampionship + Environment.NewLine + defaultLanguage;
                File.WriteAllText(filePath, content);
            }
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[0];

            CultureInfo culture;
            switch (chosenLanguage)
            {
                case "Croatian":
                    culture = new CultureInfo("hr");
                    break;
                default:
                    culture = new CultureInfo("en");
                    break;
            }
            Thread.CurrentThread.CurrentUICulture = culture;
        }
        public static void CompareColumns<T>(List<T> matchesList, string propertyForComparison, bool order)
        {
            matchesList.Sort(new PropertyComparer<T>(propertyForComparison, order));
        }
    }
}
