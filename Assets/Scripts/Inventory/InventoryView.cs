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

#if UNITY_EDITOR

    [Header("Editor Debug")]
    [SerializeField]
    private SerializableInterface<IInventoryReader> editorInventoryReader;

#endif

    public bool IsActive => view.Value.IsActive;

    public void Activate()
    {
        view.Value?.Activate();
        CreateItems(inventoryReader.Value);
    }

    private void CreateItems(IInventoryReader inventoryReader)
    {
        if (inventoryReader == null)
        {
            return;
        }

        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }

        foreach (var itemDefinition in inventoryReader.Items)
        {
            var inventorySlot = Instantiate(slotPrefab, slotParent);
            inventorySlot.Refresh(itemDefinition);
        }
    }

    public void Deactivate()
    {
        view.Value?.Deactivate();
    }

#if UNITY_EDITOR

    [ContextMenu("Refresh Editor Items")]
    private void OnValidate()
    {
        CreateItems(editorInventoryReader.Value);
    }

#endif
}
