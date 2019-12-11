using Database.Interfaces;
using Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Databases
{
    public class MongoDatabases : IDatabase
    {
        public BsonDocument bsonDocument;
        private string _connections;
        public MongoDatabases()
        {
            _connections = "mongodb://localhost:27017";
        }
        public void AddtoDatabase(Region region)
        {
            var mongoClient = new MongoClient(_connections);
            var Mongodatabase = mongoClient.GetDatabase("Region");
            bsonDocument = new BsonDocument();
            bsonDocument.Add(new BsonElement("RegionId",region.RegionId.ToString()));
            bsonDocument.Add(new BsonElement("RegionName", region.RegionName.ToString()));

            bsonDocument.Add(new BsonElement("RegionNameLong",region.RegionNameLongitude.ToString()));
            bsonDocument.Add(new BsonElement("Latitude",region.Latitude));
            bsonDocument.Add(new BsonElement("Longitude", region.Longitude));
            bsonDocument.Add(new BsonElement("SubClassification",region.SubClassification));
            var collections = Mongodatabase.GetCollection<BsonDocument>("RegionData");
            collections.InsertOne(bsonDocument);



            
        }
    }
}
