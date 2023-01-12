using System;
using System.Collections.Generic;

namespace ClothingStore.DbEntities;

public partial class Clothers
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }
}
