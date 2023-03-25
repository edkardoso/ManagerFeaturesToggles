using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class UserGroup : BaseEntity
    {
        public string Name { get; set; }
        public List<string> UserTenantId { get; set; }
    }


}
