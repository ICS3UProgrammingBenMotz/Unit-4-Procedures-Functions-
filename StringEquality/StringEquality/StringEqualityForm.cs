/*
 * Created by: Ben M
 * Created on: 26-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if strings are equal
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

namespace StringEquality
{
    public partial class frmStringEquality : Form
    {
        //Creates compare strings 
        private bool  CompareStrings (string stringOne, string stringTwo)
        {
            bool isEqual;

            stringOne = stringOne.ToLower();

            stringTwo = stringTwo.ToLower();

            isEqual = false;

            if (stringOne==stringTwo)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

           return isEqual;
        }

        public frmStringEquality()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userStringOne, userStringTwo;

            bool TorF;

            TorF = false;

            //assignes variables ot textboxes
            userStringOne = txtStringOne.Text;
            userStringTwo = txtStringTwo.Text;

            //Calls function
            TorF = CompareStrings(userStringOne, userStringTwo);

            //if statement for message box
            if (TorF==true)
            {
                MessageBox.Show("The strings are equal");
            }
            else
            {
                MessageBox.Show("The strings are not equal");
            }

            

        }
    }
}
