public interface IContextAction
{
    void Execute(IContext context);
}

public interface IContextAction<T> : IContextAction where T : IContext
{
    void Execute(T context);
}
