using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Domain.Enums;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Update
{
    public record UpdatePropriedadeCommand(
      Guid Id,
      string Nome,
      string Distrito
    ) : IRequest<ApiResponse>;
}