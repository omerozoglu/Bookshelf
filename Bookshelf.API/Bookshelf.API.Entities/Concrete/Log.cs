using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bookshelf.API.Entities.Concrete
{
    public class Log
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedUserId { get; set; }
    }
}
