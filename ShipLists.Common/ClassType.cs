using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShipLists.Common
{
    public class ClassType
    {
        /// <summary>
        /// 获取指定类名的System.Type
        /// </summary>
        /// <param name="className">类名</param>
        /// <returns>System.Type</returns>
        public static Type GetType(string className)
        {
            string[] values = ConfigurationManager.AppSettings[className].ToString().Split(',');
            return Assembly.Load(values[0]).GetType(values[1]);
        }
    }
}
