using edk.Fusc.Contracts;
using edk.Fusc.Core;
using edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace edk.ManagerFeatureToggles.API.Controllers
{
    public class FeatureTogglesController : BaseController
    {

        public FeatureTogglesController(IMediatorUseCase mediator) : base(mediator)
        {
        }

        [HttpGet(Name = "GetAllSystem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetAll()
            => (await _mediator.HandleAsync<GetAllFeaturesUseCase>(NoValue.Create)).ViewOutput;
    }


   
}