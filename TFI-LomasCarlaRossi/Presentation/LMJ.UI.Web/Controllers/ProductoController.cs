﻿using LMJ.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMJ.UI.Web.Controllers
{
    public class ProductoController : Controller
    {
        ProductProcess productProcess = new ProductProcess();

        public ActionResult Index()
        {
            var lista = productProcess.List();
            return View(lista);
        }
    }
}