namespace Shared.Extensions
{
    /// <summary>
    /// It represents AppSettings values for MongoDb options.
    /// </summary>
    public class MongoDbSettings
    {
        /// <value>MongoDb server. </value>
        public string? MongoDb { get; set; }

        /// <value>DataBase Name </value>
        public string? MongoDbName { get; set; } 
    }
}
