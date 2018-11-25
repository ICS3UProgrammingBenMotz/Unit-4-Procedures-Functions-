/*
 * Created by: Ben M
 * Created on: 24-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - dynamicPicBox
 * This program makess a man walk when he is clicked
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Creates system.threading
using System.Threading;

namespace dynmaicPic_BenM_
{
    public partial class Form1 : Form
    {

        private void GeneratePictureBoxes()
        {
            //Creates pic boxes on form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);

        }

        private void GeneratePictureBox(int x, int y)
        {
            //Generates new picbox
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //Set the location
            tmpPicMan.Location = pntPic;

            //Puts image in picbox
            tmpPicMan.Image = Properties.Resources.walk1;

            //fixes size of the image
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //Makes picbox's mesurements
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //Event listener
            tmpPicMan.Click += new System.EventHandler(pictureBox1_Click);

            //Add picture box
            this.Controls.Add(tmpPicMan);
        }
        public Form1()
        {
            InitializeComponent();
            //Hides lbls and pic
            lblClickMe.Hide();
            pictureBox1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Shows labels
            lblClickMe.Show();

            //Creates the picboxs
            GeneratePictureBoxes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Puts sender object to a picbox
            PictureBox tmpPicMan = (PictureBox)sender;

            //Brings up message box
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //Declare variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //Continue loop
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
                //Incement by 1
                pictureFrameCounter = pictureFrameCounter + 1;
                this.Refresh();

                //Pause for 100 milliseconds
                Thread.Sleep(100);
            }
        }
    }
}
