using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemDefinition", menuName = "Definitions/Item", order = 70)]
public class ItemDefinition : ScriptableObject
{
    [SerializeField]
    private Sprite itemIcon;

    [SerializeField]
    private string itemName;

    [TextArea]
    [SerializeField]
    private string itemDescription;

    [SerializeField]
    private SerializableInterface<IContextAction<IItemUseContext>> useAction;

    public Sprite ItemIcon => itemIcon;
    public string ItemName => itemName;
    public string ItemDescription => itemDescription;
    public IContextAction<IItemUseContext> UseAction => useAction?.Value;

}
