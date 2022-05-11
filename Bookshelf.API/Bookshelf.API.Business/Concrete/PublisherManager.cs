using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class PublisherManager : GenericManager<Publisher>, IPublisherService
    {
        public PublisherManager(IGenericDal<Publisher> genericDal) : base(genericDal)
        {
        }
    }
}
