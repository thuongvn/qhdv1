using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace QUANGHANH2.excel.TCLD.Certificate
{
    public class ExportData2ExcelController : Controller
    {
        // GET: ExportData2Excel
        public ActionResult Index()
        {
            return View();
        }
        public void ExportToExcel()
        {
            var grid = new GridView();
            //grid.DataSource = from data in Clien
        }
    }


}