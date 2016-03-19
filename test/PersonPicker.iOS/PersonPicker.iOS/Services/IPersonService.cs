using System;
using PersonPicker.iOS.Models;
using System.Collections.Generic;

namespace PersonPicker.iOS.Services
{
    public interface IPersonService
    {
        IList<Person> GetPeople();
    }
}

