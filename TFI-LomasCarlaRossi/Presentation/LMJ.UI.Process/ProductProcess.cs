using LMJ.Business;
using LMJ.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMJ.UI.Process
{
    public class ProductProcess : ProcessComponent
    {

        public List<Producto> List()
        {
            var response = HttpGet<List<Producto>>("api/product/listar", new Dictionary<string, object>(), MediaType.Json);
            return response;
        }
        public Producto Get(int id)
        {
            var response = HttpGet<Producto>("api/product/buscar", new List<object>() { id }, MediaType.Json);
            return response;
        }

        public Producto Add(Producto product)
        {
            var response = HttpPost<Producto>("api/product/agregar", product, MediaType.Json);
            return response;
        }

        public void Edit(Producto product)
        {
            HttpPost<Producto>("api/product/editar", product, MediaType.Json);
        }
    }
}
