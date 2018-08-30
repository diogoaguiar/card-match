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
        private Card[] cards;
        private Tag[] availableTags;

        public FormTheme()
        {
            InitializeComponent();
            setCardFieldsEnabled(false);
            clearCardFields();

            availableTags = new Tag[]
            {
                new Tag("ABC"),
                new Tag("DEF"),
                new Tag("GHI"),
                new Tag("JKL"),
                new Tag("Named tag", "MNO")
            };

            lb_cards.Items.AddRange(cards);
        }

        private void loadImage(string path)
        {
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            clearCardFields();
            setCardFieldsEnabled(true);
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
        }

        private void b_delete_Click(object sender, EventArgs e)
        {

        }

        private void lb_cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_cards.SelectedItem != null)
            {
                b_edit.Enabled = true;
                b_delete.Enabled = true;
            }
            else
            {
                b_edit.Enabled = false;
                b_delete.Enabled = false;
            }
        }

        private void tb_theme_name_Leave(object sender, EventArgs e)
        {
            // Save theme name
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Validate theme name save
        }

        private void cd_cards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Repopulate fields
        }

        private void setCardFieldsEnabled(bool enabled)
        {
        }

        private void clearCardFields()
        {
        }

        private void b_save_card_Click(object sender, EventArgs e)
        {
            clearCardFields();
            setCardFieldsEnabled(false);
            MessageBox.Show("Alterações guardadas com sucesso", "Alterações guardadas");
        }

        private void b_cancel_card_Click(object sender, EventArgs e)
        {
            clearCardFields();
            setCardFieldsEnabled(false);
        }

        private void pb_image_preview_Click(object sender, EventArgs e)
        {

        }
    }
}
