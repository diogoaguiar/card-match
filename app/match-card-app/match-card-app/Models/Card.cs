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
    public class Card
    {
        [JsonProperty("id")]
        public int Id { get; set;  }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tag")]
        public Tag Tag { get; set; }
        [JsonProperty("image")]
        public string ImagePath { get; set; }

        public Card()
        {
            // Needed empty constructor
        }

        public Card(int id, string name, Tag tag, string imagePath)
        {
            Id = id;
            Name = name;
            Tag = tag;
            ImagePath = imagePath;
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
                    ImagePath.Equals((obj as Card).ImagePath);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -64030534;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Tag>.Default.GetHashCode(Tag);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImagePath);
            return hashCode;
        }
    }
}
