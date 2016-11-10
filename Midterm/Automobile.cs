using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    //class for automobiles
    public class Automobile : Vehicle


    {
        private string transType;

        public Automobile(string vType, string distance, string avgSpeed, string transType) : base(vType, distance, avgSpeed) //call base class
        {
            this.TransType = transType;
        }



        public string TransType
        {
            get
            {
                return transType;
            }
            set
            {
                transType = value;
            }
        }



        public override string displayInfo()//overrides the display method
        {
            Trip trip = new Trip(this.VType, this.AvgSpeed, this.Distance);
            return base.displayInfo() + "\n" + "Transmission type is: " + this.TransType + "\n" + "Travel time is: " + trip.getTime() + " hours";
        }
    }
}
