using System;
namespace Laba_2
{
	public class FigureMatrixCheckEmpty : ICheckMatrixEmpty<Geometric>
    {
		public Geometric getEmptyElement()
        {
            return null;
        }

		public bool checkEmptyElement(Geometric element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
