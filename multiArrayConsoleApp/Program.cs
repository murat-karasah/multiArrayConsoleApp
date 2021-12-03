using System;

namespace multiArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[7, 3]
            {
                { "İstanbul","çanakkale","bursa" },
                { "izmir","manisa","muğla" },
                { "antalya","ısparta","mersin" },
                { "konya","ankara","eskişehir" },
                { "zonguldak","trabzon","rize" },
                { "gaziantep","mardin","şanlıurfa" },
                { "ağrı","hakkari","van" }
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("***");

            }

        }
    }
}
