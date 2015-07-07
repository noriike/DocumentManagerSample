using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocumentManagerSample.Controllers
{
    public class DocumentController : Controller
    {
        //
        // GET: /Document/

        public ActionResult Index()
        {
            DocumentManagerSample.Models.IndexModel model = new DocumentManagerSample.Models.IndexModel();

            model.lstCategory.Add(new Models.IndexModel.Category("1","診療情報提供書A"));
            model.lstCategory.Add(new Models.IndexModel.Category("2", "返書"));
            model.lstCategory.Add(new Models.IndexModel.Category("3", "診療情報提供書B"));

            return View(model);
        }

        public ActionResult Search()
        {

            return PartialView("Search");
        }

    }
}
