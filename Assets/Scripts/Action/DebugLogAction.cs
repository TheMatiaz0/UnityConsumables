using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DebugLogAction", menuName = "Definitions/Action/DebugLog", order = 70)]
public class DebugLogAction : ScriptableAction<IItemUseContext>
{
    [TextArea]
    [SerializeField]
    private string message;

    public override void Execute(IItemUseContext context)
    {
        Debug.Log(message);
    }
}
