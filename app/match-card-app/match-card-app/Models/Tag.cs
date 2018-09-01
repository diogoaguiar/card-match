using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dino.Models
{
    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }

        public Tag()
        {
            Id = null;
            Label = null;
        }

        public override string ToString()
        {
            return Label ?? Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Tag)
            {
                return (obj as Tag).Id == Id;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Label);
            return hashCode;
        }
    }
}
