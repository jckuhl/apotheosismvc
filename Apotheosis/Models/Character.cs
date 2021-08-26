using Apotheosis.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apotheosis.Models
{
    public class Character: MongoCustomObject
    {
        public Character()
        {
            CustomValues = new Dictionary<string, string>();
;       }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
        
        public string PlaceOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Species { get; set; }

        public string Race { get; set; }

        public string Sex { get; set; }

        public string Gender { get; set; }

        public string SexualOrientation { get; set; }

        public Alignment Alignment { get; set; }

        public string DateOfBirth { get; set; }

        public string Description { get; set; }

        public string Personality { get; set; }

        public string Biography { get; set; }

        //List<String>?
        public string Likes { get; set; }

        //List<String>?
        public string Dislikes { get; set; }

        public List<string> StoriesCharacterPresentIn { get; set; }

        public Universe Universe { get; set; }

        public Religion Religion { get; set; }

        public List<Character> Friends { get; set; }

        public List<Character> Enemies { get; set; }
    }
}