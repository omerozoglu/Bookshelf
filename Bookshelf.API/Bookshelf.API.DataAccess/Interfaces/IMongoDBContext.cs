using Bookshelf.API.Entities.Concrete;
using MongoDB.Driver;

namespace Bookshelf.API.DataAccess.Interfaces
{
    public interface IMongoDBContext
    {
        IMongoCollection<Log> GetCollection<Log>(string name);
    }
}
