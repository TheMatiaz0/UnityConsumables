public interface IContextAction<T> where T : IContext
{
    void Execute(T context);
}
