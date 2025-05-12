using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Application.UseCase.BaseCase;
using Morango.Domain.Entities;
using Morango.Domain.Interfaces.Common;
using Morango.Domain.Enums;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete
{
    public class DeletePropriedadeHandler : DeleteHandler<IPropriedadeService, DeletePropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public DeletePropriedadeHandler(IUnitOfWork unitOfWork, IPropriedadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}