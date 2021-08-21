using LMJ.Entities.Model;
using LMJ.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace LMJ.UI.Web.Controllers
{
    public class ArtistaController:Controller
    {
        ArtistaProcess artistaProcess = new ArtistaProcess();
        
        public ActionResult Index()
        {
            var lista = artistaProcess.List();
            return View(lista);
        }
    }
}