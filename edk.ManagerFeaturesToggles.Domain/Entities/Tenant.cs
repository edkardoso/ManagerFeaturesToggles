using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class Tenant : BaseEntity
    {
        protected Tenant(){}
        public Tenant(string name, int customerId)
        {
            Name = name;
            CustomerId = customerId;
        }

        public string Name { get; set; }
        public bool Enable { get; private set; } = false;
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<FeatureToggle>? FeatureToggles { get; set; }

        public virtual ICollection<AccessSystem>? AccessSystems { get; set; } = null;
    }


}
