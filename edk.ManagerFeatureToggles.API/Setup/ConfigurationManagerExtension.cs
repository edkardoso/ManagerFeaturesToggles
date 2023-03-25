using Microsoft.EntityFrameworkCore;

namespace edk.ManagerFeatureToggles.API.Setup
{
    public static class ConfigurationManagerExtension
    {
        public static string GetConnectionString(this ConfigurationManager configurationManager)
            => configurationManager.GetConnectionString("FeatureToggleDbContext") ?? throw new ArgumentException("Conecction string não encontrada.");
    }
}
