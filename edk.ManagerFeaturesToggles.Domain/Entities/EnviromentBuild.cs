using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class EnvironmentBuild : BaseEntity
    {
        protected EnvironmentBuild()
        {
            
        }
        public EnvironmentBuild(string name, EnviromentType type, bool enable)
        {
            Name = name;
            Type = type;
            Enable = enable;
        }

        public string Name { get;  }
        public EnviromentType Type { get;  }
        public bool Enable { get;  }

        public virtual ICollection<AccessSystem>? AccessSystems { get; set; } = new List<AccessSystem>();

    }


}
