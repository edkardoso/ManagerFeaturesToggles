using edk.ManagerFeaturesToggles.Domain.Entities;
using edk.Tools;
using edk.Tools.NoIf.Boolean;

namespace edk.ManagerFeatureToggles.Infra.Data;

public static class FeatureToggleDbContextSeed
{
    public static void SeedData(this FeatureToggleDbContext context)
    {

        context.Customers.Any().IfFalse(() =>
            context.Customers.AddRange(new List<Customer> { 
                new Customer("Panasonic", "Kartic", "panasonic@email.com", "pana", "123456") 
            })
        );
        context.Tenants.Any().IfFalse(() =>
            context.Tenants.AddRange(new List<Tenant> { new("Pena Cloud", 1) })
        );

        context.Enviroments.Any().IfFalse(() =>
        {
            context.Enviroments.AddRange(new List<EnvironmentBuild>
            {
                new("DEV",EnviromentType.Development,true),
                new("QA",EnviromentType.Test,true),
                new("UAT", EnviromentType.Homologation, true),
                new("PROD", EnviromentType.Production, true),

            });

        });

        context.Systems.Any().IfFalse(() =>
        {
            context.Systems.AddRange(new List<SystemApp>
            {
                new("AM System", 1)


            });
        });

        context.FeatureToggles.Any().IfFalse(() =>
        {
            context.FeatureToggles.AddRange(new List<FeatureToggle>
            {
                new("ShowBarTotalCount", 1,ValuesDataType.Bool, ValueOption.CreateValuesBoolean(1))
            });
        });


        context.SaveChanges();
    }
}
