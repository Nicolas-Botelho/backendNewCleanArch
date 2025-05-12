using ConectaFapes.Common.Domain;
using MediatR;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete
{
    public record DeletePropriedadeCommand(Guid Id) : IRequest<ApiResponse>
    {
    }
}