using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

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


        public List<T> LoadRecords<T>(string collectionName)
        {
            var collection = database.GetCollection<T>(collectionName);

            return collection.Find(new BsonDocument()).ToList();
        }
    }

}
