using LMJ.Business;
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
    [RoutePrefix("api/Product")]
    public class ProductService : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"> </param>
        /// <returns></returns>
        [HttpPost]
        [Route("Agregar")]
        public Producto Add(Producto product)
        {
            try
            {
                var bc = new ProductBusiness();
                return bc.Create(product);
            }
            catch (Exception ex)
            {
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message+"+"+ex.InnerException
                };
                throw new HttpResponseException(httpError);
            }
        }
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="product"> </param>
        [HttpPut]
        [Route("Editar")]
        public void Edit(Producto product)
        {
            try
            {
                var bc = new ProductBusiness();
                bc.EditProduct(product);
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
        [Route("Buscar/{id}")]
        public Producto Find(int id)
        {
            try
            {
                var bc = new ProductBusiness();
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

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Listar")]
        public List<Producto> List()
        {
            try
            {
                var bc = new ProductBusiness();
                return bc.GetProducts();
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

        /// <summary>
        /// </summary>
        /// <param name="id"> </param>
        [HttpDelete]
        [Route("Eliminar")]
        public void Remove(int id)
        {
            try
            {
                var bc = new ProductBusiness();
                bc.Delete(id);
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