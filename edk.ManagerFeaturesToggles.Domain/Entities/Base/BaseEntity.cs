using edk.ManagerFeaturesToggles.Domain.Contracts.Common;

namespace edk.ManagerFeaturesToggles.Domain.Entities.Base
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public bool Deleted { get; protected set; }
    }


}


