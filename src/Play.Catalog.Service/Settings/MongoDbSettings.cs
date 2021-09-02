namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }

        public int Port { get; init; }
        
        public string ConnectionString => $"mongodb+srv://admin_user:qDbKZsXJ0kCUuEpr@cluster0-aps5b.mongodb.net/cafe?retryWrites=true&w=majority";
    }
}