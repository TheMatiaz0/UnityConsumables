using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DebugLogAction", menuName = "Definitions/Action/DebugLog", order = 70)]
public class DebugLogAction : ScriptableAction<IContext>
{
    [TextArea]
    [SerializeField]
    private string message;

    public override void Execute(IContext context)
    {
        Debug.Log(message);
    }
}
