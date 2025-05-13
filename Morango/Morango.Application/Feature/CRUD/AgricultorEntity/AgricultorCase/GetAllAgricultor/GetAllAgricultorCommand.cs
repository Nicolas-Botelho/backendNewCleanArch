using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetAll
{
    public record GetAllAgricultorCommand() : IRequest<ICollection<AgricultorResponseDTO>>;
}