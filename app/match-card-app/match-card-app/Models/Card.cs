using dino.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dino.Models
{
    public class Card : IComparable
    {
        [JsonProperty("id")]
        public string Id { get; set;  }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tag")]
        public Tag Tag { get; set; }
        [JsonProperty("image")]
        public string ImageFile { get; set; }

        public Card()
        {
            Id = Guid.NewGuid().ToString();
            Name = null;
            Tag = null;
            ImageFile = null;
        }

        public override string ToString()
        {
            return Name ?? Tag.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                return Name.Equals((obj as Card).Name) &&
                    Tag.Equals((obj as Card).Tag) &&
                    ImageFile.Equals((obj as Card).ImageFile);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -64030534;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Tag>.Default.GetHashCode(Tag);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImageFile);
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            return ToString().CompareTo(obj.ToString());
        }
    }
}
