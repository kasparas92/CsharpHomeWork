using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionAndAttribute
{
    public class Converter
    {
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            var temp = typeof(T);
            var obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (var pro in temp.GetProperties())
                {
                    var isNameMatched = NamesMatched(pro, column.ColumnName);
                    if (pro.Name == column.ColumnName || isNameMatched)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        private static bool NamesMatched(PropertyInfo pro, string columnName)
        {
            var displayNameAttr = pro.GetCustomAttributes(false)
                .OfType<NamesAttribute>().FirstOrDefault();
            return (displayNameAttr?.Values ?? "") == columnName;
        }
    }
}
