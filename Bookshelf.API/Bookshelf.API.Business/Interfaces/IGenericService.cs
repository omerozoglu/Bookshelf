using Bookshelf.API.Entities.Interfaces;

namespace Bookshelf.API.Business.Interfaces
{
    public interface IGenericService<T> where T: class, ITable,new()
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
        T GetById(int id);
        List<T> GetAll();
    }
}
