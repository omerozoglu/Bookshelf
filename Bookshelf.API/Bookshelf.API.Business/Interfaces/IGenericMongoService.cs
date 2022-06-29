using Bookshelf.API.Domain.Interfaces;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IGenericMongoService<TEntity> where TEntity : class, IEntity, new()
    {
        Task Create(TEntity obj);
        void Update(TEntity obj);
        void DeleteAsync(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> Get();
    }
}
