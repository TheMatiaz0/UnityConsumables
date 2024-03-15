using TNRD;
using UnityEngine;

public class ItemUseContext : MonoBehaviour, IItemUseContext
{
    [SerializeField]
    private SerializableInterface<IInventoryWriter> inventoryWriter;
    [SerializeField]
    private VFXSystem vfxSystem;

    public ItemDefinition SelectedItem { get; set; }
    public IInventoryWriter InventoryWriter => inventoryWriter?.Value;
    public VFXSystem VFXSystem => vfxSystem;
}
