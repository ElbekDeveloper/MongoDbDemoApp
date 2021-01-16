using MongoDB.Driver;

namespace MongoDbDemo
{
    public class MongoCrud
    {
        private IMongoDatabase database;

        public MongoCrud(string databaseName)
        {

            var client = new MongoClient("mongodb+srv://m001-student:m001-mongodb-basics@sandbox.yzrs7.mongodb.net/ExadelBonusPlus?retryWrites=true&w=majority");
            database = client.GetDatabase(databaseName);

        }

        public void InsertRecord<T>(string collectionName, T record)
        {
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(record);
        }

    }

}
