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
        private Config config;

        public FormMain()
        {
            InitializeComponent();

            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            config = Config.GetInstance();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ReloadThemesList();
        }

        private void ReloadThemesList()
        {
            lb_themes.Items.Clear();
            lb_themes.Items.AddRange(config.Themes.ToArray());
        }

        private void lb_themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? themeIndex = lb_themes.SelectedIndex;
            
            b_edit.Enabled = themeIndex >= 0;
            b_delete.Enabled = themeIndex >= 0;
            b_play.Enabled = themeIndex >= 0;
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            FormTheme configForm = new FormTheme();
            configForm.ShowDialog();
            ReloadThemesList();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            FormTheme configForm = new FormTheme(lb_themes.SelectedItem as Theme);
            configForm.ShowDialog();
            ReloadThemesList();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int themeIndex = lb_themes.SelectedIndex;
            string themeName = lb_themes.GetItemText(lb_themes.SelectedItem);
            DialogResult confirmation = MessageBox.Show("Tem a certeza que pretende apagar o tema " + themeName + "?", "Apagar tema", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                config.DeleteTheme(lb_themes.SelectedItem as Theme);
                ReloadThemesList();
            }
        }

        private void b_play_Click(object sender, EventArgs e)
        {
            // TODO: Play Game
        }
    }
}
