﻿using LMJ.Business;
using LMJ.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMJ.UI.Process
{
    public class CartProcess : ProcessComponent
    {

   
        public Cart Get(int id)
        {
            var response = HttpGet<Cart>("api/Cart/buscar", new List<object>() { id }, MediaType.Json);
            return response;
        }

        public Cart Add(Cart cart)
        {
            var response = HttpPost<Cart>("api/Cart/agregar", cart, MediaType.Json);
            return response;
        }

        public void Edit(Cart cart)
        {
            HttpPost<Cart>("api/Cart/editar", cart, MediaType.Json);
        }
    }
}
