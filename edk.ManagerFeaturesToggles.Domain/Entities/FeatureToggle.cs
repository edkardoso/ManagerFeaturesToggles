using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class FeatureToggle : BaseEntity
    {
        protected FeatureToggle()
        {
            
        }

        public FeatureToggle(string name, int systemId, ValuesDataType dataType, ICollection<ValueOption> values)
        {
            Name = name;
            SystemId = systemId;
            DataType = dataType;
            Values = values;
        }

        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public int SystemId { get; set; }
        public virtual SystemApp System { get; set; } = null!;
        public virtual Tenant Tenant { get; set; } = null!;

        public int TenantId { get; set; }
        public ValuesDataType DataType { get; set; }

        public virtual ICollection<ValueOption>? Values { get; set; }
        public virtual ICollection<ValueSelect>? ValuesSelects { get; set; }
      
        public bool Enable { get; set; }
    }


}
