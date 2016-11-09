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
        List<string> TrainCarAmount;

        //fill TrainCarAmount with a loop
        for (int i = 1; i <= 5; i++)
            {
                TrainCarAmount.Add(i.ToString());
            }

    


    //declare buttons to determin which vehicle is selected
    #region button listeners
    private void btnAutomobile_Click(object sender, EventArgs e)
    {
        vehType = "Automobile";
    }

    private void btnTrain_Click(object sender, EventArgs e)
    {
        vehType = "Train";
    }

    private void btnPlane_Click(object sender, EventArgs e)
    {
        vehType = "Plane";
    }
    #endregion

    //button to display calculated data
    private void btnDisplay_Click(object sender, EventArgs e)
    {
        //use switch case to determin which class to use
        switch (vehType)
        {

            case "Automobile":
                Automobile automobile1 = new Automobile("Automobile", "45 MPH", "Manual");
                lblDisplay.Text = automobile1.displayInfo();
                break;
            case "Plane":
                Plane plane1 = new Plane("Plane", "456 MPH", "Jet");
                lblDisplay.Text = plane1.displayInfo();
                break;
            case "Train":
                Train train1 = new Train("Train", "75 MPH", "65");
                lblDisplay.Text = train1.displayInfo();
                break;
            default:
                MessageBox.Show("You didn't select a valid vehicle type!", "Error!");
                break;
        }
    }


    //function that makes elements visable depending on which vehicle type is selected
    private void changeField(Label lbl)
    {
        if (lbl.Visible)
        {
            lbl.Visible = false;
        }
        else if (!lbl.Visible)
        {
            lbl.Visible = true;
        }
    }







}
}
