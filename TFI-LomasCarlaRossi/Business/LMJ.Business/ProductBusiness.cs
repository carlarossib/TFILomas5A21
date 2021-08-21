﻿using LMJ.Data;
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
        private BaseDataService<Product> db = new BaseDataService<Product>();
        public List<Product> GetProducts()
        {
            return db.Get();
        }
        public Product EditProduct(Product product)
        {
            return db.Update(product, product.Id);
        }
        public Product GetById(int id)
        {
            return db.GetById(id);
        }
        public Product Create(Product product)
        {
            return db.Create(product);
        }
        public void Delete (int id)
        {
            db.Delete(id);
        }
    }
}
