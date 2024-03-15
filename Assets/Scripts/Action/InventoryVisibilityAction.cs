using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInventoryVisibilityAction", menuName = "Definitions/Action/", order = 70)]
public class InventoryVisibilityAction : ScriptableAction<IUiContext>
{
    [SerializeField]
    private bool shouldActivate;

    public override void Execute(IUiContext context)
    {
        if (shouldActivate)
        {
            context.InventoryView.Activate();
        }
        else 
        {
            context.InventoryView.Deactivate();
        }
    }
}
