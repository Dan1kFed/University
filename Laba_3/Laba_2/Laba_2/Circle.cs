using System;
namespace Laba_2
{
	public class Circle : Geometric, IPrint
    {
		public double radius { get; set; }

		public Circle(double radius)
        {
			this.radius = radius;
			this.type = "Круг";
        }

		public override double Square()
		{
			double pi = 3.14;
			return this.radius*this.radius*pi;
		}

		public void Print() 
        { 
            string str = this.ToString() + "Радиус круга=" + this.radius.ToString(); 
            Console.WriteLine(str); 
        } 


	}
}



