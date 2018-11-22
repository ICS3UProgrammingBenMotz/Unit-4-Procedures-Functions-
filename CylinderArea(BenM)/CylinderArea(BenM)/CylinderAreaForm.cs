/*
 * Created by: Ben M
 * Created on: 22-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calculates volume of a cylinder
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

namespace CylinderArea_BenM_
{
    public partial class frmCylinderArea : Form
    {
        public frmCylinderArea()
        {
            InitializeComponent();
        }

        private double CalculateVolume(double radius, double height)
        {
            //makes volume a double
            double volume;

            //makes volume equal something
            volume = (Math.PI * Math.Pow(radius, 2)) * height;

            //returns volume
            return volume;
            
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Creates Variables
            double userRadius, userHeight, userVolume;

            //Assigns user Radius
            userRadius = double.Parse(txtRadius.Text);

            //Assigns user Height
            userHeight = double.Parse(txtHeight.Text);

            //assigns uservolume
            userVolume = CalculateVolume(userRadius, userHeight);
           
            //rounds to 2 decimal places
            userVolume = Math.Round(userVolume, 2);
          
            //shows in a message box 
            MessageBox.Show("The cylinder's volume is " + userVolume + "cm^3" );
        }
    }
}
