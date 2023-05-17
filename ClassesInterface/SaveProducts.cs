using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Interface;

namespace ООО__Товары_для_животных_.ClassesInterface
{
    public class SaveProducts : ISaveProductDB
    {
        public void SaveProduct()
        {
            DB.Instance.SaveChanges();
        }
    }
}
