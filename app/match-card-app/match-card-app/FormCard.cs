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
        private Card Card { get; }

        public FormCard()
        {
            Init();
            Card = new Card();
        }

        private void Init()
        {
            InitializeComponent();

            // Load tags from settings

        }

        private void b_image_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd_image.ShowDialog();

            if (result == DialogResult.OK)
            {
                l_image_name.Text = System.IO.Path.GetFileName(ofd_image.FileName);
                pb_image_preview.ImageLocation = ofd_image.FileName;
            }
        }
    }
}
