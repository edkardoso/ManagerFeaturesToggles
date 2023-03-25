using edk.Fusc.Core;
using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories;
using edk.ManagerFeaturesToggles.Domain.Contracts.Repositories.Generic;
using edk.ManagerFeaturesToggles.Domain.Entities;
using edk.ManagerFeatureToogles.Application.Mapper;

namespace edk.ManagerFeatureToogles.Application.UseCases.FeaturesToggles.GetAll
{

    public class GetAllFeaturesUseCase : UseCase<NoValue, List<FeatureToggleOutput>>
    {
        private readonly IGenericRepository<FeatureToggle> _repository;

        protected override string NameUseCase => "GetAllFeaturesUserUseCase";

        public GetAllFeaturesUseCase(IUnitOfWork unitOfWork)
        {
            _repository = (IGenericRepository<FeatureToggle>)unitOfWork.Repository.Get<IFeatureToggleRepository>();
        }

        public override async Task<List<FeatureToggleOutput>> OnExecuteAsync(NoValue input, CancellationToken cancellationToken)
            => (await _repository.SearchAsync(f => !f.Deleted && f.Enable))
                                .Match(some: (collection) => collection.ToOutput(),
                                        none: () => new List<FeatureToggleOutput>());
    }
}
