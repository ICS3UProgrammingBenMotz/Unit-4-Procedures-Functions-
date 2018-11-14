/*
 * Created by: Ben Motz
 * Created on: 14-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Temp Converter
 * This program converts celcius to farenheight
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

namespace ConvertingTemps_BenM_
{
    public partial class frmConvertingTemp : Form
    {
        public frmConvertingTemp()
        {
            InitializeComponent();
        }
        //Creates ConvertToF procedure
        public void ConvertToF(int celcius)
        {
            //Creates Farenheight variable
            double Farenheight;

            //Calculation for farenheight
           Farenheight = (double) (9) / (double) (5) * celcius + 32;

            //Displays farenheight in message
            MessageBox.Show("The temperature is: " + Farenheight + " degrees farenheight.");
        }

        private void frmConvertingTemp_Load(object sender, EventArgs e)
        {
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declares celcius as a variable
            int userCelcius;

            //Decalres what celcius is
            userCelcius = Convert.ToInt16(this.txtTempCel.Text);

            //Converts to fareneheight
            this.ConvertToF(userCelcius);
        }
    }
}
