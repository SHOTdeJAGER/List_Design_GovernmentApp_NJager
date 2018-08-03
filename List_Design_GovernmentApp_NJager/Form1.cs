using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Design_GovernmentApp_NJager
{
    public partial class PayCalculatorForm : Form
    {
        public PayCalculatorForm()
        {
            InitializeComponent();
        }

        
        //Instantiates an object of the PayCalculator class when the form is first loaded
        private void StateGUI_Load(object sender, System.EventArgs e)
        {
            
            newPayCalculator = new PayCalculator();
            for (int i = 0; i < newPayCalculator.stateNameArray.Length; i++)
            {
                this.lstBxState.Items.Add(newPayCalculator.stateNameArray[i]);
            }
        }

        //event handles that gets the state from the list box 
        private void lstBxState_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            newPayCalculator.State = lstBxState.Text;
        }
        //Button click event handle for calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hrsWorked;
            double hrlyRate;
            string aState = lstBxState.Text; 

            while (double.TryParse(txtBxHours.Text, out hrsWorked) == false)
            {
                MessageBox.Show("Number value should be " + "entered for hours");
                txtBxHours.Text = "0";
                txtBxHours.Focus();
            }

            if (double.TryParse(txtBxHourlyRate.Text, out hrlyRate) == false)
            {
                MessageBox.Show("Hourly Rate default value of 0 " + "used for for calculations");
                txtBxHourlyRate.Text = "0";
                txtBxHourlyRate.Focus();
            }

            if (hrsWorked > 0)
            {
                PayCalculator aPayCalculator = new PayCalculator(aState, hrsWorked, hrlyRate);
                txtBxGrossPay.Text = aPayCalculator.DetermineGross().ToString("C");
                txtBxFica.Text = aPayCalculator.DetermineFicaTax().ToString("C");
                txtBxFed.Text = aPayCalculator.DetermineFedTax().ToString("C");
                txtBxState.Text = aPayCalculator.DetermineStateTax().ToString("C");
                txtBxHealth.Text = aPayCalculator.DetermineHealth().ToString("C");
                txtBxNetPay.Text = aPayCalculator.DetermineNet().ToString("C");
                txtBxHours.Visible = false;
                txtBxHourlyRate.Visible = false;
                lblHours.Visible = false;
                lblHourlyRate.Visible = false;
                setVisibility(true);

            }


        }

        //used by both the btnCalculate and btnReset to change the visibility on the objects below the buttons 
        private void setVisibility(bool visibilityValue)
        {
            lblGrossPay.Visible = visibilityValue;
            lblFica.Visible = visibilityValue;
            lblFed.Visible = visibilityValue;
            lblState.Visible = visibilityValue;
            lblHealth.Visible = visibilityValue;
            lblNetPay.Visible = visibilityValue;
            txtBxGrossPay.Visible = visibilityValue;
            txtBxFica.Visible = visibilityValue;
            txtBxFed.Visible = visibilityValue;
            txtBxState.Visible = visibilityValue;
            txtBxHealth.Visible = visibilityValue;
            txtBxNetPay.Visible = visibilityValue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtBxHours.Text = "0";
            txtBxHourlyRate.Text = "0";
            lstBxState.Text = " ";
            txtBxHours.Visible = true;
            txtBxHourlyRate.Visible = true;
            lblHours.Visible = true;
            lblHourlyRate.Visible = true;
            setVisibility(false);
        }
    }
}



