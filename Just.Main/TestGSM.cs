namespace Just.Main
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JustGSM.Common;// added reference from classLibrary JustGSM.Common

    /*Define a class that holds information about a mobile phone device: model, manufacturer, 
     * price, owner, battery characteristics (model, hours idle and hours talk) and display 
     * characteristics (size and number of colors). Define 3 separate classes 
     * (class GSM holding instances of the classes Battery and Display).
    */
    class TestGSM
    {
        static void Main()
        {
            List<GSM> GSMList = new List<GSM>();
            /*Write a class GSMTest to test the GSM class: 
             * Create an array of few instances of the GSM class. 
             * Display the information about the GSMs in the array. 
             * Display the information about the static property IPhone4S.
            */
            GSM gsm1 = new GSM("Lumia610", "Nokia", 299.99, "IvanNT", new Battery
                              (TypeBattery.Ni_MH, 6.5F, 0), new Display("50", "80", 16));
            GSMList.Add(gsm1);

            GSM gsm2 = new GSM("IPhone4S", "Apple", 0, "", new Battery(TypeBattery.NA), new Display());
            gsm2.SetIPhone4S("IPhone4S");
            GSMList.Add(gsm2);

            GSM gsm3 = new GSM("S3", "Samsung", 0, " ", new Battery(TypeBattery.NA), new Display());
            GSMList.Add(gsm3);

            for (int i = 0; i < GSMList.Count; i++)
            {
                Console.WriteLine(new string('-', 13) + "GSM  " + (i + 1) + new string('-', 13));
                Console.WriteLine(GSMList[i]);
            }

            CallHistory test = new CallHistory();
            Console.WriteLine();

        }
    }
}
