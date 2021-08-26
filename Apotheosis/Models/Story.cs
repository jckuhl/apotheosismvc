using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apotheosis.Models
{
    public class Story : MongoCustomObject
    {
        public string Title { get; set; }

        public Universe Universe { get; set; }

        public List<Character> Cast { get; set; }

        public string Plot { get; set; }
    }
}