using System;

namespace Laba_6_2
{
	public class ForInspection
    {
		public ForInspection() { }
        public ForInspection(string str) { }
        public ForInspection(double d) { }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        [NewAttribute("Описание для prop1")]
        public int prop1 { get; set; }

        [NewAttribute("Описание для prop2")]
        public int prop2 { get; set; }

        public int prop3 { get; set; }

        public int[] data;
     }
}

