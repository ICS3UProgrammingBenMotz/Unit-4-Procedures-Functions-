/*
 * Created by: Ben M
 * Created on: 20-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Pass by reference
 * This program rounds numbers to certain decimal places
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

namespace RoundDecimals_BenM_
{
    public partial class frmRoundingDecimals : Form
    {
        private void RoundIt(ref double NumberUsed, int NumberOfDecPlaces)
        {
            //Procedure 
            NumberUsed = NumberUsed * Math.Pow(10, NumberOfDecPlaces);

            //adds .5 to number used
            NumberUsed = NumberUsed + 0.5;

            //makes sure that there are no decimals
            NumberUsed = Math.Truncate(NumberUsed);

            //Brings number back to its rounded state
            NumberUsed = NumberUsed / Math.Pow(10, NumberOfDecPlaces);

            //Displays a message box
            MessageBox.Show("The number is: " + NumberUsed);
        }
        public frmRoundingDecimals()
        {
            InitializeComponent();
        }

        private void btnRoundIt_Click(object sender, EventArgs e)
        {
            // variables to ints and doubles
            double Number;
            int NumbDecPlace;

            //Gets values form textbox and nuds
            Number = Convert.ToDouble(this.txtNumb.Text);
            NumbDecPlace = Convert.ToInt16(this.nudNumbOfDeciPla.Value);

            //Calls on functions
            this.RoundIt(ref Number, NumbDecPlace);
        }
    }
}
