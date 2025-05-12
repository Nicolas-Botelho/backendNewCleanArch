using Morango.Domain.Entities;
using ConectaFapes.Common.Application.Interfaces.Services;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.Interface
{
    public interface IPropriedadeService : IBaseCrudService<PropriedadeRequestDTO, PropriedadeResponseDTO, Propriedade>
    {
    }
}
