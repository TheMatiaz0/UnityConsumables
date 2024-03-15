public interface IInventoryWriter
{
    bool TryAddItem(ItemDefinition item);
    bool TryRemoveItem(ItemDefinition item);
}
