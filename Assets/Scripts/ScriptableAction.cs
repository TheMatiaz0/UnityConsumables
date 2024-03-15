using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableAction", menuName = "Definitions/Action/Single", order = 70)]
public abstract class ScriptableAction : ScriptableObject, IAction
{
    public abstract void Execute();
}
