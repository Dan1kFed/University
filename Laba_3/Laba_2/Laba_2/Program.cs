using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Rectangle rectangle_1 = new Rectangle(2,4);
			Quadro quadro_1 = new Quadro(5);
			Circle circle_1 = new Circle(5);

            
			Console.WriteLine("ArrayList");
			ArrayList arrayList = new ArrayList();
			arrayList.Add(rectangle_1);
			arrayList.Add(quadro_1);
			arrayList.Add(circle_1);

			foreach (var fig in arrayList)
            {
                Console.WriteLine(fig.ToString());
            }

			arrayList.Sort();

            Console.WriteLine("\nArrrayList после сортировки");

            foreach (var fig in arrayList)
            {
                Console.WriteLine(fig.ToString());
            }



            Console.WriteLine("\nList");
			List<Geometric> list = new List<Geometric>();
			list.Add(rectangle_1);
			list.Add(quadro_1);
			list.Add(circle_1);

            foreach (var fig in list)
            {
                Console.WriteLine(fig.ToString());
            }

            list.Sort();

            Console.WriteLine("\nList после сортировки");

            foreach (var fig in list)
            {
                Console.WriteLine(fig.ToString());
            }


			Console.WriteLine("\nМатрица");
			DimensMatrix<Geometric> cube = new DimensMatrix<Geometric>(3, 3, 3, new FigureMatrixCheckEmpty());
            cube[0, 0, 0] = rectangle_1;
			cube[1, 1, 1] = quadro_1;
            cube[2, 2, 2] = circle_1;
            Console.WriteLine(cube.ToString());
            Console.WriteLine("\nСписок");

			SimpleList<Geometric> simpleList = new SimpleList<Geometric>();
			simpleList.Add(quadro_1);
            simpleList.Add(rectangle_1);
            simpleList.Add(circle_1);
            foreach (var x in simpleList) Console.WriteLine(x);
            simpleList.Sort();
            Console.WriteLine("\nСортировка списка");
            foreach (var x in simpleList) Console.WriteLine(x);


            Console.WriteLine("\nСтек");
			SimpleStack<Geometric> stack = new SimpleStack<Geometric>();
            stack.Push(rectangle_1);
			stack.Push(quadro_1);
            stack.Push(circle_1);
            while (stack.Count > 0)
            {
				Geometric f = stack.Pop();
                Console.WriteLine(f);
            }



        }
    }
}
