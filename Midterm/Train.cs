using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public class Train : Vehicle


    {
        private string tCarAmount;

        public Train(string vType, string distance, string avgSpeed, string tCarAmount) : base(vType, distance, avgSpeed) //call base class
        {
            this.TCarAmount = tCarAmount;
        }



        public string TCarAmount
        {
            get
            {
                return tCarAmount;
            }
            set
            {
                tCarAmount = value;
            }
        }


        public override string displayInfo()//overrides the display method
        {
            Trip trip = new Trip(this.VType, this.AvgSpeed, this.Distance);
            return base.displayInfo() + "\n" + "Trolly car amount is: " + this.TCarAmount + "\n" + "Travel time is: " + trip.getTime() + " hours";
        }
    }
}


