using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Domain.Entities;
using Morango.Domain.Enums;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using ConectaFapes.Common.Infrastructure.Interfaces;
using Morango.Application.Common.UseCase.CRUD;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete
{
    public class DeletePropriedadeHandler : DeleteHandler<IPropriedadeService, DeletePropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public DeletePropriedadeHandler(IUnitOfWork unitOfWork, IPropriedadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}