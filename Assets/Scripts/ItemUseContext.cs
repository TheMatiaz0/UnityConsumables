using TNRD;
using UnityEngine;

public class ItemUseContext : MonoBehaviour, IItemUseContext
{
    [SerializeField]
    private SerializableInterface<IInventoryWriter> inventoryWriter;

    public IInventoryWriter InventoryWriter => inventoryWriter?.Value;
}
