using Bookshelf.API.Domain.Interfaces;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IGenericMongoDal<TEntity> where TEntity : class, IEntity, new()
    {
        Task Create(TEntity obj);
        void Update(TEntity obj);
        void DeleteAsync(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> Get();
    }
}
