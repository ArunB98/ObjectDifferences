using System;
using System.Collections.Generic;
using System.Reflection;

namespace ObjectDifferences
{
    public static class Comparer
    {
        public static List<Difference> Compare<T>(this T val1, T val2)
        {
            var type = val1.GetType();
            var variances = new List<Difference>();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType.IsClass)
                {
                    variances.AddRange(Compare(property.GetValue(val1), property.GetValue(val2)));
                    return variances;
                }

                var d = new Difference
                {
                    Name = property.Name,
                    Val1 = property.GetValue(val1),
                    Val2 = property.GetValue(val2)
                };
                if (d.Val1 == null && d.Val2 == null)
                {
                    continue;
                }
                if ((d.Val1 == null && d.Val2 != null) || (d.Val1 != null && d.Val2 == null))
                {
                    variances.Add(d);
                    continue;
                }
                if (!d.Val1.Equals(d.Val2))
                {
                    variances.Add(d);
                }
            }
            return variances;
        }
    }
}