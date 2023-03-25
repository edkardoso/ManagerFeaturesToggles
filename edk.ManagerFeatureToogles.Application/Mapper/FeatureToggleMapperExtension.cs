using edk.ManagerFeaturesToggles.Domain.Entities;
using edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll;

namespace edk.ManagerFeatureToogles.Application.Mapper
{
    internal static class FeatureToggleMapperExtension
    {
        public static FeatureToggleOutput ToOutput(this FeatureToggle featureToggle)
            => new(featureToggle.Id
                , featureToggle.Name
                , featureToggle.Description
                , featureToggle.DataType.ToString().ToLower()
                , featureToggle.Values?.Select(v=> v.Value.ToLower()).ToList()
                , featureToggle.System.Name
                , featureToggle.Enable
                , featureToggle.Tenant.Name);

        public static List<FeatureToggleOutput> ToOutput(this List<FeatureToggle> featureToggleCollection)
        {
            var result = new List<FeatureToggleOutput>();
            featureToggleCollection.ForEach(featureToggle => result.Add(featureToggle.ToOutput()));
            return result;

        }
    }
}
