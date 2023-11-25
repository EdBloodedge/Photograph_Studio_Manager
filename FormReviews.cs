using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poyecto_estudio
{

    
    public partial class FormReviews : Form
    {
        List<PictureBox> Stars = new List<PictureBox>();

        public FormReviews()
        {
            InitializeComponent();
            Stars.Add(pictureBox1Star);
            Stars.Add(pictureBox2Stars);
            Stars.Add(pictureBox3Stars);
            Stars.Add(pictureBox4Stars);
            Stars.Add(pictureBox5Stars);
        }

        private void pictureBox5Stars_Click(object sender, EventArgs e)
        {
            FillStars(5);
        }

        private void pictureBox4Stars_Click(object sender, EventArgs e)
        {
            FillStars(4);
        }

        private void pictureBox3Stars_Click(object sender, EventArgs e)
        {
            FillStars(3);
        }

        private void pictureBox2Stars_Click(object sender, EventArgs e)
        {
            FillStars(2);
        }

        private void pictureBox1Star_Click(object sender, EventArgs e)
        {
            FillStars(1);
        }
        private void FillStars(int n)
        {

            for (int i = 0; i < n; i++)
            {

                Stars[i].BackgroundImage = pictureBoxLightedStar.BackgroundImage;
            }

            for (int i = 4; i >= n; i--)
            {
                Stars[i].BackgroundImage = pictureBoxTurnedOffStar.BackgroundImage;
            }
        }

    }
}
