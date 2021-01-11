using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace ExportJsonFromExcel.Models
{
    public class JsonObjectCustom
    {
        public string Day { get; set; }
        public string SerialName { get; set; }
        public string SerialCode { get; set; }
        public string Code { get; set; }
        public string Hour { get; set; }
        public string Qty { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public string GiftName { get; set; }
        public string Link { get; set; }
        public string FixedPrice { get; set; }
        public string SalePrice { get; set; }

        public static Dictionary<string, string> GetAllProperties()
        {
            return new Dictionary<string, string>() {
                {"Day","Day" },
                {"SerialCode","Serial Code" },
                {"SerialName","Serial Name" },
                {"Code","Code" },
                {"Hour","Hour" },
                { "Qty","Qty"},
                {"ProductName","Product Name" },
                {"Brand","Brand" },
                {"Type","Type" },
                {"Detail","Detail" },
                {"GiftName","Gift Name" },
                {"Link","Link" },
                 {"FixedPrice","Fixed Price" },
                 {"SalePrice","Sale Price" }
            };
        }
    }
}