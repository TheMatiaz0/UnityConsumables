using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour, IInventory
{
    [SerializeField]
    private InventoryDefinition inventory;

    private bool CanAddItem => inventory.CurrentAmount <= inventory.MaxAmount;

    public bool TryAddItem(ItemDefinition item)
    {
        if (!CanAddItem)
        {
            return false;
        }

        inventory.Items.Add(item);
        return true;
    }

    public bool TryRemoveItem(ItemDefinition item)
    {
        return inventory.Items.Remove(item);
    }
}
