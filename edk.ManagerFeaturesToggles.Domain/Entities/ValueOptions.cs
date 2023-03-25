using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class ValueOption : BaseEntity
    {
        protected ValueOption()
        {
            
        }
        public ValueOption(int featureToggleId, string value)
        {
            FeatureToggleId = featureToggleId;
            Value = value;
        }

        public int FeatureToggleId { get;  }
        public virtual FeatureToggle FeatureToggle { get;  }
        public string Value { get;  }

        public static List<ValueOption> CreateValuesBoolean(int featureToggleId)
            => new() { new(featureToggleId, true.ToString()), new(featureToggleId, false.ToString()) };
    }


}
