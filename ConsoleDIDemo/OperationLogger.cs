using ConsoleDIDemo.Interfaces;

namespace ConsoleDIDemo;

public class OperationLogger
{
    private readonly ITransientOperation _transientOperation;
    private readonly IScopedOperation _scopedOperation;
    private readonly ISingletonOperation _singletonOperation;

    public OperationLogger(
        ITransientOperation transientOperation,
        IScopedOperation scopedOperation,
        ISingletonOperation singletonOperation)
    {
        _transientOperation = transientOperation;
        _scopedOperation = scopedOperation;
        _singletonOperation = singletonOperation;
    }

    public void Operations(string scope)
    {
        LogOperation(_transientOperation, scope, "transition");
        LogOperation(_scopedOperation, scope, "scoped");
        LogOperation(_singletonOperation, scope, "singleton");
    }

    private void LogOperation<T>(T operation, string scope, string message)
        where T : IOperation =>
        Console.WriteLine($"{scope}: {typeof(T).Name,-19} [ {operation.OperationId}...{message,-23}]");
}