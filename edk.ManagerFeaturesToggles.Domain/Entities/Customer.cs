using edk.ManagerFeaturesToggles.Domain.Entities.Base;

namespace edk.ManagerFeaturesToggles.Domain.Entities
{
    public class Customer : BaseEntity
    {
        protected Customer() { }

        public Customer(string name, string owner, string email, string login, string paswword)
        {
            Name = name;
            Owner = owner;
            Email = email;
            Login = login;
            Password = paswword;
        }

        public string Name { get;  }
        public string Owner { get;  }
        public string Email { get;  }
        public string Login { get;  }
        public string Password { get; private set; }
        public virtual ICollection<SystemApp>? Systems { get; set; } = new List<SystemApp>();
        public virtual ICollection<Tenant>? Tenants { get; set; } = new LinkedList<Tenant>();
    }


}
