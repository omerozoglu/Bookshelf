using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Business.Concrete
{
    public class GenreManager : GenericManager<Genre>, IGenreService
    {
        public GenreManager(IGenericDal<Genre> genericDal) : base(genericDal)
        {
        }
    }
}
