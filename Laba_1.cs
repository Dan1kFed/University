using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont == 1)
            {
				cont = 0;
				double a = 0, b = 0, c = 0;
			    chekinput(ref a, ref b, ref c, ref cont);
				if (cont == 1)
				{

					double D;
					D = b * b - 4 * a * c;

					if (D == 0)
					{
						Console.WriteLine("Дискриминант равен  " + D);
						double x = (b - b * 2) / 2 * a;
						Console.WriteLine("Корень уравнения равен " + x);

					}
					else if (D > 0)
					{
						Console.WriteLine("Дискриминант равен " + D);
						double sqrtD = Math.Sqrt(D);
						double x1 = (b - b * 2 + sqrtD) / 2 * a;
						Console.WriteLine("Первый корень уравнения равен " + x1);
						double x2 = (b - b * 2 - sqrtD) / 2 * a;
						Console.WriteLine("Второй корень уравнения равен " + x2);

					}
					else
					{
						double sqrtD = Math.Sqrt(D - 2 * D);
						Console.WriteLine("Дискриминант равен " + D);
						Console.WriteLine("Первый корень уравнения равен ( " + (b - b * 2) + "+ i*" + sqrtD + ")/2");
						Console.WriteLine("Второй корень уравнения равен ( " + (b - b * 2) + "- i*" + sqrtD + ")/2");
					}
				}
				cont++;
            }

            Console.ReadKey();
        }
        

		static void chekinput(ref double a, ref double b, ref double c, ref int cont)
		    {
			
			try
			{
				Console.WriteLine("Введите коэффицент a ");
				a = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите коэффицент b ");
				b = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите коэффицент с");
				c = Convert.ToDouble(Console.ReadLine());
				cont++;
			}
				   

			catch (System.FormatException)
                
			{
                    Console.WriteLine("Неверный формат введенных данных, повторите ввод.");
            }


		}
	}
}
