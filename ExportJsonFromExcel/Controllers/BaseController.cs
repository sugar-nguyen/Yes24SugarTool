using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExportJsonFromExcel.Controllers
{
    public class BaseController : Controller
    {
        public FileResult DownLoadJsonFile(string path)
        {

            if (!System.IO.File.Exists(path))
            {
                throw new Exception("Đường dẫn file không hợp lệ.");
            }
            return File(path,"application/json","Output.json");
        }
    }
}