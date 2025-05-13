using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Domain.Entities;
using Morango.Domain.Enums;
using ConectaFapes.Common.Infrastructure.Interfaces;
using Morango.Application.Common.UseCase.CRUD;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Update
{
    public class UpdatePropriedadeHandler : UpdateHandler<IPropriedadeService, UpdatePropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public UpdatePropriedadeHandler(IUnitOfWork unitOfWork, IPropriedadeService service, IMapper mapper) : base(unitOfWork, service, mapper) { }
    }
}