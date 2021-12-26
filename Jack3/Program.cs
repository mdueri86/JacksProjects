using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Jack j = new Jack();
            j.height = 40;
            j.weight = 80;


            Jack j2 = new Jack();
                j.eyecolor = "Green";

            Console.WriteLine(j.eyecolor);
            Console.WriteLine(j2.eyecolor);

            Console.ReadKey();

            // some more stuff for the A branch.
        }
    }


    public class Jack
    {
        public int weight = 0;
        public int height = 0;
        public string eyecolor = "blue";

        
    }

}
