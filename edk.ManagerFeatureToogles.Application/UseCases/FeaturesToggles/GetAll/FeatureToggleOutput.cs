using edk.ManagerFeaturesToggles.Domain.Entities;

namespace edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll
{
    public record FeatureToggleOutput(int Id
        , string Name
        , string Description
        , string DataType
        , List<string>? Options
        , string System
        , bool Enable
        , string Tenant)
    {

    }
}
