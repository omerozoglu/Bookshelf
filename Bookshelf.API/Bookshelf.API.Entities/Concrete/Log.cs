using Bookshelf.API.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bookshelf.API.Entities.Concrete
{
    public class Log : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedUserId { get; set; }
    }
}
