using System;
namespace Laba_2
{
	public class Quadro : Rectangle, IPrint
    {
		static readonly double  withion;
		public double side;

		public Quadro(double lengthion) : base(lengthion, withion) 
        {
			this.side = lengthion;
			this.type = "Квадрат";
        }

		public override double Square()
		{
			return this.side*this.side;
		}
        
		new public void Print() 
        { 
            string str = this.ToString() + "Сторона квадрата=" + this.side.ToString(); 
            Console.WriteLine(str); 
        } 
	}
}
