public interface IInventory
{
    bool TryAddItem(ItemDefinition item);
    bool TryRemoveItem(ItemDefinition item);
}
