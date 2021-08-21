﻿using LMJ.Business;
using LMJ.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LMJ.Services.Http
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Cart")]
    public class CartService : ApiController
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="Cart"> </param>
        [HttpPost]
        [Route("Agregar")]
        public Cart AddCart(Cart cart)
        {
            try
            {
                var bc = new CartBusiness();
                return bc.Create(cart);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message + "+" + ex.InnerException
                };
                throw new HttpResponseException(httpError);
            }
        }

        [HttpPut]
        [Route("Editar")]
        public void Edit(Cart cart)
        {
            try
            {
                var bc = new CartBusiness();
                bc.EditProduct(cart);
            }
            catch (Exception ex)
            {
                // Repack to Http error.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"> </param>
        /// <returns></returns>
        [HttpGet]
        [Route("Buscar")]
        public Cart Find(int id)
        {
            try
            {
                var bc = new CartBusiness();
                return bc.GetById(id);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }
    }
}