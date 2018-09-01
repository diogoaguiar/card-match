using dino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dino
{
    public partial class FormGame : Form
    {
        private System.Media.SoundPlayer correctSound;
        private System.Media.SoundPlayer wrongSound;
        private Bitmap correctImage;
        private Bitmap wrongImage;
        private Theme theme;
        private Timer timerNext;
        private Timer timerCheck;
        private int index;
        private SerialCommunication serial;
        private string serialInput;

        public FormGame(Theme theme, string comPort)
        {
            InitializeComponent();
            correctSound = new System.Media.SoundPlayer(Properties.Resources.correct);
            wrongSound = new System.Media.SoundPlayer(Properties.Resources.wrong);
            correctImage = new Bitmap(Properties.Resources.correct1);
            wrongImage = new Bitmap(Properties.Resources.wrong1);
            this.theme = CloneExtensions.CloneFactory.GetClone(theme);
            timerNext = new Timer
            {
                Interval = Config.GetInstance().NextSlideDelay
            };
            timerCheck = new Timer
            {
                Interval = 500
            };
            timerNext.Tick += new EventHandler(timerNext_Tick);
            timerCheck.Tick += new EventHandler(timerCheck_Tick);

            // Serial Communication
            serial = new SerialCommunication(comPort, new SerialDataReceivedEventHandler(ParseCardId));
            serialInput = "";
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            Shuffle(theme.Cards);
            index = 0;
            pb_screen.ImageLocation = Path.Combine(Config.GetInstance().ImagesBasePath, theme.Cards[index].ImageFile);
            try
            {
                serial.Port.Open();
                serial.Port.Write("1");
                timerCheck.Start();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                Close();
            }
        }

        private void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Correct()
        {
            pb_result.Image = correctImage;
            pb_result.Visible = true;
            correctSound.Play();
            timerNext.Start();
        }

        private void Wrong()
        {
            pb_result.Image = wrongImage;
            pb_result.Visible = true;
            wrongSound.Play();
            timerNext.Start();
        }

        private void timerNext_Tick(object sender, EventArgs e)
        {
            NextSlide();
            timerNext.Stop();
        }

        private void NextSlide()
        {
            pb_result.Visible = false;
            if (++index < theme.Cards.Count)
            {
                pb_screen.ImageLocation = Path.Combine(Config.GetInstance().ImagesBasePath, theme.Cards[index].ImageFile);
                serial.Port.Open();
                serial.Port.Write("1");
                timerCheck.Start();
            }
            else
            {
                Close();
            }
        }

        private void b_certo_Click(object sender, EventArgs e)
        {
            Correct();
        }

        private void b_errado_Click(object sender, EventArgs e)
        {
            Wrong();
        }

        void ParseCardId(object sender, SerialDataReceivedEventArgs e)
        {
            serialInput += serial.Port.ReadExisting();
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            //serialInput += serial.Port.ReadExisting();
            if (!serialInput.EndsWith("\r\n"))
            {
                return;
            }

            serial.Port.Close();
            timerCheck.Stop();
            string cardId = serialInput.Trim();
            serialInput = "";
            Console.WriteLine(cardId);
            Card card = theme.Cards.Find(c => c.Tag.Id.Equals(cardId));

            if (theme.Cards[index].Equals(card))
            {
                Correct();
            }
            else
            {
                Wrong();
            }
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Port.Close();
            serial.Port.Dispose();
        }
    }
}
