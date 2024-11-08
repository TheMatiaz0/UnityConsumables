using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInventory", menuName = "Definitions/Inventory", order = 70)]
public class InventoryDefinition : ScriptableObject, IInventoryReader
{
    [SerializeField]
    private List<ItemDefinition> items;

    [SerializeField]
    private int maxItemAmount;

    public List<ItemDefinition> Items => items;
    public int MaxAmount => maxItemAmount;
    public int CurrentAmount => Items.Count;

    IReadOnlyList<ItemDefinition> IInventoryReader.Items => Items;
}
