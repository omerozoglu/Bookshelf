
using Bookshelf.API.Domain.Concrete;

namespace Bookshelf.API.Entities.Concrete
{
    public class Log: EntityBase
    {
        public string Message { get; set; }
        public string Data { get; set; }
        public string Details { get; set; }
    }
}
