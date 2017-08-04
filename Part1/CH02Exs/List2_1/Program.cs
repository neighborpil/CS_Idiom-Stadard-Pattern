using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 피트로부터 미터로 대응표를 출력
            for (int feet = 0; feet <= 10; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }

#if DEBUG
            Console.ReadKey();
#endif

        }

        // 피트로부터 미터를 요구
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
    }
}
