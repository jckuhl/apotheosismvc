using Apotheosis.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Apotheosis.Services
{
    public class CharacterService
    {
        private readonly IMongoCollection<Character> _characters;
        private static CharacterService service;

        private CharacterService()
        {
            var client = new MongoClient("mongodb+srv://admin:test123@apotheosis.fciw6.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("Apotheosis");

            _characters = database.GetCollection<Character>("Characters");
        }

        public static CharacterService GetCharacterService()
        {
            if(service == null)
            {
                service = new CharacterService();
                return  service;
            }
            return service;
        }

        public List<Character> Get()
        {
            return _characters.Find(character => true).ToList();
        }

        public Character Get(string id)
        {
            return _characters.Find(character => character.Id == id).FirstOrDefault();
        }

        public Character Create(Character character)
        {
            _characters.InsertOne(character);
            return character;
        }
    }
}