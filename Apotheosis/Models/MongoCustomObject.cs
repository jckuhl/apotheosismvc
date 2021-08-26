using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Apotheosis.Models
{
    public abstract class MongoCustomObject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired] //the account user who owns the object
        public string UserId { get; set; }

        public Dictionary<string, string> CustomValues { get; set; }
    }
}