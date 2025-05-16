using Morango.Domain.Entities;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;
using Morango.Application.Feature.BaseGetInterface;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.Interface
{
    public interface IAgricultorService : IBaseGetService<AgricultorRequestDTO, AgricultorResponseDTO, Agricultor>
    {
    }
}

