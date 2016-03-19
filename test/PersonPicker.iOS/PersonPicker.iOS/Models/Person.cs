using System;

namespace PersonPicker.iOS.Models
{
    public class Person
    {
        public string Handle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", LastName, FirstName); }
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

