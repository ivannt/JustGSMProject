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
    public class Display
    {
        public string SizeHeight { get; set; }
        public string SizeWidth { get; set; }
        public long? Colors { get; set; }


        public Display()
        {

        }

        public Display(string sizeWidth, string sizeHeight, long colors)
        {
            this.SizeHeight = sizeHeight;
            this.SizeWidth = sizeWidth;
            this.Colors = colors;
        }

        /*Add a method in the GSM class for displaying all information about it. 
         * Try to override ToString().
        */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("Display size Width:  " + SizeWidth);
            sb.Append("\n");
            sb.Append("Display size Height: " + SizeHeight);
            sb.Append("\n");
            sb.Append("Color in million:    " + Colors);
            sb.Append("\n");
            return sb.ToString();
        }
    }
}