using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Persistence.MongoDb;
using Shared.Extensions;

namespace Persistence.Repository
{
    public class MongoRepository<T> where T : MongoDbEntity
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoClient _client;
        public MongoRepository(IOptions<MongoDbSettings> mongoDbSettings)
        {
            _client = new MongoClient(mongoDbSettings.Value.MongoDb);
            _database = _client.GetDatabase(mongoDbSettings.Value.MongoDbName);
        }
        public async Task<bool> InsertAsync(T entity, string collectionName)
        {
            try
            {
                var collection = _database.GetCollection<T>(collectionName);
                await collection.InsertOneAsync(entity);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public async Task<T> GetOneAsync(string name, string collectionName)
        {
            try
            {
                var collection = _database.GetCollection<T>(collectionName);
                var filter = Builders<T>.Filter.Where(x => x.Name.ToUpper() == name.ToUpper());
                var result = await collection.FindAsync(filter);
                return result.FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
