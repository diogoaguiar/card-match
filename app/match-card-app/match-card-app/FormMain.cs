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
        private string comPort;

        public FormMain()
        {
            InitializeComponent();

            Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            config = Config.GetInstance();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            ReloadThemesList();
            b_edit.Enabled = b_delete.Enabled = b_play.Enabled = (lb_themes.SelectedItem != null);
            cb_com_port.Items.Clear();
            cb_com_port.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (cb_com_port.Items.Count > 0)
            {
                cb_com_port.SelectedIndex = 0;
            }
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
            RefreshForm();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            FormTheme configForm = new FormTheme(lb_themes.SelectedItem as Theme);
            configForm.ShowDialog();
            RefreshForm();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int themeIndex = lb_themes.SelectedIndex;
            string themeName = lb_themes.GetItemText(lb_themes.SelectedItem);
            DialogResult confirmation = MessageBox.Show(this, "Tem a certeza que pretende apagar o tema " + themeName + "?", "Apagar tema", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                config.DeleteTheme(lb_themes.SelectedItem as Theme);
                RefreshForm();
            }
        }

        private void b_play_Click(object sender, EventArgs e)
        {
            if (comPort == null || comPort == "")
            {
                MessageBox.Show(this, "Porta de comunicação não definida", "Erro", MessageBoxButtons.OK);
                return;
            }

            FormGame gameForm = new FormGame(lb_themes.SelectedItem as Theme, comPort);
            Hide();
            gameForm.ShowDialog();
            Show();
        }

        private void cb_com_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            comPort = cb_com_port.SelectedItem as String;
        }

        private void cb_com_port_DropDown(object sender, EventArgs e)
        {
            if (!cb_com_port.Items.Contains(System.IO.Ports.SerialPort.GetPortNames()))
            {
                cb_com_port.Items.Clear();
                cb_com_port.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            }
        }
    }
}
