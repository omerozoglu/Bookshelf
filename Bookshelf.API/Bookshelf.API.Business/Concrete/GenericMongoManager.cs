using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Domain.Interfaces;


namespace Bookshelf.API.Business.Concrete
{
    public class GenericMongoManager<TEntity> : IGenericMongoService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IGenericMongoDal<TEntity> _genericDal;

        public GenericMongoManager(IGenericMongoDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task Create(TEntity obj)
        {
          await _genericDal.Create(obj);
        }

        public void DeleteAsync(string id)
        {
           _genericDal.DeleteAsync(id);
        }

        public async Task<TEntity> Get(string id)
        {
            return await _genericDal.Get(id);
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            return await _genericDal.Get();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
