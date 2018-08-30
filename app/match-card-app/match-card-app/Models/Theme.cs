using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dino.Models
{
    public class Theme
    {
        [JsonProperty("theme")]
        public string Name { get; set; }
        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }

        public Theme()
        {
            Name = null;
            Cards = new List<Card>();
        }
        
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Theme)
            {
                return Name.Equals((obj as Theme).Name) &&
                    Cards.All((obj as Theme).Cards.Contains) &&
                    Cards.Count == (obj as Theme).Cards.Count;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = 1246274778;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Card>>.Default.GetHashCode(Cards);
            return hashCode;
        }
    }
}
