namespace ConsoleApp.InheritedExample.Lib;

public class RepositoryBase<TContext> 
    where TContext : IContext
{
    private TContext _context;
    public string ContextName => _context.Name;
    public RepositoryBase(TContext context)
    {
        _context = context;
    }
}