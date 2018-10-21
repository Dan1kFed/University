using System;


namespace Laba_6_2
{
	[AttributeUsage(AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = false)]
    public class NewAttribute : Attribute
    {
        public NewAttribute() { }

        public NewAttribute(string DescriptionParam)
        {
            Description = DescriptionParam;
        }

        public string Description { get; set; }
    }
}
