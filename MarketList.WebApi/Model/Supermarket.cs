using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MarketList.WebApi.Model {
    public class Supermarket
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string ProductName { get; set; }
    }
}