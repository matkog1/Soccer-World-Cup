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
            string[] language = File.ReadAllLines(filePath);
            string chosenLanguage = language[1];

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
        public static void CompareColumns<T>(List<T> list, string propertyForComparison, bool order)
        {
            list.Sort(new PropertyComparer<T>(propertyForComparison, order));
        }
    }
}
