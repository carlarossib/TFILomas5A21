﻿using LMJ.Entities.Model;
using LMJ.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMJ.UI.Web.Controllers
{
    public class GaleriaController:Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}
        ProductProcess productProcess = new ProductProcess();
        protected CartController cartController = new CartController();


        public ActionResult Index()
        {
            var lista = productProcess.List();
            return View(lista);
        }

        [HttpPost]
        public JsonResult AddCart(int? id)
        {
            var product = productProcess.Get(Convert.ToInt32(id));
            var cartResult = new Cart();
            var carItem = new CartItem();
            var listCarItem = new List<CartItem>();
            if(Session["Cart"]== null  || String.IsNullOrEmpty(Session["Cart"].ToString()))
            {

                carItem.ProductId = product.Id;
                carItem.Price = product.Price;
                carItem.Quantity = 1;
                carItem.ChangedBy = "admin";
                carItem.ChangedOn = DateTime.Now;
                carItem.CreatedOn = DateTime.Now;                
                listCarItem.Add(carItem);
                cartResult = cartController.AddCart(listCarItem);
            }
            else
            {
                cartResult = cartController.GetCar();
            }

            return Json(cartResult, JsonRequestBehavior.AllowGet);
        }
    }
}