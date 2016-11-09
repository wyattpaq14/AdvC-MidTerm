using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Plane : Vehicle


    {
        private string engType;

        public Plane(string vType, string avgSpeed, string engType) : base(vType, avgSpeed) //call base class
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


        public override string displayinfo()//overrides the display method
        {
            return base.displayinfo() + "\n" + "Engine is: " + this.EngType;
        }
    }
}


