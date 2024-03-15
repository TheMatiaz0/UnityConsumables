using TNRD;
using UnityEngine;

public class InventoryView : MonoBehaviour, IActivable
{
    [SerializeField]
    private InventorySlot slotPrefab;

    [SerializeField]
    private Transform slotParent;

    [SerializeField]
    private SerializableInterface<IInventoryReader> inventoryReader;

    [SerializeField]
    private SerializableInterface<IActivable> inventoryViewActivable;

    [SerializeField]
    private ItemDetailsView itemDetails;

    [SerializeField]
    private SerializableInterface<IItemUseContext> context;

    public bool IsActive => inventoryViewActivable.Value.IsActive;

    public void Activate()
    {
        inventoryViewActivable.Value?.Activate();
        Refresh(inventoryReader.Value);
    }

    private void Refresh(IInventoryReader inventoryReader)
    {
        if (inventoryReader == null)
        {
            return;
        }

        CleanupItems();
        CreateItems(inventoryReader);
    }

    private void CleanupItems()
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }
    }

    private void CreateItems(IInventoryReader inventoryReader)
    {
        foreach (var itemDefinition in inventoryReader.Items)
        {
            var inventorySlot = Instantiate(slotPrefab, slotParent);
            inventorySlot.Refresh(itemDefinition);
            inventorySlot.OnSubmitEvent += OnSubmitItem;
            inventorySlot.OnSelectionChangedEvent += OnSelectionChanged;
        }
    }

    private void OnSelectionChanged(ItemDefinition item)
    {
    }

    private void OnSubmitItem(ItemDefinition item)
    {
        itemDetails.Refresh(item, context.Value);
        context.Value.SelectedItem = item;
    }

    public void Deactivate()
    {
        inventoryViewActivable.Value?.Deactivate();
        context.Value.SelectedItem = null;
        itemDetails.Refresh(null);
    }
}
