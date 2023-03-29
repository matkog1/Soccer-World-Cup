using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Comparer
{

    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly PropertyInfo _property;
        private readonly bool _ascending;

        public PropertyComparer(string propertyName, bool ascending = true)
        {
            _property = typeof(T).GetProperty(propertyName);
            _ascending = ascending;
        }

        public int Compare(T x, T y)
        {
            object xValue = _property.GetValue(x);
            object yValue = _property.GetValue(y);

            int result;

            if (xValue == null && yValue == null)
            {
                result = 0;
            }
            else if (xValue == null)
            {
                result = -1;
            }
            else if (yValue == null)
            {
                result = 1;
            }
            else if (xValue is IComparable comparable)
            {
                result = comparable.CompareTo(yValue);
            }
            else if (xValue.Equals(yValue))
            {
                result = 0;
            }
            else
            {
                result = xValue.ToString().CompareTo(yValue.ToString());
            }

            if (!_ascending)
            {
                result = -result;
            }

            return result;
        }
    }
}


