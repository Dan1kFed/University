using System;
namespace Laba_2
{
    public interface ICheckMatrixEmpty<T>
    {
		T getEmptyElement();
        bool checkEmptyElement(T element);
    }
}
