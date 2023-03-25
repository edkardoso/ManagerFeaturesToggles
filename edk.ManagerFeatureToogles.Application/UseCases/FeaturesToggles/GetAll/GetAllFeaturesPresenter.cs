using edk.Fusc.Contracts;
using edk.Fusc.Core;
using edk.Fusc.Core.Presenters;
using edk.ManagerFeatureToogles.Application.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll
{

    public class GetAllFeaturesPresenter : PresenterBase<NoValue, List<FeatureToggleOutput>>
    {
        public override void OnResult(List<FeatureToggleOutput> output, IReadOnlyCollection<INotification> notifications, CancellationToken cancellationToken)
        {
            var result = new ResultApi(output, notifications);

            //result.AddLink(HateoasContants.SELF, $"https://localhost:7005/api/Users/{output.Id}");

            ViewOutput = new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }



        public override void OnError(List<Exception> exceptions, NoValue input)
        {
            var result = new ResultApi(input, exceptions);

            ViewOutput = new ObjectResult(result) { StatusCode = StatusCodes.Status500InternalServerError };
        }
    }
}
