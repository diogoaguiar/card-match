using dino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dino
{
    public partial class FormTheme : Form
    {
        private string documentsPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dino");
        private Theme originalTheme;
        private Theme theme;

        public FormTheme()
        {
            InitializeComponent();
            originalTheme = null;
            theme = new Theme();
        }

        public FormTheme(Theme theme)
        {
            InitializeComponent();
            originalTheme = theme;
            this.theme = CloneExtensions.CloneFactory.GetClone(theme);
        }

        private void FormTheme_Load(object sender, EventArgs e)
        {
            tb_theme_name.Text = theme.Name ?? "";
            ReloadCardList();
            LoadImage();
        }

        private void ReloadCardList()
        {
            lb_cards.Items.Clear();
            lb_cards.Items.AddRange(theme.Cards.ToArray());
        }

        private void LoadImage()
        {
            Card card = lb_cards.SelectedItem as Card;

            if (card == null || card.ImageFile == null)
            {
                pb_image_preview.ImageLocation = null;
                return;
            }

            pb_image_preview.ImageLocation = System.IO.Path.Combine(Config.GetInstance().ImagesBasePath, card.ImageFile);
        }

        private void lb_cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_edit.Enabled = b_delete.Enabled = lb_cards.SelectedItem != null;
            LoadImage();
        }

        private void tb_theme_name_TextChanged(object sender, EventArgs e)
        {
            theme.Name = tb_theme_name.Text;
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            Card selectedCard = lb_cards.SelectedItem as Card;
            DialogResult result = MessageBox.Show(this, "Tem a certeza que pretende apagar o cartão \"" + selectedCard + "\"?", "Apagar cartão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                theme.Cards.Remove(selectedCard);
                ReloadCardList();
                b_edit.Enabled = b_delete.Enabled = lb_cards.SelectedItem != null;
                LoadImage();
            }
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            if (theme.Cards.Count >= Config.GetInstance().Tags.Count)
            {
                MessageBox.Show(this, "Não existe mais cartões disponíveis.", "Erro", MessageBoxButtons.OK);
                return;
            }

            FormCard form = new FormCard(theme);
            form.ShowDialog();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            Card card = lb_cards.SelectedItem as Card;
            FormCard form = new FormCard(theme, card);
            form.ShowDialog();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (theme.Name == "" || theme.Name == null)
            {
                MessageBox.Show(this, "Tem que definir um título.", "Erro", MessageBoxButtons.OK);
                return;
            }

            if (theme.Cards.Count == 0)
            {
                MessageBox.Show(this, "Tem que adicionar pelo menos 1 cartão.", "Erro", MessageBoxButtons.OK);
                return;
            }

            if (!theme.Equals(originalTheme))
            {
                Config config = Config.GetInstance();
                if (originalTheme != null)
                {
                    config.DeleteTheme(originalTheme);
                }
                config.AddTheme(theme);
            }

            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
