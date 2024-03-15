using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemUseContext : IContext
{
    IInventoryWriter InventoryWriter { get; }
}
