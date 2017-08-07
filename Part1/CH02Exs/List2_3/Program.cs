using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//단위 변환 메소드의 기능 분리

namespace List2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 1 && args[0] == "-tom")
            {
                //feet to meter
                for (int feet = 0; feet <= 10; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
                }
            }
            else if(args.Length >= 1 && args[0] == "-tof")
            {
                //meter to feet
                for (int meter = 0; meter <= 10; meter++)
                {
                    double feet = MeterToFeet(meter);

                    Console.WriteLine("{0} meter = {1:0.0000} m", meter, feet);

                }
            }


#if DEBUG
            Console.ReadKey();
#endif
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
