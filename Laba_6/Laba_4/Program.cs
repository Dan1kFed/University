using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Laba_4
{
	delegate string Numberator(double x, string made);
    
    class MainClass
    {
		static void TestFunction_1(string desription, double x, string made, Numberator func)
        {
            Console.Write(desription + ": \n");
            Console.WriteLine(func(x, made));
        }
        
		static void TestFunction_2(string desription, double x, string made, Func<double, string, string> func)
        {
            Console.Write(desription + ": \n");
            Console.WriteLine(func(x, made));
        }


        static string NumberatorFunc(double x, string made)
        {
            string tmp = made;
            for (int i = 0; i < 5; ++i)
			{
				x *= 2;
				Console.WriteLine(x);
			}
            return tmp;
        }

        public static void Main(string[] args)
        {
			string made = "Делегаты - круто";
			double x = 2;

			Console.WriteLine("Делегат Numbarator:");
            TestFunction_1("Передача функции", x, made, NumberatorFunc);
            TestFunction_1("Передача лямбда-выражения", x, made, (z, y) => z + y.ToString());

			Console.WriteLine("\nОбобщенный делегат:");
			TestFunction_2("Передача функции", x, made, NumberatorFunc);
			TestFunction_2("Передача лямбда-выражения", x, made, (z, y) => z + y.ToString());
        }
    }
}
