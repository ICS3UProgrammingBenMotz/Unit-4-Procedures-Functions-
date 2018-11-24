/*
 * Created by: Ben M
 * Created on: 23-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program display an inputed address
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

namespace NamePro_BenM_
{
    public partial class frmNamePro : Form
    {
        public void PrintAddress(string street, string city, string province, string postalCode, string aptNumb)
        {
            //Shows Message box
            MessageBox.Show("Your address is: " + street + " " + city + " " + province + " " + postalCode + " apt number: " + aptNumb); 
        }


        public void PrintAddress(string street, string city, string province, string postalCode)
        {
            //Shows Message box
            MessageBox.Show("Your address is: " + street + " " + city + " " + province + " " + postalCode); 

        }


        public frmNamePro()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            //Declares varaibles 
            string userStreet, userCity, userProvince, userPostalCode, userAptNumb;

            //Gets info from text boxes
            userStreet = this.txtStreetAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;
            userAptNumb = this.txtAptNumb.Text;

            if (userStreet=="")
            {
                //Makes user enter street
                MessageBox.Show("Please enter your Street");
            }
            else if (userCity=="")
            {
                //Makes user enter city
                MessageBox.Show("Please enter your City");
            }
            else if (userProvince=="")
            {
                //Makes user enter province
                MessageBox.Show("Please enter your province");
            }
            else if (userPostalCode=="")
            {
                //Makes user enter postalcode
                MessageBox.Show("Please enter a Postalcode");
            }
            else if (userAptNumb=="")
            {
                PrintAddress(userStreet, userCity, userProvince, userPostalCode);
            }
            else
            {
                PrintAddress(userStreet, userCity, userProvince, userPostalCode, userAptNumb);
            }
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
