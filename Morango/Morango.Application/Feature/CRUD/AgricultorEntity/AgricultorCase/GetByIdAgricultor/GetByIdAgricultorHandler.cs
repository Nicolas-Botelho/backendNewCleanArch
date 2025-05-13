using AutoMapper;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;
using Morango.Application.Feature.CRUD.AgricultorEntity.Interface;
using Morango.Domain.Entities;
using Morango.Application.Common.UseCase.Get;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetById
{
    internal class GetByIdAgricultorHandler : GetByIdHandler<IAgricultorService, GetByIdAgricultorCommand, AgricultorRequestDTO, AgricultorResponseDTO, Agricultor>
    {
        public GetByIdAgricultorHandler(IAgricultorService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}