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
            if (driver.ClaimFlag)
            {
                driver.NumClaims = Convert.ToInt16(numClaimsBox.SelectedItem.ToString());
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

        //Button handler for add claim button
        private void addClaimButton_Click(object sender, EventArgs e)
        {
            claimFlag = true;
            claimDetailsLabel.Visible = true;
            numClaimsLabel.Visible = true;
            numClaimsBox.Visible = true;
        }

        //Button handler for additional drivers button
        private void additionalDriverButton_Click(object sender, EventArgs e)
        {
            //check number in list max of 5
            //clear boxes and add driver to driver list box
                saveDetails();
                driverList.DataSource = driverNames;
                clearForm(false);
        }

        //Button handler for get premium button
        private void getPremiumButton_Click(object sender, EventArgs e)
        {
            //save current driver
            if (drivers.Count < 5)
            {
                saveDetails();
                // check for decline
                string declineMessage = "";
                //If the start date of the policy is before today decline with the message "Start Date of Policy".
                policyDate = startDatePicker.Value.Date;
                if (policyDate < DateTime.Today)
                {
                    declineMessage = "Start Date of Policy";
                }
                //If the youngest driver is under the age of 21 at the start date of the policy decline with a message "Age of Youngest Driver" and append the name of the driver.
                //sort list by age
                List<Driver> sortedList = drivers.OrderBy(d => d.DriverDOB).ToList();
                if (sortedList.Last().DriverDOB > DateTime.Today.AddYears(-21))
                {
                    declineMessage = "Age of Youngest Driver - " + sortedList.Last().DriverName;
                }
                //If the oldest driver is over the age of 75 at the start date of the policy decline with a message "Age of Oldest Driver" and append the name of the driver.
                if (sortedList.First().DriverDOB < DateTime.Today.AddYears(-75))
                {
                    declineMessage = "Age of Oldest Driver - " + sortedList.First().DriverName;
                }
                //If a driver has more than 2 claims decline with a message "Driver has more than 2 claims" – include the name of the driver.
                foreach (Driver d in drivers)
                {
                    if (d.NumClaims >= 2)
                    {
                        declineMessage = "Driver has more than 2 claims - " + d.DriverName;
                    }
                }
                //If the total number of claims exceeds 3 then decline with a message "Policy has more than 3 claims".
                int totalClaims = 0;
                foreach (Driver d in drivers)
                {
                    totalClaims += d.NumClaims;
                    if (totalClaims > 3)
                    {
                        declineMessage = "Policy has more than 3 claims";
                    }
                }
                // if decline message is not null then show decline message box else run calculation.
                if (declineMessage != "")
                {
                    MessageBox.Show(declineMessage,
                    "Declined Reason",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    clearForm(true);
                }
                else {
                    //run calculation if no decline
                    //The starting point for the premium is £500.
                    double premium = 500;
                    //If there is driver who is a Chauffeur on the policy increase the premium by 10%
                    //If there is driver who is an Accountant on the policy decrease the premium by 10%
                    foreach (Driver d in drivers)
                    {
                        if (d.Occupation == "Chauffeur")
                        {
                            premium = (premium + (0.1 * premium));
                        }
                        else if (d.Occupation == "Accountant")
                        {
                            premium = (premium - (0.1 * premium));
                        }
                    }
                    //If the youngest driver is aged between 21 and 25 at the start date of the policy increase the premium by 20%
                    if (sortedList.Last().DriverDOB <= DateTime.Now.AddYears(-21) && sortedList.Last().DriverDOB >= DateTime.Now.AddYears(-25))
                    {
                        premium = (premium + (0.2 * premium));
                    }
                    //If the youngest driver is aged between 26 and 75 at the start date of the policy decrease the premium by 10%
                    if (sortedList.Last().DriverDOB <= DateTime.Now.AddYears(-26) && sortedList.Last().DriverDOB >= DateTime.Now.AddYears(-75))
                    {
                        premium = (premium - (0.1 * premium));
                    }
                    //For each claim within 1 year of the start date of the policy increase the premium by 20%
                    foreach (Driver d in drivers)
                    {
                        if (d.ClaimDate1 >= DateTime.Now.AddYears(-1))
                        {
                            premium = (premium + (0.2 * premium));
                        }
                        if (d.ClaimDate2 >= DateTime.Now.AddYears(-1))
                        {
                            premium = (premium + (0.2 * premium));
                        }
                        if (d.ClaimDate3 >= DateTime.Now.AddYears(-1))
                        {
                            premium = (premium + (0.2 * premium));
                        }
                        if (d.ClaimDate4 >= DateTime.Now.AddYears(-1))
                        {
                            premium = (premium + (0.2 * premium));
                        }
                        if (d.ClaimDate5 >= DateTime.Now.AddYears(-1))
                        {
                            premium = (premium + (0.2 * premium));
                        }

                        //For each claim within 2 - 5 years of the start date of the policy increase the premium by 10%
                        if ((d.ClaimDate1 >= DateTime.Now.AddYears(-5)) && (d.ClaimDate1 <= DateTime.Now.AddYears(-2)))
                        {
                            premium = (premium + (0.1 * premium));
                        }
                        if ((d.ClaimDate2 >= DateTime.Now.AddYears(-5)) && (d.ClaimDate1 <= DateTime.Now.AddYears(-2)))
                        {
                            premium = (premium + (0.1 * premium));
                        }
                        if ((d.ClaimDate2 >= DateTime.Now.AddYears(-5)) && (d.ClaimDate1 <= DateTime.Now.AddYears(-2)))
                        {
                            premium = (premium + (0.1 * premium));
                        }
                        if ((d.ClaimDate2 >= DateTime.Now.AddYears(-5)) && (d.ClaimDate1 <= DateTime.Now.AddYears(-2)))
                        {
                            premium = (premium + (0.1 * premium));
                        }
                        if ((d.ClaimDate2 >= DateTime.Now.AddYears(-5)) && (d.ClaimDate1 <= DateTime.Now.AddYears(-2)))
                        {
                            premium = (premium + (0.1 * premium));
                        }
                    }
                    MessageBox.Show("The total premium for this policy is £" + Math.Round(premium,2),
                        "Premium Ammount");
                    clearForm(true);
                }
            }
        }

        //Method to clear the form input fields with a true or false total reset to clear lists as well
        private void clearForm(bool totalReset)
        {
            if (totalReset)
            {
                startDatePicker.Value = DateTime.Now;
                nameTBox.Text = "";
                occupationList.Text = "Please Select...";
                dobPicker.Value = DateTime.Now;
                drivers.Clear();
                driverNames.Clear();
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
            else
            {
                nameTBox.Text = "";
                occupationList.Text = "Please Select...";
                dobPicker.Value = DateTime.Now;
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
        }

        //Method to add driver object and string name to lists
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

        //Handler on name box for enabling buttons when fields are filled out
        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            if ((nameTBox.Text != "") && (occupationList.Text != "Please Select..."))
            {
                    getPremiumButton.Enabled = true;
                    additionalDriverButton.Enabled = true;
            } else {
                getPremiumButton.Enabled = false;
                additionalDriverButton.Enabled = false;
            }
        }

        //Handler on occupations box for enabling buttons when fields are filled out
        private void occupationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((nameTBox.Text != "") && (occupationList.Text != "Please Select..."))
            {
                getPremiumButton.Enabled = true;
                additionalDriverButton.Enabled = true;
            }
            else {
                getPremiumButton.Enabled = false;
                additionalDriverButton.Enabled = false;
            }
        }

        //Handler to manage claim section
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
