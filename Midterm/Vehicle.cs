using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    //Declare main class to be inherited by the rest of the classes
    public class Vehicle
    {
        private string vType;
        private string distance;
        private string avgSpeed;

        public Vehicle()
        { }

        public Vehicle(string vType, string distance, string avgSpeed)
        {
            this.VType = vType;
            this.Distance = distance;
            this.AvgSpeed = avgSpeed;
        }
        public string VType
        {
            get
            {
                return vType;
            }
            set
            {
                vType = value;
            }
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
        public string AvgSpeed
        {
            get
            {
                return avgSpeed;
            }
            set
            {
                avgSpeed = value;
            }
        }


        public virtual string displayInfo()
        {
            return "The vehicle type is " + vType + "\n" + "The average speed is " + avgSpeed;
        }
    }




}

