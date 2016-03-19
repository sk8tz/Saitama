using System;
using System.Collections.Generic;
using PersonPicker.iOS.Models;

namespace PersonPicker.iOS.Services.Impl
{
    public class SaoPersonService : IPersonService
    {
        #region IPersonService implementation

        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Handle = "Kirito",
                    FirstName = "Kazuto",
                    LastName = "Kirigaya",
                    Age = 17,
                    Gender = Gender.Male
                },

                new Person
                {
                    Handle = "Asuna",
                    FirstName = "Asuna",
                    LastName = "Yuuki",
                    Age = 18,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Sinon",
                    FirstName = "Shino",
                    LastName = "Asada",
                    Age = 16,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Yuuki",
                    FirstName = "Yuuki",
                    LastName = "Konno",
                    Age = 15,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Leafa",
                    FirstName = "Suguha",
                    LastName = "Kirigaya",
                    Age = 16,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Healthcliff",
                    FirstName = "Akihiko",
                    LastName = "Kayaba",
                    Age = 28,
                    Gender = Gender.Male
                },

                new Person
                {
                    Handle = "Yui-MHCP001",
                    FirstName = "Yui",
                    LastName = string.Empty,
                    Age = 0,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Silica",
                    FirstName = "Keiko",
                    LastName = "Ayano",
                    Age = 15,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Lisbeth",
                    FirstName = "Rika",
                    LastName = "Shinozaki",
                    Age = 18,
                    Gender = Gender.Female
                },

                new Person
                {
                    Handle = "Agil",
                    FirstName = "Miruzu",
                    LastName = "Girubaato",
                    Age = 30,
                    Gender = Gender.Male
                },

                new Person
                {
                    Handle = "Klein",
                    FirstName = "Ryootaroo",
                    LastName = "Tsuboi",
                    Age = 25,
                    Gender = Gender.Male
                }
            };
        }

        #endregion
    }
}

