using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Interface;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_.ClassesInterface
{
    public class SetValuesProduct : ISetValuesProduct
    {
        void ISetValuesProduct.SetValuesProduct(Product original, Product editProduct)
        {
            DB.Instance.Entry(original).CurrentValues.SetValues(editProduct);
        }
    }
}
