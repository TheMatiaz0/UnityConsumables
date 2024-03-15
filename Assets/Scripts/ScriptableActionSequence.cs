using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

[CreateAssetMenu(fileName = "NewActionSequence", menuName = "Definitions/Action/Sequence", order = 70)]
public class ScriptableActionSequence : ScriptableObject, IContextAction
{
    [SerializeField]
    private SerializableInterface<IContextAction>[] actions;

    public void Execute(IContext context)
    {
        foreach (var action in actions)
        {
            action.Value?.Execute(context);
        }
    }
}
