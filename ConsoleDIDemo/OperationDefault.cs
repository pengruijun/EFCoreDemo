using ConsoleDIDemo.Interfaces;

namespace ConsoleDIDemo;

public class OperationDefault : ITransientOperation, IScopedOperation, ISingletonOperation
{
    public string OperationId { get; } = Guid.NewGuid().ToString();
}