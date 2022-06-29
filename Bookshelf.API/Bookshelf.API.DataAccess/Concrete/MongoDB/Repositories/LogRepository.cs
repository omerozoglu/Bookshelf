using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Concrete.MongoDB.Repositories
{
    public class LogRepository : MongoDBGenericRepository<Log>,ILogDal
    {
        public LogRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
