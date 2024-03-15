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
    private SerializableInterface<IActivable> view;

    [SerializeField]
    private ItemDetailsView itemDetails;

    [SerializeField]
    private SerializableInterface<IContext> context;

    public bool IsActive => view.Value.IsActive;

    public void Activate()
    {
        view.Value?.Activate();
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
        itemDetails.Refresh(item);
    }

    public void Deactivate()
    {
        view.Value?.Deactivate();
        itemDetails.Refresh(null);
    }
}
