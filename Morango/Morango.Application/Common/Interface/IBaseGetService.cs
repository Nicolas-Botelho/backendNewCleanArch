using ConectaFapes.Common.Domain;

namespace Morango.Application.Common.Interfaces
{
    public interface IBaseGetService<Request, Response, Entity>
    {
        ICollection<Response> GetAll();
        Response GetById(Guid id);

    }
}