using Microsoft.EntityFrameworkCore;
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
    public class SearchProductQuery : ISearchProductQueryDB
    {

        List<Product> ISearchProductQueryDB.SearchProductQuery(string searchText)
        {
            return (List<Product>)DB.Instance.Products
                                                          .Include(p => p.ProductManufacturer)
                                                          .Include(p => p.ProductProvider)
                                                          .Include(p => p.OrderProducts)
                                                          .Include(p => p.ProductCategory)
                                                          .Where(s => s.ProductArticleNumber.Contains(searchText) ||
                                                                      s.ProductCategory.Title.Contains(searchText) ||
                                                                      s.ProductDescription.Contains(searchText) ||
                                                                      s.ProductManufacturer.Title.Contains(searchText) ||
                                                                      s.ProductTitle.Contains(searchText) ||
                                                                      s.ProductProvider.Title.Contains(searchText));
        }
    }
}
