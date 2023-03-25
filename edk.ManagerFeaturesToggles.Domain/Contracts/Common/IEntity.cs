namespace edk.ManagerFeaturesToggles.Domain.Contracts.Common;

public interface IEntity
{
    int Id { get; }
    bool Deleted { get; }
    public DateTime CreatedAt { get;  }
    public DateTime UpdatedAt { get; }

}
