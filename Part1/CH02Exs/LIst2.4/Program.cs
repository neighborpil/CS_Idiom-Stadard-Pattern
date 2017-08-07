using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//메인메소드의 기능 2개를 하나로 분리

namespace LIst2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
                PrintFeetToMeterList(1, 10);
            else if (args.Length >= 1 && args[0] == "-tof")
                PrintMeterToFeetList(1, 10);

               


#if DEBUG
            Console.ReadKey();
#endif
        }

        private static void PrintMeterToFeetList(int start, int stop)
        {
            //meter to feet
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);

                Console.WriteLine("{0} meter = {1:0.0000} m", meter, feet);

            }
        }

        private static void PrintFeetToMeterList(int start, int stop)
        {
            //feet to meter
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        private static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }

        private static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
    }
}
