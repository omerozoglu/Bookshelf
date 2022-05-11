using Bookshelf.API.Domain.Interfaces;

namespace Bookshelf.API.Domain.Concrete
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
