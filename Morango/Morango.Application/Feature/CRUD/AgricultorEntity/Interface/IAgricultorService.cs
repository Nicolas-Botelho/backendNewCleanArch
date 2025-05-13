using Morango.Domain.Entities;
using Morango.Application.Common.Interfaces;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.Interface
{
    public interface IAgricultorService : IBaseGetService<AgricultorRequestDTO, AgricultorResponseDTO, Agricultor>
    {
    }
}

