public interface IContextAction<in T> where T : IContext
{
    void Execute(T context);
}
