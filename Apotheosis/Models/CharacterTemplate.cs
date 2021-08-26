using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apotheosis.Models
{
    
    /// <summary>
    /// User created template of fields added to characters
    /// </summary>
    public class CharacterTemplate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}