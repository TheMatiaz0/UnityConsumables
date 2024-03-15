using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

public class UiContext : MonoBehaviour, IUiContext
{
    [SerializeField]
    private SerializableInterface<IActivable> inventoryView;

    public IActivable InventoryView => inventoryView?.Value;
}
