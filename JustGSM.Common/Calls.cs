namespace JustGSM.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /* Create a class Call to hold a call performed through a GSM. It should contain date, 
     * time, dialed phone number and duration (in seconds).
    */
    public class Calls
    {
        private DateTime Date { get; set; }
        private TimeSpan Time { get; set; }
        private string PhoneNumber { get; set; }
        private double durations { get; set; }

        public double Durations()
        {
            return durations;
        }

        public Calls(DateTime date, string phone, double duration)
        {
            this.Date = date.Date;
            this.Time = date.TimeOfDay;
            this.PhoneNumber = phone;
            this.durations = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("Call date: " + this.Date);
            sb.Append("\n");
            sb.Append("Call time: " + this.Time);
            sb.Append("\n");
            sb.Append("Call phone: " + this.PhoneNumber);
            sb.Append("\n");
            sb.Append("Call duration: " + this.durations);
            sb.Append("\n"); sb.Append("\n");
            return sb.ToString();
        }
    }
}
