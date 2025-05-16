using ConectaFapes.Common.Domain;

namespace Morango.Application.Feature.BaseGetInterface
{
    public interface IBaseGetService<Request, Response, Entity>
    {
        ICollection<Response> GetAll();
        Response GetById(Guid id);

    }
}