using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Interface;

namespace ООО__Товары_для_животных_.ClassesInterface
{
    public class SearchProductsCount : ISearchProductsCountDB
    {
        object ISearchProductsCountDB.SearchProducts()
        {
           return DB.Instance.Products.Count();
        }
    }
}
