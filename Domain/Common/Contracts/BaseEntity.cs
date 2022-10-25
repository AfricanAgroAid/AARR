

namespace Domain.Common.Contracts;

public abstract class BaseEntity 
{
    protected string Id = Guid.NewGuid().ToString().Substring(0, 5);
}