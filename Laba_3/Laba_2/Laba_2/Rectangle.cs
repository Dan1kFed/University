using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
	public class Rectangle : Geometric, IPrint
	{
		public double width { get; set; }
		public double length { get; set; }

		public Rectangle(double width, double length)
        {
			this.length = length;
			this.width = width;
			this.type = "Прямоугольник";
        }

		public override double Square()
		{
			return this.width*this.length;
		}

		public void Print()
        {
			string str = this.ToString() + " Стороны прямоугольника " + this.length.ToString() + this.width.ToString();
			Console.WriteLine(str);
        }
	}
}
