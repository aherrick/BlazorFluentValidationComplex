using System.Collections.Generic;

namespace BlazorFluentValidationComplex.Data
{
    public class Parent
    {
        public string Name { get; set; }
        public List<Child> Children { get; set; }
    }

    public class Child
    {
        public string DataKey { get; set; }
        public string DataValue { get; set; }
    }
}