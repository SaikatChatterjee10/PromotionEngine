using System;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            const int unit_price_a = 50, unit_price_b = 30, unit_price_c = 20, unit_price_d = 15;
            const int active_promotion_3a = 130, active_promotion_2b = 45, active_promotion_cd = 30;
            int totalPrice = 0;
            Console.WriteLine("Enter the values of A B C D");
            int[] scenario = new int[4];
            scenario = (Console.ReadLine().Split(" ").Select(int.Parse).ToArray());


            totalPrice += (scenario[0] / 3) * active_promotion_3a + (scenario[0] % 3) * unit_price_a;
            totalPrice += (scenario[1] / 2) * active_promotion_2b + (scenario[1] % 2) * unit_price_b;
            if (scenario[3] == 0 || scenario[2] == 0)
            {
                totalPrice += scenario[2] * unit_price_c + scenario[3] * unit_price_d;
            }
            else
            {
                totalPrice += active_promotion_cd;
            }
            Console.WriteLine(totalPrice);

        }
    }
}
