using AutoMapper;
using AutoMapper.QueryableExtensions;
using Morango.Application.Common.Interfaces;

using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.DTO;
using ConectaFapes.Common.Domain.BaseEntities;
using ConectaFapes.Common.Infrastructure.Interfaces;

namespace Morango.Application.Common.Services
{
    public class BaseGetService<Request, Response, Entity, Repository> : IBaseGetService<Request, Response, Entity>
       where Entity : BaseEntity
       where Response : BaseDto
       where Repository : IBaseRepository<Entity>
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;
        protected readonly Repository _repository;

        public BaseGetService(IMediator mediator, IMapper mapper, Repository repository)
        {
            _mediator = mediator;
            _mapper = mapper;
            _repository = repository;
        }

        //public virtual async Task<IQueryable<Response>> GetAll()
        //{
        //    var result = _repository.GetAll();
        //    var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider);
        //    return response;
        //}

        public ICollection<Response> GetAll()
        {
            var result = _repository.GetAll();
            var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider);
            return response;
        }

        //public virtual async Task<IQueryable<Response>> GetById(Guid id)
        //{
        //    var result = _repository.GetById(id);
        //    var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider);
        //    return response;
        //}

        public Response GetById(Guid id)
        {
            var result = _repository.GetById(id);
            var response = result.ProjectTo<Response>(_mapper.ConfigurationProvider);
            return response;
        }
    }
}