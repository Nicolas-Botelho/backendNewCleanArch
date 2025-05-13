using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Domain.Enums;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete
{
    public record DeletePropriedadeCommand(Guid Id) : IRequest<TResult<PropriedadeResponseDTO>>
    {
    }
}