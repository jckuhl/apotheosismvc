using Apotheosis.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Apotheosis.Services
{
    public class CharacterService : IService<Character>
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

        public Character Get(Expression expression)
        {
            return (Character)_characters.Find((FilterDefinition<Character>)expression);
        }

        public Character Update(Character character)
        {
            throw new NotImplementedException();
        }

        public Character Delete(Character character)
        {
            throw new NotImplementedException();
        }

        public Character Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Character Delete(object querey)
        {
            throw new NotImplementedException();
        }
    }
}