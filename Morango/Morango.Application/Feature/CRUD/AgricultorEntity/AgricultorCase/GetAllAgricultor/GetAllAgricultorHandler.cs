using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;
using Morango.Application.Feature.CRUD.AgricultorEntity.Interface;
using Morango.Domain.Entities;
using Morango.Application.Feature.BaseGetCase;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetAll
{
    public class GetAllAgricultorHandler : GetAllHandler<IAgricultorService, GetAllAgricultorCommand, AgricultorRequestDTO, AgricultorResponseDTO, Agricultor>
    {
        public GetAllAgricultorHandler(IAgricultorService service) : base(service)
        {
        }
    }
}