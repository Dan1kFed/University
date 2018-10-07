using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
	public abstract class Geometric : IComparable
    {
       
        public string type { get; set; }
		public abstract double Square();
        public override string ToString()
        {
            return this.type + " Площадь = " + this.Square().ToString();  
        }


		public int CompareTo(object obj)
        {
			Geometric p = (Geometric)obj;

			if (this.Square() < p.Square())
                return -1;
			else if (this.Square() == p.Square())
                return 0;
            else
                return 1;
        }
    }
}
