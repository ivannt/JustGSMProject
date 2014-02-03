namespace JustGSM.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CallHistory
    {
        public CallHistory()
        {
            GSM gsm = new GSM("Lumia610", "Nokia");
            /* Write a class GSMCallHistoryTest to test the call history functionality of the GSM class. 
             * Create an instance of the GSM class. 
             * Add few calls. 
             * Display the information about the calls. 
             * Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history. 
             * Remove the longest call from the history and calculate the total price again. 
             * Finally clear the call history and print it.
            */
            Calls call1 = new Calls(new DateTime(2014, 1, 1, 12, 2, 3), "0896-889-057", 43.0);
            gsm.AddCall(call1);

            Calls call2 = new Calls(new DateTime(2014, 1, 2, 12, 4, 5), "0896-889-037", 111.0);
            gsm.AddCall(call2);

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.WriteLine(new string('-', 13) + "Call " + (i + 1) + new string('-', 13));
                Console.WriteLine(gsm.CallHistory[i]);
            }
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("Best call price:   {0}lv.", gsm.TotalPrice(0.21));
            gsm.ClearCallByIndex(1);
            gsm.ClearHistory();

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Console.WriteLine(new string('-', 13) + "Call number" + (i + 1) + new string('-', 13));
                Console.WriteLine(gsm.CallHistory[i]);
            }
        }
    }
}
