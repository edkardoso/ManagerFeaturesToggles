using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class User: BaseEntity 
    {
        protected User()
        {
            
        }
        public User(string name, string userTenantId, int tenantId)
        {
            Name = name;
            UserTenantId = userTenantId;
            TenantId = tenantId;
        }

        public string Name { get; set; }
        public string UserTenantId { get; set; }
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }

        public virtual UserGroup UserGroup { get; set; }
        public int UserGroupId { get; set; }
    }


}
