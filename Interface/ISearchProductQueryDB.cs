﻿using System.Collections.Generic;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_.Interface
{
    public interface ISearchProductQueryDB
    {
        List<Product> SearchProductQuery(string searchText);
    }
}