using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Design_GovernmentApp_NJager
{
    class PayCalculator
    {
        public string[] stateNameArray = new string[] { "RI", "NY" };
        public double[] ficaTaxArray = new double[] { .0765, .0765 };
        public double[] fedTaxArray = new double[] { .2, .2 };
        public double[] stateTaxArray = new double[] { .1, .07 };
        public double[] healthArray = new double[] { .07, .065 };

        public string state;
        public double hoursWorked;
        public double hourlyRate;
        double grossPay;

        public PayCalculator()
        {
            //empty constructor
        }

        public PayCalculator(string aState, double hrsWorked, double hrlyRate)
        {
            state = aState;
            hoursWorked = hrsWorked;
            hourlyRate = hrlyRate;
            
        }


        public string State
        {
            set
            {
                state = value;
            }
            get
            {
 
                SetStateName();
                return state;
                
            }
        }

        //property used to access or change number of hours worked 
        public double HoursWorked
        {
            set
            {
                hoursWorked = value;
            }
            get
            {
                return hoursWorked;
            }
        }

        //property used to access or change houlry rate 
        public double HourlyRate
        {
            set
            {
                hourlyRate = value;
            }
            get
            {
                return hourlyRate;
            }
        }

        public void SetStateName()
        {
            for (int i = 0; i < stateNameArray.Length; i++)
            {
                if (stateNameArray[i] == state)
                {
                    state = stateNameArray[i];
                }
            }


        }

        public double SetFicaResults()
        {
            
            bool found;
            string errorMessage;
            double ficaResults = 0;
            int index = Array.IndexOf(stateNameArray, this.state);
            if (index == -1) //not found 
            {
                found = false;
            }
            else
            {
                found = true;
                ficaResults = ficaTaxArray[index];
                
            }
            if (found == false)
            {
                errorMessage = string.Format("NOT FOUND!");
                //not used currently 
            }

            return ficaResults;
           
        }

        public double SetFedResult()
        {
            bool found;
            string errorMessage;
            double fedResults = 0;

            int index = Array.IndexOf(stateNameArray, state);
            if (index == -1) //not found
            {
                found = false;
            }
            else
            {
                found = true;
                fedResults = fedTaxArray[index];
           
            }
            if (found == false)
            {
                errorMessage = string.Format("NOT FOUND!");
                //not currently used
            }

            return fedResults;
        }

        public double SetStateTaxResult()
        {
            bool found;
            string errorMessage;
            double stateTaxResults = 0;

            int index = Array.IndexOf(stateNameArray, state);
            if (index == -1) //not found
            {
                found = false;
            }
            else
            {
                found = true;
                stateTaxResults = stateTaxArray[index];

            }
            if (found == false)
            {
                errorMessage = string.Format("NOT FOUND!");
                //not currently used
            }

            return stateTaxResults;
        }

        public double SetHealthResult()
        {
            bool found;
            string errorMessage;
            double healthResults = 0;

            int index = Array.IndexOf(stateNameArray, state);
            if (index == -1) //not found
            {
                found = false;
            }
            else
            {
                found = true;
                healthResults = healthArray[index];

            }
            if (found == false)
            {
                errorMessage = string.Format("NOT FOUND!");
                //not currently used
            }

            return healthResults;
        }

        public double DetermineGross()
        {
            grossPay = hoursWorked * hourlyRate;
            return grossPay;
        }

        public double DetermineFicaTax()
        {
            return DetermineGross() * SetFicaResults();
        }

        public double DetermineFedTax()
        {
            return DetermineGross() * SetFedResult();
        }

        public double DetermineStateTax()
        {
            return DetermineGross() * SetStateTaxResult();
        }

        public double DetermineHealth()
        {
            return DetermineGross() * SetHealthResult();
        }

        public double DetermineNet()
        {
            return DetermineGross() - DetermineFicaTax() - DetermineFedTax() - DetermineStateTax() - DetermineHealth();
        }

        public override string ToString()
        {
            return "\nTake Home Pay: " + DetermineNet().ToString("C");
        }
    }
}
