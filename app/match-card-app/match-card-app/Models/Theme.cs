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
            // Needed empty constructor
        }

        public Theme(string name)
        {
            Name = name;
        }

        public Theme(string name, List<Card> cards)
        {
            Name = name;
            Cards = cards;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
            Cards.Sort();
        }

        public bool RemoveCard(Card card) => Cards.Remove(card);

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

        /*public class ThemeConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(Tag);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                string name = (string)jo.GetValue("name");
                string cardsJson = (string)jo.GetValue("cards");
                List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(cardsJson, new Card.CardConverter());
                return new Theme(name, cards);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }*/
    }
}
