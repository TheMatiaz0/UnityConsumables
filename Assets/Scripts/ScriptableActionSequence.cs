using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewActionSequence", menuName = "Definitions/Action/Sequence", order = 70)]
public class ScriptableActionSequence : ScriptableObject, IAction
{
    [SerializeField]
    private ScriptableAction[] actions;

    public void Execute()
    {
        foreach (var action in actions)
        {
            action.Execute();
        }
    }
}
