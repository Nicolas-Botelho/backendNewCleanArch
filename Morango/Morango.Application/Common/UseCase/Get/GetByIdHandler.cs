using AutoMapper;
using ConectaFapes.Common.Application.DTO;
using Morango.Application.Common.Interfaces;
using ConectaFapes.Common.Domain;
using ConectaFapes.Common.Domain.BaseEntities;
using MediatR;

namespace Morango.Application.Common.UseCase.Get
{
    public class GetByIdHandler<IService, GetRequest, Request, Response, Entity> : IRequestHandler<GetRequest, Response>
        where Entity : BaseEntity
        where Response : BaseDto
        where GetRequest : IRequest<Response>
        where Request : IRequest<TResult<Response>>
        where IService : IBaseGetService<Request, Response, Entity>
    {

        protected readonly IService _service;
        protected readonly IMapper _mapper;

        public GetByIdHandler(IService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);
            return await Task.Run(() => _service.GetById(entity.Id), cancellationToken);
        }
    }
}