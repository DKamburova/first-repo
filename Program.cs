change with Tortoise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var a= int.Parse(Console.ReadLine());
            int pregled = 0;
            int nepregled = 0;
            int sum1 = 0;
            int sum2 = 0;
            int lek = 7;
            for (var i = 1;i<=a;i++)
            {
                var y = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (sum1 > sum2) lek++;
                }

                if (y >=lek)
                {
                    nepregled = y - lek;
                    pregled = lek;
                }
                else
                {
                    nepregled = 0;
                    pregled = y;
                }
                sum1 += nepregled;
                sum2 += pregled;
            }
            Console.WriteLine("Treated patients: {0}",sum2);
            Console.WriteLine("Untreated patients: {0}", sum1);
        }
    }
}
