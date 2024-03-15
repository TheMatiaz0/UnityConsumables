using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    [SerializeField]
    private InventorySlot slotPrefab;

    [SerializeField]
    private IInventoryReader inventoryReader;

    private void Awake()
    {
        // get data from InventoryDefinition
    }
}
