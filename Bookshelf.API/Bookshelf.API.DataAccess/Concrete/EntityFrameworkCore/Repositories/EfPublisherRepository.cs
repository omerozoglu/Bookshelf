﻿using Bookshelf.API.DataAccess.Interfaces;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfPublisherRepository : EfGenericRepository<Publisher>, IPublisherDal
    {

    }
}
