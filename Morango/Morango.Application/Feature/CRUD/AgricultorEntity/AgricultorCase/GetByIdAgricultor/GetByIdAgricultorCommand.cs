using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetById
{
    public record GetByIdAgricultorCommand(Guid Id) : IRequest<AgricultorResponseDTO>
    {
    }
}