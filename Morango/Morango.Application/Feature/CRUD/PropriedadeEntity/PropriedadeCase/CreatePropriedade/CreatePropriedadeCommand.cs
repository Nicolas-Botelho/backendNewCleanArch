using ConectaFapes.Common.Domain;
using MediatR;
using Morango.Domain.Enums;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Create
{
    public record CreatePropriedadeCommand(
      string? Nome,
      string? Distrito
    ) : IRequest<ApiResponse>;
}
