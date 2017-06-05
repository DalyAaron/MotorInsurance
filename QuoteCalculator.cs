using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorInsuranceCalculation
{
    public partial class QuoteCalculator : Form
    {
        DateTime policyDate;
        bool claimFlag = false;
        List<Driver> drivers = new List<Driver>(5);
        BindingList<string> driverNames = new BindingList<string>();

        public QuoteCalculator()
        {
            //Setup lists for form
            InitializeComponent();
            driverList.DataSource = driverNames;
            getPremiumButton.Enabled = false;
            additionalDriverButton.Enabled = false;
        }
        

        //Assign user input to variables
        public Driver populateDriver()
        {
            Driver driver = new Driver("","", Convert.ToDateTime("2017-01-01") , false, 0, Convert.ToDateTime("0001-01-01"), Convert.ToDateTime("0001-01-01"), Convert.ToDateTime("0001-01-01"), Convert.ToDateTime("0001-01-01"), Convert.ToDateTime("0001-01-01"));
            driver.DriverName = nameTBox.Text;
            driver.Occupation = occupationList.SelectedItem.ToString();
            driver.DriverDOB = dobPicker.Value.Date;
            driver.ClaimFlag = claimFlag;
            driver.NumClaims = Convert.ToInt16(numClaimsBox.SelectedItem.ToString());
            if (driver.ClaimFlag)
            {
                if (driver.NumClaims == 1)
                {
                    driver.ClaimDate1 = claimDatePicker1.Value.Date;
                }
                if (driver.NumClaims == 2)
                {
                    driver.ClaimDate1 = claimDatePicker1.Value.Date;
                    driver.ClaimDate2 = claimDatePicker2.Value.Date;
                }
                if (driver.NumClaims == 3)
                {
                    driver.ClaimDate1 = claimDatePicker1.Value.Date;
                    driver.ClaimDate2 = claimDatePicker2.Value.Date;
                    driver.ClaimDate3 = claimDatePicker3.Value.Date;
                }
                if (driver.NumClaims == 3)
                {
                    driver.ClaimDate1 = claimDatePicker1.Value.Date;
                    driver.ClaimDate2 = claimDatePicker2.Value.Date;
                    driver.ClaimDate3 = claimDatePicker3.Value.Date;
                    driver.ClaimDate4 = claimDatePicker4.Value.Date;
                }
                if (driver.NumClaims == 3)
                {
                    driver.ClaimDate1 = claimDatePicker1.Value.Date;
                    driver.ClaimDate2 = claimDatePicker2.Value.Date;
                    driver.ClaimDate3 = claimDatePicker3.Value.Date;
                    driver.ClaimDate4 = claimDatePicker4.Value.Date;
                    driver.ClaimDate5 = claimDatePicker5.Value.Date;
                }

            }
            return driver;

        }

        private void addClaimButton_Click(object sender, EventArgs e)
        {
            claimFlag = true;
            claimDetailsLabel.Visible = true;
            numClaimsLabel.Visible = true;
            numClaimsBox.Visible = true;
        }

        private void additionalDriverButton_Click(object sender, EventArgs e)
        {
            //check number in list max of 5
            //clear boxes and add driver to driver list box
                saveDetails();
                driverList.DataSource = driverNames;
            //reset claim section
                claimDetailsLabel.Visible = false;
                numClaimsLabel.Visible = false;
                numClaimsBox.Visible = false;
                claim1Label.Visible = false;
                claimDatePicker1.Visible = false;
                claim2Label.Visible = false;
                claimDatePicker2.Visible = false;
                claim3Label.Visible = false;
                claimDatePicker3.Visible = false;
                claim4Label.Visible = false;
                claimDatePicker4.Visible = false;
                claim5Label.Visible = false;
                claimDatePicker5.Visible = false;
                claimFlag = false;
        }

        private void getPremiumButton_Click(object sender, EventArgs e)
        {
            //save current driver
            if (drivers.Count < 5)
            {
                saveDetails();
            // check for decline


            //run calculation if no decline

            }

        }

        public void saveDetails()
        {
            //instatiate a driver object from inputs
            Driver currentDriver = populateDriver();
            //check current driver is not already an added driver
            if (!drivers.Any(driv => driv.DriverName == currentDriver.DriverName))
            {
                //check to make sure no more than 5 drivers
                if (drivers.Count != 5)
                {
                    drivers.Add(currentDriver);
                    driverNames.Add(currentDriver.DriverName.ToString());
                    driverList.DataSource = driverNames;
                } else {
                    MessageBox.Show("Maximum of 5 drivers allowed.",
                    "Drivers maximum reached",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTBox.Text != "")
            {
                    getPremiumButton.Enabled = true;
                    additionalDriverButton.Enabled = true;
            } else {
                getPremiumButton.Enabled = false;
                additionalDriverButton.Enabled = false;
            }
        }

        private void numClaimsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numClaimsBox.SelectedItem.ToString() == "1")
            {
                claim1Label.Visible = true;
                claimDatePicker1.Visible = true;
                claim2Label.Visible = false;
                claimDatePicker2.Visible = false;
                claim3Label.Visible = false;
                claimDatePicker3.Visible = false;
                claim4Label.Visible = false;
                claimDatePicker4.Visible = false;
                claim5Label.Visible = false;
                claimDatePicker5.Visible = false;
            }
            if (numClaimsBox.SelectedItem.ToString() == "2")
            {
                claim1Label.Visible = true;
                claimDatePicker1.Visible = true;
                claim2Label.Visible = true;
                claimDatePicker2.Visible = true;
                claim3Label.Visible = false;
                claimDatePicker3.Visible = false;
                claim4Label.Visible = false;
                claimDatePicker4.Visible = false;
                claim5Label.Visible = false;
                claimDatePicker5.Visible = false;
            }
            if (numClaimsBox.SelectedItem.ToString() == "3")
            {
                claim1Label.Visible = true;
                claimDatePicker1.Visible = true;
                claim2Label.Visible = true;
                claimDatePicker2.Visible = true;
                claim3Label.Visible = true;
                claimDatePicker3.Visible = true;
                claim4Label.Visible = false;
                claimDatePicker4.Visible = false;
                claim5Label.Visible = false;
                claimDatePicker5.Visible = false;
            }
            if (numClaimsBox.SelectedItem.ToString() == "4")
            {
                claim1Label.Visible = true;
                claimDatePicker1.Visible = true;
                claim2Label.Visible = true;
                claimDatePicker2.Visible = true;
                claim3Label.Visible = true;
                claimDatePicker3.Visible = true;
                claim4Label.Visible = true;
                claimDatePicker4.Visible = true;
                claim5Label.Visible = false;
                claimDatePicker5.Visible = false;
            }
            if (numClaimsBox.SelectedItem.ToString() == "5")
            {
                claim1Label.Visible = true;
                claimDatePicker1.Visible = true;
                claim2Label.Visible = true;
                claimDatePicker2.Visible = true;
                claim3Label.Visible = true;
                claimDatePicker3.Visible = true;
                claim4Label.Visible = true;
                claimDatePicker4.Visible = true;
                claim5Label.Visible = true;
                claimDatePicker5.Visible = true;
            }
        }
    }
}
