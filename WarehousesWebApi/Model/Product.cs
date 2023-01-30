using System;
using System.Collections.Generic;

namespace WarehousesWebApi.Model;

public partial class Product
{
    public int IdProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<ProductWarehouse> ProductWarehouses { get; } = new List<ProductWarehouse>();
}
