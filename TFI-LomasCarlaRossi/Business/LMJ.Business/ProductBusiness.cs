using LMJ.Data;
using LMJ.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMJ.Business
{
    public class ProductBusiness
    {
        private BaseDataService<Producto> db = new BaseDataService<Producto>();
        public List<Producto> GetProducts()
        {
            return db.Get();
        }
        public Producto EditProduct(Producto product)
        {
            return db.Update(product, product.Id);
        }
        public Producto GetById(int id)
        {
            return db.GetById(id);
        }
        public Producto Create(Producto product)
        {
            return db.Create(product);
        }
        public void Delete (int id)
        {
            db.Delete(id);
        }
    }
}
