using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{


    public class Trip : Vehicle


    {
        private string distance;

        public Trip(string vType, string avgSpeed, string distance) : base(vType, distance, avgSpeed) //call base class
        {
            this.Distance = distance;
        }



        public string Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }
        public double getTime()
        {
            double time = 0;

            //catch overflow
            try
            {
                time = (Convert.ToDouble(distance) / Convert.ToDouble(this.AvgSpeed));
            }
            catch (OverflowException)
            {
                MessageBox.Show("You entered a number too big!", "FOOL");
            }
            catch (FormatException)
            {
                MessageBox.Show("Can only enter numbers!", "FOOL");
            }

            return Math.Round(time, 2);


        }

        public override string displayInfo()//overrides the display method
        {
            return base.displayInfo() + "\n" + "Time is: " + this.getTime();
        }
    }
}
