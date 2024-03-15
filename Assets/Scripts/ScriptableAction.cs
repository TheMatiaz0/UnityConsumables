using UnityEngine;

public abstract class ScriptableAction<T> : ScriptableObject, IContextAction<T> where T : class, IContext
{
    public abstract void Execute(T context);

    public void Execute(IContext context)
    {
        Execute(context as T);
    }
}
