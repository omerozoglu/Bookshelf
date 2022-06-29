using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class LogManager : GenericMongoManager<Log>, ILogService
    {
        public LogManager(IGenericMongoDal<Log> genericDal) : base(genericDal)
        {
        }
    }
}
