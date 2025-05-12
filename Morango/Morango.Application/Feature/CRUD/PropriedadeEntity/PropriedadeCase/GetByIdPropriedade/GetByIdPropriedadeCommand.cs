using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetById
{
    public record GetByIdPropriedadeCommand(Guid Id) : IRequest<IQueryable<PropriedadeResponseDTO>>
    {
    }
}