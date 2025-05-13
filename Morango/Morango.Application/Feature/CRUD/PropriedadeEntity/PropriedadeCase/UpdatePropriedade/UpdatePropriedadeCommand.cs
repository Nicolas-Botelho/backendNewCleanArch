using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.Domain.Enums;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Update
{
    public record UpdatePropriedadeCommand(
      Guid Id,
      string Nome,
      string Distrito
    ) : IRequest<TResult<PropriedadeResponseDTO>>
    {

    }
}