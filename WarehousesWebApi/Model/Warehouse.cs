using System;
using System.Collections.Generic;

namespace WarehousesWebApi.Model;

public partial class Warehouse
{
    public int IdWarehouse { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<ProductWarehouse> ProductWarehouses { get; } = new List<ProductWarehouse>();
}
