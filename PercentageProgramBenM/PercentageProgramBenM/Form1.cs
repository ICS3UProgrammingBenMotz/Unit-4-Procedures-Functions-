/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program converts a grade to a percent
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

namespace PercentageProgramBenM
{
   

    public partial class Form1 : Form
    {
        //Creates convert function
        public int ConvertToPercent(String level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 25;
                    break;
                case "0----":
                    percentage = 20;
                    break;
                case "0------":
                    percentage = 15;
                    break;
                case "0-------":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;

            }

            return percentage;

        }



        public Form1()
        {
            InitializeComponent();


        }

        public void btnCalculatePercent_Click(object sender, EventArgs e)
        {
           // Creates variable for userlevel
            string userLevel;

            //Creates variable for userMark
            int userMark;

            //Gives variables a value
            userLevel = txtGradeLvl.Text;

            userMark=ConvertToPercent(userLevel);

            //Shows percent
            MessageBox.Show("Your percentage is: " +  userMark + "%");

        }
    }
}
