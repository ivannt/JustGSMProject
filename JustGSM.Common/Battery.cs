namespace JustGSM.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /*
     * Define several constructors for the defined classes that take different sets of arguments 
     * (the full information for the class or part of it)*/
    public class Battery
    {
        public TypeBattery Model { get; set; }
        public double? Idle { get; set; }
        public double? Talk { get; set; }

        public Battery()
        {

        }

        public Battery(TypeBattery model, double idle, double talk)
        {
            this.Model = model;
            this.Idle = idle;
            this.Talk = null;
        }
        public Battery(TypeBattery model)
        {
            this.Model = model;
        }

        /*Add a method in the GSM class for displaying all information about it. 
         * Try to override ToString().
         */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Battery model:       " + Model);
            sb.Append("\n");
            sb.Append("Battery hour idle:   " + Idle);
            sb.Append("\n");
            sb.Append("Battery hour talk:   " + Talk);
            return sb.ToString();
        }
    }
}
