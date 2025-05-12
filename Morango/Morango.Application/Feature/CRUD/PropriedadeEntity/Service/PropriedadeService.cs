using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Domain.Entities;
using Morango.Domain.Interfaces.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ConectaFapes.Common.Application.Services.BaseCrudService;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.Service
{
    public class PropriedadeService :
        BaseCrudService<
            PropriedadeRequestDTO,
            PropriedadeResponseDTO,
            Propriedade,
            IPropriedadeRepository>, IPropriedadeService
    {

        public PropriedadeService(IMediator mediator, IMapper mapper, IPropriedadeRepository repository) : base(mediator, mapper, repository) { }

    }
}
