using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Application.Common.UseCase;
using Morango.Domain.Entities;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetAll
{
    public class GetAllPropriedadeHandler : GetAllHandler<IPropriedadeService, GetAllPropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public GetAllPropriedadeHandler(IPropriedadeService service) : base(service)
        {
        }
    }
}