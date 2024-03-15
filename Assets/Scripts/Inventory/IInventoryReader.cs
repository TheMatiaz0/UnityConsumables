using System.Collections.Generic;

public interface IInventoryReader
{
    IReadOnlyList<ItemDefinition> Items { get; }
}
