using dino.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dino
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string tagsJson = Properties.Settings.Default.tags;
            string themesJson = Properties.Settings.Default.themes;
            List<Tag> tags = JsonConvert.DeserializeObject<List<Tag>>(tagsJson);
            JArray themesUncasted = JsonConvert.DeserializeObject<JArray>(themesJson);
            List<Theme> themes = JsonConvert.DeserializeObject<List<Theme>>(themesJson);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        private void lb_themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? themeIndex = lb_themes.SelectedIndex;

            // Set buttons status
            b_edit.Enabled = themeIndex >= 0;
            b_delete.Enabled = themeIndex >= 0;
            b_play.Enabled = themeIndex >= 0;
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            FormTheme configForm = new FormTheme();
            configForm.ShowDialog();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            FormTheme configForm = new FormTheme();
            configForm.ShowDialog();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int themeIndex = lb_themes.SelectedIndex;
            string themeName = lb_themes.GetItemText(lb_themes.SelectedItem);
            DialogResult confirmation = MessageBox.Show("Tem a certeza que pretende apagar o tema " + themeName + "?", "Apagar tema", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                // Delete item
            }
        }

        private void b_play_Click(object sender, EventArgs e)
        {
            // Play Game
        }
    }
}
