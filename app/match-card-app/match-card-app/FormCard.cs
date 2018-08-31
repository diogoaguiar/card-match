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
    public partial class FormCard : Form
    {
        private Theme theme;
        private Card originalCard;
        private Card card;

        public FormCard(Theme theme)
        {
            InitializeComponent();
            this.theme = theme;
            card = new Card();
        }

        public FormCard(Theme theme, Card card)
        {
            InitializeComponent();
            this.theme = theme;
            originalCard = card;
            this.card = CloneExtensions.CloneFactory.GetClone(card);
        }

        private void FormCard_Load(object sender, EventArgs e)
        {
            tb_name.Text = card.Name ?? "";
            Config config = Config.GetInstance();
            List<Tag> availableTags = config.Tags.FindAll(t => theme.Cards.Find(c => c.Tag.Equals(t)) == null);
            if (card.Tag != null)
            {
                cb_tag.Items.Add(card.Tag);
            }
            cb_tag.Items.AddRange(availableTags.ToArray());
            cb_tag.SelectedIndex = 0;
            if (card.Name != null)
            {
                l_image_name.Text = "";
                pb_image_preview.ImageLocation = System.IO.Path.Combine(config.ImagesBasePath, card.ImageFile);
            }
        }

        private void b_image_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd_image.ShowDialog();

            if (result == DialogResult.OK)
            {
                string imageFile = System.IO.Path.GetFileName(ofd_image.FileName);
                card.ImageFile = imageFile;
                l_image_name.Text = imageFile;
                pb_image_preview.ImageLocation = ofd_image.FileName;
                card.ImageFile = imageFile;
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (originalCard == null || (!originalCard.Equals(card) && !card.ImageFile.Equals(originalCard.ImageFile)))
            {
                card.ImageFile = CopyToPicturesFolder(ofd_image.FileName);
                //System.IO.File.Delete(System.IO.Path.Combine(Config.GetInstance().ImagesBasePath, originalCard.ImageFile));
            }

            Close();
        }

        private string CopyToPicturesFolder(string sourceFile)
        {
            string targetPath = Config.GetInstance().ImagesBasePath;
            string targetFileName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_" + System.IO.Path.GetFileName(sourceFile);
            string targetFile = System.IO.Path.Combine(targetPath, targetFileName);


            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(sourceFile, targetFile, true);
            return targetFileName;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            card.Name = tb_name.Text;
        }

        private void cb_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            card.Tag = cb_tag.SelectedItem as Tag;
        }

        public Card GetCard()
        {
            return card;
        }
    }
}
