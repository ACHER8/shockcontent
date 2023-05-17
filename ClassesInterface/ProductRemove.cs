using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Interface;
using ООО__Товары_для_животных_.Models;
using ООО__Товары_для_животных_.ViewModels;

namespace ООО__Товары_для_животных_.ClassesInterface
{
    public class ProductRemove : IProductsRemoveDB
    {

        void IProductsRemoveDB.ProductRemove(Product selectedProduct)
        {
             DB.Instance.Products.Remove(selectedProduct);
        }
    }
}
