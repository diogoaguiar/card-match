using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dino.Models
{
    public class Config
    {
        private static Config instance;
        public List<Tag> Tags { get; }
        public List<Theme> Themes { get; }
        public string ImagesBasePath { get; }
        public int NextSlideDelay { get; }

        private Config()
        {
            Tags = new List<Tag>();
            Themes = new List<Theme>();
            LoadTags();
            LoadThemes();
            ImagesBasePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dino\\pictures");
            NextSlideDelay = Properties.Settings.Default.next_slide_delay;
        }

        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }

            return instance;
        }

        private void LoadTags()
        {
            string json = Properties.Settings.Default.tags;
            Tags.Clear();
            Tags.AddRange(JsonConvert.DeserializeObject<List<Tag>>(json));
        }

        private void LoadThemes()
        {
            string json = Properties.Settings.Default.themes;
            Themes.Clear();
            Themes.AddRange(JsonConvert.DeserializeObject<List<Theme>>(json));
        }

        private void SaveTags()
        {
            string json = JsonConvert.SerializeObject(Tags);
            Properties.Settings.Default.tags = json;
            Properties.Settings.Default.Save();
        }

        private void SaveThemes()
        {
            string json = JsonConvert.SerializeObject(Themes);
            Properties.Settings.Default.themes = json;
            Properties.Settings.Default.Save();
        }

        public void AddTheme(Theme theme)
        {
            Themes.Add(theme);
            SaveThemes();
        }

        public bool DeleteTheme(Theme theme)
        {
            bool deleted = Themes.Remove(theme);
            if (deleted)
            {
                SaveThemes();
            }

            return deleted;
        }

        public void AddTag()
        {
            // TODO
            throw new NotImplementedException();
        }

        public void DeleteTag()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
