using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public class Plane : Vehicle


    {
        private string engType;

        public Plane(string vType, string distance, string avgSpeed, string engType) : base(vType, distance, avgSpeed) //call base class
        {
            this.EngType = engType;
        }



        public string EngType
        {
            get
            {
                return engType;
            }
            set
            {
                engType = value;
            }
        }


        public override string displayInfo()//overrides the display method
        {
            Trip trip = new Trip(this.VType, this.AvgSpeed, this.Distance);
            return base.displayInfo() + "\n" + "Engine is: " + this.EngType + "\n" + "Travel time is: " + trip.getTime() + " hours";
        }
    }
}


