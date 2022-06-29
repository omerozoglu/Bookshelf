using Bookshelf.API.Entities.Concrete;
using System.Linq.Expressions;

namespace Bookshelf.API.Business.Interfaces
{
    public interface ILogService: IGenericMongoService<Log>
    {
    }
}
