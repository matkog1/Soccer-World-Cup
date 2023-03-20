using System;
using System.Reflection;

public static class Utility
{
	public static string PrintFormat()
	{
        PropertyInfo[] properties = this.GetType().GetProperties();
        string result = "";

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(this, null);
            result += $"{property.Name}: {value}\n";
        }

        return result;
    }
}
