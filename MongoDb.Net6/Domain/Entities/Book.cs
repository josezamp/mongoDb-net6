using Persistence.MongoDb;

namespace Domain.Entities
{
    public class Book : MongoDbEntity
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Language { get; set; }

    }
}
