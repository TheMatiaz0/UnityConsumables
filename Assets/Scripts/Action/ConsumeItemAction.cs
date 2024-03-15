using UnityEngine;

[CreateAssetMenu(fileName = "NewConsumeItemAction", menuName = "Definitions/Action/Consume", order = 70)]
public class ConsumeItemAction : ScriptableAction<IItemUseContext>
{
    [Header("Optional")]
    [SerializeField]
    private ItemDefinition itemToRemove;

    public override void Execute(IItemUseContext context)
    {
        context.InventoryWriter.TryRemoveItem(itemToRemove == null ? context.SelectedItem : itemToRemove);
    }
}
