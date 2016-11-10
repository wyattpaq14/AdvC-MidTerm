using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Declare vairable to store which button is clicked
        //determining which vehicle to choose
        public string vehType = "";

        //create lists for the dropdown
        List<string> automobileTransTypes = new List<string> { "Automatic", "Manual" };
        List<string> planeEngineTypes = new List<string> { "Jet", "Turboprop" };
        List<string> TrainCarAmount = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"};

        //was going to fill TrainCarAmount with a loop but was geting some weird error





        //declare buttons to determine which vehicle is selected
        #region button listeners
        private void btnAutomobile_Click(object sender, EventArgs e)
        {
            vehType = "Automobile";
            //set datasource to pre-defined list
            cbClassOption.DataSource = automobileTransTypes;

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            vehType = "Train";
            //set datasource to pre-defined list
            cbClassOption.DataSource = TrainCarAmount;
        }

        private void btnPlane_Click(object sender, EventArgs e)
        {
            vehType = "Plane";
            //set datasource to pre-defined list
            cbClassOption.DataSource = planeEngineTypes;
        }
        #endregion

        //button to display calculated data
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //use switch case to determin which class to use
            switch (vehType)
            {

                case "Automobile":
                    Automobile automobile1 = new Automobile(vehType, txtDistance.Text, getAutoMPH(), cbClassOption.Text);
                    lblDisplay.Text = automobile1.displayInfo();
                    break;
                case "Plane":
                    Plane plane1 = new Plane(vehType, txtDistance.Text, getPlaneMPH(), cbClassOption.Text);
                    lblDisplay.Text = plane1.displayInfo();
                    break;
                case "Train":
                    Train train1 = new Train(vehType, txtDistance.Text, getTrainMPH(), cbClassOption.Text);
                    lblDisplay.Text = train1.displayInfo();
                    break;
                default:
                    
                    break;

                
            }

            //Check if vehicle has been clicked
            if (vehType.Length == 0)
            {
                MessageBox.Show("Please select a vehicle type before hitting display!", "Error!");
            }
        }


        //functions to get average mile per hour given their conditions

        private string getAutoMPH()
        {
            txtAverageSpeed.Text = "60";
            return "60";
        }

        private string getPlaneMPH()
        {
            if (cbClassOption.Text == "Jet")
            {
                txtAverageSpeed.Text = "500";
                return "500";
            }
            else if (cbClassOption.Text == "Turboprop")
            {
                txtAverageSpeed.Text = "300";
                return "300";
            }
            else
            {
                MessageBox.Show("An error occured while calculating average miles per hour!", "Error!");
                return "0";
            }
        }
        private string getTrainMPH()
        {
            if (Convert.ToInt32(cbClassOption.Text) >= 20) {
                return "70";
            }
            else if (Convert.ToInt32(cbClassOption.Text) < 20)
            {
                return "100";
            }
            else
            {
                MessageBox.Show("An error occured while calculating average miles per hour!", "Error!");
                return "0";
            }
        }

        private void cbClassOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehType == "Automobile")
                txtAverageSpeed.Text = getAutoMPH();
            else if (vehType == "Train")
                txtAverageSpeed.Text = getTrainMPH();
            else if (vehType == "Plane")
                txtAverageSpeed.Text = getPlaneMPH();
        }
    }
}
