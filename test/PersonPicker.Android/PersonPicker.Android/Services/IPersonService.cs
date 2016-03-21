using System.Collections.Generic;
using PersonPicker.Android.Models;

namespace PersonPicker.Android.Services
{
    public interface IPersonService
    {
        IList<Person> GetPeople();
    }
}