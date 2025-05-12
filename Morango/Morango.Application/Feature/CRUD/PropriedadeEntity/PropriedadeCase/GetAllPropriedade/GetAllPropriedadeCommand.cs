using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetAll
{
    public record GetAllPropriedadeCommand() : IRequest<IQueryable<PropriedadeResponseDTO>>;
}