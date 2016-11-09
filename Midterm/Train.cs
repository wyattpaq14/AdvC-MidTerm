using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Train : Vehicle


    {
        private string tCarAmount;

        public Train(string vType, string avgSpeed, string tCarAmount) : base(vType, avgSpeed) //call base class
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


        public override string displayinfo()//overrides the display method
        {
            return base.displayinfo() + "\n" + "Trolly car amount is: " + this.TCarAmount;
        }
    }
}


