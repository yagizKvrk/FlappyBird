using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        int gravity = 10;

        Random uzaklikRnd = new Random();
        Random hghtRnd = new Random();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Hide();
            tmrIlerle.Start();
            btnBasla.Enabled = false;
            pbBird.Enabled = true;
        }

        private void tmrIlerle_Tick(object sender, EventArgs e)
        {
            lblScore.Text = score.ToString();
            pbBird.Top += gravity;

            pbAltEngel.Left -= 9;
            pbUstEngel.Left -= 9;
            //Location bilgisi alınabilir ancak loc. değiştirilemiyor??
            //if(pbAltEngel.Location.X+pbAltEngel.Width == 0)
            //{
            //    pbAltEngel.Left = 1300;
            //}

            if (pbAltEngel.Left < 0 - pbAltEngel.Width)
            {
                score++;
                pbAltEngel.Left = uzaklikRnd.Next(1250,1500);
                pbAltEngel.Top = hghtRnd.Next(pbAltEngel.Top, pbAltEngel.Top+170);
            }

            if (pbUstEngel.Left < 0 - pbUstEngel.Width)
            {
                score++;
                pbUstEngel.Left = uzaklikRnd.Next(1250, 1500);
                pbUstEngel.Height = hghtRnd.Next(125, 295);
            }
            if(pbBird.Bounds.IntersectsWith(pbUstEngel.Bounds) || pbBird.Bounds.IntersectsWith(pbAltEngel.Bounds) || pbBird.Bounds.IntersectsWith(pbCim.Bounds) || pbBird.Top <= 0)
            {
                tmrIlerle.Stop();
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Game Over! Tekrar oynamak ister misiniz?", "Flappy Birdcüler", MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    lblScore.Text = "0";
                    score = 0;
                    pbBird.Left = 88;
                    pbBird.Top = 209;
                    pbAltEngel.Left = 668;
                    pbAltEngel.Top = 359;
                    pbUstEngel.Left = 1049;
                    pbUstEngel.Top = -2;
                    btnBasla.Show();
                    btnBasla.Enabled = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(btnBasla.Enabled == true)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pbBird.Top -= 100;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Stop();
        }
        //En yüksek skor eklenebilir. Game over dan sonra skorunuzu sitemize eklemek ister misiniz diye sorup eğer istiyorsa başka bir form sayfasında listeye eklenebilir. Bu bilgileri dosyaya atıp program kapansa bile silinmemesini sağlarız. Eğer kişi kendi skorunu geçtiyse yeni yüksek skoru sisteme kaydedip eskiyi sileriz.
    }
}
