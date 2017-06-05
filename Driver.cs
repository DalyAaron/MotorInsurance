using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorInsuranceCalculation
{
    public class Driver
    {
        // Setup variables 
        DateTime driverDOB, claimDate1, claimDate2, claimDate3, claimDate4, claimDate5;
        String driverName, occupation;
        int numClaims;
        bool claimFlag;

        // Constructor for Driver instances
        public Driver(String _driverName, String _occupation, DateTime _driverDOB, bool _claimFlag, int _numClaims, DateTime _claimDate1, DateTime _claimDate2, DateTime _claimDate3, DateTime _claimDate4, DateTime _claimDate5)
        {
            driverName = _driverName;
            occupation = _occupation;
            driverDOB = _driverDOB;
            claimFlag = _claimFlag;
            numClaims = _numClaims;
            claimDate1 = _claimDate1;
            claimDate2 = _claimDate2;
            claimDate3 = _claimDate3;
            claimDate4 = _claimDate4;
            claimDate5 = _claimDate5;
        }

        // Getter and setter methods
        public String DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }
        public String Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        public DateTime DriverDOB
        {
            get { return driverDOB; }
            set { driverDOB = value; }
        }
        public bool ClaimFlag
        {
            get { return claimFlag; }
            set { claimFlag = value; }
        }
        public int NumClaims
        {
            get { return numClaims; }
            set { numClaims = value; }
        }
        public DateTime ClaimDate1
        {
            get { return claimDate1; }
            set { claimDate1 = value; }
        }
        public DateTime ClaimDate2
        {
            get { return claimDate2; }
            set { claimDate2 = value; }
        }
        public DateTime ClaimDate3
        {
            get { return claimDate3; }
            set { claimDate3 = value; }
        }
        public DateTime ClaimDate4
        {
            get { return claimDate4; }
            set { claimDate4 = value; }
        }
        public DateTime ClaimDate5
        {
            get { return claimDate5; }
            set { claimDate5 = value; }
        }
    }
}
