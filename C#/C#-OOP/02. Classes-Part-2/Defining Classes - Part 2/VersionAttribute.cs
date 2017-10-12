using System;

namespace Defining_Classes___Part_2
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)]
    class VersionAttribute:Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute(string input)
        {
            var name = input.Split('.');
            this.Major = int.Parse(name[0]);
            this.Minor = int.Parse(name[1]);
        }
    }
}
