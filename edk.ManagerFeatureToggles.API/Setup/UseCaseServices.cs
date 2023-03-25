using edk.Fusc.Core.Mediator;
using edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll;

namespace edk.ManagerFeatureToggles.API.Setup
{
    public static class UseCaseServices
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddFusc(mediator =>
            {
                mediator.Services.AddScoped<GetAllFeaturesUseCase, GetAllValidator, GetAllFeaturesPresenter>();

                mediator.Builder();
            });

            
            return services;
        }

    }
}
