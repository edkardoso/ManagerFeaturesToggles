using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class AccessSystem : BaseEntity
    {
        protected AccessSystem() { }

        public AccessSystem(int tenantId, int environmentId, int systemId, string accessToken)
        {
            TenantId = tenantId;
            EnvironmentId = environmentId;
            SystemId = systemId;
            AccessToken = accessToken;
        }

        public int TenantId { get; set; }
        public int EnvironmentId { get; set; }
        public int SystemId { get; set; }
        public string AccessToken { get;  }
        public DateTime? ExpirationDate { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual EnvironmentBuild Environment { get; set; }
        public virtual SystemApp System { get; set; }
    }


    public class ValueSelect : BaseEntity
    {
        protected ValueSelect() { }

        public ValueSelect(string value, int featureToggleId, int tenantId, int enviromentId)
        {
            Value = value;
            FeatureToggleId = featureToggleId;
            TenantId = tenantId;
            EnviromentId = enviromentId;
        }

        public string Value { get; private set; }
        public int FeatureToggleId { get;  }
        public int TenantId { get;  }
        public int EnviromentId { get;  }
        public virtual FeatureToggle FeatureToggle { get;  }
        public virtual Tenant Tenant { get;  }
        public virtual EnvironmentBuild Enviroment { get;  }
        public virtual ICollection<UserGroup>? UserGroups { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate {  get ; private set; }
        public bool Enable { get; private set; } = false;
    }


}
