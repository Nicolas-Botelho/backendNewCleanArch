using MediatR;
using ConectaFapes.Common.Domain;

namespace Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs
{
    public class PropriedadeRequestDTO : IRequest<TResult<PropriedadeResponseDTO>>
    {
        public Guid Id {get; set;}
        public string Nome { get; set; }
        public string Distrito { get; set; }


    }
}
