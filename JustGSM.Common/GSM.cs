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

    public class GSM
    {
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private double Price { get; set; }
        private string Owner { get; set; }
        private Battery battery { get; set; }
        private Display display { get; set; }
        /*Add a property CallHistory in the GSM class to hold a list of the performed calls. 
         * Try to use the system class List<Call>.
        */
        public List<Calls> CallHistory { get; set; }
        /* Add a static field and a property IPhone4S in the GSM class
         * to hold the information about iPhone 4S*/
        static string IPhone4S { get; set; }

        public string GetIPhone4S()
        {
            return IPhone4S;
        }

        public void SetIPhone4S(string value)
        {
            IPhone4S = value;
        }

        public GSM()
        {

        }

        public GSM(string model, string manufacturer, double price, string owner, Battery Battery, Display Display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = Battery;
            this.display = Display;
            CallHistory = new List<Calls>();
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = (Convert.ToInt32(null));
            this.Owner = null;
            this.battery = null;
            this.display = null;
            CallHistory = new List<Calls>();
        }

        /*Add a method in the GSM class for displaying all information about it. 
         * Try to override ToString().
        */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Model:               " + this.Model);
            sb.Append("\n");
            sb.Append("Manufacturer:        " + this.Manufacturer);
            sb.Append("\n");
            sb.Append("Price:               " + this.Price + "lv.");
            sb.Append("\n");
            sb.Append("Owner:               " + this.Owner);
            sb.Append("\n");
            if (this.battery != null || this.display != null)
            {
                sb.Append(this.battery.ToString());
                sb.Append(this.display.ToString());
            }
            return sb.ToString();
        }
        /* Add methods in the GSM class for adding and deleting calls from the calls history. 
         * Add a method to clear the call history.
        */
        public void AddCall(Calls call)
        {
            CallHistory.Add(call);
        }

        public void ClearCallByIndex(int i)
        {
            CallHistory.RemoveAt(i);
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }
        /* Add a method that calculates the total price of the calls in the call history. 
         * Assume the price per minute is fixed and is provided as a parameter.
        */
        public double TotalPrice(double price)
        {
            double total = 0;

            foreach (Calls dur in this.CallHistory)
            {
                total = (dur.Durations() * price) / 60;
            }
            return total;
        }
    }
}
