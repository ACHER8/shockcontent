using System.Collections.Generic;
using ООО__Товары_для_животных_.Models;
using ООО__Товары_для_животных_.ViewModels;

namespace ООО__Товары_для_животных_.Interface
{
    public interface IManufacturerListDB
    {
        List<Manufacturer> ManufacturerList();
    }
}