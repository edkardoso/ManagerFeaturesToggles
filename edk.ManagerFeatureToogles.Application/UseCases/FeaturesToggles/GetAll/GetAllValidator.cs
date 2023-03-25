using edk.Fusc.Contracts;
using edk.Fusc.Core;
using edk.Fusc.Core.Validators;

namespace edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll
{
    public class GetAllValidator : IUseCaseValidator<NoValue>
    {
        public IReadOnlyCollection<INotification> Validate(NoValue input)
        {
            return new List<INotification>();
        }
    }
}
