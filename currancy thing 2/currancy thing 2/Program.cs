using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currancy_thing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float GBP = 0;
            string Currensy = "";
            string staff = "";
            float new_currensy = 0;
            float fee = 0;
            float discount = 0;
            float T_fee = 0;
            float total = 0;
            float total_wDis = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter amount of pounds: ");
                    GBP = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter a valled number bettween 0 and 2500");
                }
                if (GBP <= 2500)
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the currensy you want(USD)(EUR)(BRL)(JPY)(TRY): ");
                    Currensy = (Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter a valled currensy");
                }
                if (Currensy == "USD")
                {
                    break;
                }
                else if (Currensy == "EUR")
                {
                    break;
                }
                else if (Currensy == "BRL")
                {
                    break;
                }
                else if (Currensy == "JPY")
                {
                    break;
                }
                else if (Currensy == "TRY")
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Is the customer a member of staff Y/N: ");
                    staff = (Console.ReadLine());
                }
                catch
                { 
                    Console.WriteLine("Enter a valled answer Y/N");
                }
                if (staff == "Y")
                {
                    break;
                }
                else if (staff == "N")
                {
                    break;
                }
            }


            if (Currensy == "USD")
            {
                new_currensy = GBP * 1.40f;
            }
            else if (Currensy == "EUR")
            {
                new_currensy = GBP * 1.14f;
            }
            else if (Currensy == "BRL")
            {
                new_currensy = GBP * 4.77f;
            }
            else if (Currensy == "JPY")
            {
                new_currensy = GBP * 151.05f;
            }
            else if (Currensy == "TRY")
            {
                new_currensy = GBP * 5.68f;
            }


            if (GBP <= 300)
            {
                fee = 0.035f;
            }
            else if (GBP >= 300 && GBP < 750)
            {
                fee = 0.03f;
            }
            else if (GBP >= 750 && GBP < 1000)
            {
                fee = 0.025f;
            }
            else if (GBP >= 1000 && GBP < 2000)
            {
                fee = 0.02f;
            }
            else if (GBP >= 2000)
            {
                fee = 0.015f;
            }


            if (staff == "Y")
            {
                discount = 0.05f;
            }

            T_fee = GBP * fee;

            if (staff == "Y")
            {
                total = GBP + T_fee;
                total_wDis = total * discount;
                total = total - total_wDis;
                Console.WriteLine("Total cost £" + total + " for " + new_currensy + " " + Currensy);
            }
            else
            {
                total = GBP + T_fee;
                Console.WriteLine("Total cost £" + total + " for " + new_currensy + " " + Currensy);
            }

            Console.ReadKey();
        }
    }
}