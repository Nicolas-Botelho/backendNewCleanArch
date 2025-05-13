using AutoMapper;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Application.Feature.CRUD.PropriedadeEntity.Interface;
using Morango.Domain.Entities;
using Morango.Application.Common.UseCase.CRUD;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetById
{
    internal class GetByIdPropriedadeHandler : GetByIdHandler<IPropriedadeService, GetByIdPropriedadeCommand, PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
        public GetByIdPropriedadeHandler(IPropriedadeService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}