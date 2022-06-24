using Bookshelf.API.Entities.Concrete;
using Bookshelf.API.Entities.Concrete.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bookshelf.API.DataAccess.Concrete.MongoDB.Context
{
    public class MongoDBContext : IMongoLogDBContext
    {
        private IMongoDatabase _db { get; set; }
        private MongoClient _mongoClient { get; set; }
        public IClientSessionHandle Session { get; set; }
        public MongoDBContext(IOptions<Mongosettings> configuration)
        {
            _mongoClient = new MongoClient(configuration.Value.Connection);
            _db = _mongoClient.GetDatabase(configuration.Value.DatabaseName);
        }

        public IMongoCollection<Log> GetCollection<Book>(string name)
        {
            throw new NotImplementedException();
        }
    }
}
