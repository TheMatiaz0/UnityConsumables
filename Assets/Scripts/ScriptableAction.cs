using UnityEngine;

public abstract class ScriptableAction<T> : ScriptableObject, IContextAction<T> where T : IContext
{
    public abstract void Execute(T context);
}
