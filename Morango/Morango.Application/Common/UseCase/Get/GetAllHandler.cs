using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Domain.BaseEntities;
using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Common.Interfaces;

namespace Morango.Application.Common.UseCase.Get
{
    public class GetAllHandler<IService, GetRequest, Request, Response, Entity> : IRequestHandler<GetRequest, ICollection<Response>>
        where Entity : BaseEntity
        where Response : BaseDto
        where GetRequest : IRequest<ICollection<Response>>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseGetService<Request, Response, Entity>
    {
        protected readonly IService _service;

        public GetAllHandler(IService service)
        {
            _service = service;
        }


        public async Task<ICollection<Response>> Handle(GetRequest getRequest, CancellationToken cancellationToken)
        {
            return await Task.Run(() => _service.GetAll(), cancellationToken);
        }
    }
}