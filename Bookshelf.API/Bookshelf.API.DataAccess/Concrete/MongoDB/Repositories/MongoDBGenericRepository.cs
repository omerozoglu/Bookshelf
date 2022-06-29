using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Domain.Interfaces;
using Bookshelf.API.Entities.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Bookshelf.API.DataAccess.Concrete.MongoDB.Repositories
{
    public class MongoDBGenericRepository<TEntity> : IGenericMongoDal<TEntity> where TEntity :  class, IEntity ,new()
    {

        protected readonly IMongoDBContext _mongoContext;
        protected IMongoCollection<TEntity> _dbCollection;

        public MongoDBGenericRepository(IMongoDBContext context)
        {
            _mongoContext = context;
            _dbCollection = (IMongoCollection<TEntity>?)_mongoContext.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task Create(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await _dbCollection.InsertOneAsync(obj);
        }

        public void DeleteAsync(string id)
        {
            var objectId = new ObjectId(id);
           _dbCollection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", objectId));
        }

        public async Task<TEntity> Get(string id)
        {
            var objectId = new ObjectId(id);

            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq("_id", objectId);

            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var all = await _dbCollection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
