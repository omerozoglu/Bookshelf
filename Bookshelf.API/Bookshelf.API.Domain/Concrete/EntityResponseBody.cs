using Bookshelf.API.Domain.Enums;
namespace Bookshelf.API.Domain.Concrete
{
    public class EntityResponseBody<TEntity> where TEntity : class ,new()
    {
        public string? ReponseName { get; set; }
        public ResponseType? Status { get; set; }
        public string? Message { get; set; }
        public object? Content { get; set; }
    }
}