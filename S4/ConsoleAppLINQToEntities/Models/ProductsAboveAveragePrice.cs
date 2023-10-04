using System;
using System.Collections.Generic;

namespace ConsoleAppLINQToEntities.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
