using MongoDB.Bson;


namespace Persistence.MongoDb
{
    /// <summary>
    /// Contains MongoDb Entities common properties.
    /// All Mongo Entities should inhetir from this class.
    /// </summary>
    public class MongoDbEntity
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
    }
}
