using Bookshelf.API.Business.Concrete;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Bookshelf.API.DataAccess.Concrete.MongoDB.Repositories;
using Bookshelf.API.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bookshelf.API.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped(typeof(IAuthorDal), typeof(EfAuthorRepository));
            services.AddScoped(typeof(IAuthorService), typeof(AuthorManager));

            services.AddScoped(typeof(IBookDal), typeof(EfBookRepository));
            services.AddScoped(typeof(IBookService), typeof(BookManager));

            services.AddScoped(typeof(IBookTransactionDal), typeof(EfBookTransactionRepository));
            services.AddScoped(typeof(IBookTransactionService), typeof(BookTransactionManager));

            services.AddScoped(typeof(IBookUserDal), typeof(EfBookUserRepository));
            services.AddScoped(typeof(IBookUserService), typeof(BookUserManager));

            services.AddScoped(typeof(IGenreDal), typeof(EfGenreRepository));
            services.AddScoped(typeof(IGenreService), typeof(GenreManager));

            services.AddScoped(typeof(IPublisherDal), typeof(EfPublisherRepository));
            services.AddScoped(typeof(IPublisherService), typeof(PublisherManager));

            services.AddScoped(typeof(IUserDal), typeof(EfUserRepository));
            services.AddScoped(typeof(IUserService), typeof(UserManager));

            services.AddScoped(typeof(IGenericMongoDal<>), typeof(MongoDBGenericRepository<>));
            services.AddScoped(typeof(IGenericMongoService<>), typeof(GenericMongoManager<>));

            services.AddScoped(typeof(ILogDal), typeof(LogRepository));
            services.AddScoped(typeof(ILogService), typeof(LogManager));
        }
    }
}
