using AutoMapper;
using Morango.Application.Feature.CRUD.AgricultorEntity.Interface;
using Morango.Domain.Entities;
using Morango.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Morango.Application.Common.Services;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.Service
{
    public class AgricultorService :
        BaseGetService<
            AgricultorRequestDTO,
            AgricultorResponseDTO,
            Agricultor,
            IAgricultorRepository>, IAgricultorService
    {

        public AgricultorService(IMediator mediator, IMapper mapper, IAgricultorRepository repository) : base(mediator, mapper, repository) { }

    }
}