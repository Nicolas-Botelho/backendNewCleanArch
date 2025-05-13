using MediatR;
using ConectaFapes.Common.Domain;

namespace Morango.Application.Feature.CRUD.AgricultorEntity.DTOs
{
    public class AgricultorRequestDTO : IRequest<TResult<AgricultorResponseDTO>>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Distrito { get; set; }


    }
}
