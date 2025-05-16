using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Domain.Entities;
using Morango.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using Morango.Application.Feature.BaseCase;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Create
{
    public class CreatePropriedadeHandler : CreateHandler<IPropriedadeService, CreatePropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public CreatePropriedadeHandler(IUnitOfWork unitOfWork, IPropriedadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}