using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarUtilities
{
    /// <summary>
    /// 
    /// </summary>
   public static class Global
    {
        /// <summary>
        /// 
        /// </summary>
        public static string ExcelDirectory = ConfigurationManager.AppSettings["ExcelDirectory"];
        /// <summary>
        /// 
        /// </summary>
        public static string JsonDirectory = ConfigurationManager.AppSettings["JsonDirectory"];
        /// <summary>
        /// 
        /// </summary>
        public static string ImagesDirectory = ConfigurationManager.AppSettings["ImagesDirectory"];
    }
}
