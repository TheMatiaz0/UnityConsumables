using System.Collections;
using System.Collections.Generic;
using TNRD;
using UnityEngine;

[CreateAssetMenu(fileName = "NewActionSequence", menuName = "Definitions/Action/Sequence", order = 70)]
public class ScriptableActionSequence : ScriptableObject, IAction
{
    // [SerializeField]
    // private SerializableInterface<IContextAction<IContext>>[] actions;

    public void Execute()
    {
        /*
        foreach (var action in actions)
        {
            action.Value?.Execute();
        }
        */
    }
}
