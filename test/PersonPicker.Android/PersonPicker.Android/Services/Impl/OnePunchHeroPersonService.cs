using System;
using System.Collections.Generic;
using PersonPicker.Android.Models;

namespace PersonPicker.Android.Services.Impl
{
    public class OnePunchHeroPersonService : IPersonService
    {
        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Name = "Tatsumaki",
                    Abilities = new [] { "Psychokinesis" },
                    Age = 28,
                    Association = "Hero",
                    Level = "S",
                    Rank = 2
                },
                new Person
                {
                    Name = "Silver Fang",
                    Abilities = new [] { "Superhuman Strength", "Superhuman Agility", "Superhuman Speed" },
                    Age = 81,
                    Association = "Hero",
                    Level = "S",
                    Rank = 3
                },
                new Person
                {
                    Name = "Atomic Samurai",
                    Abilities = new [] { "Swordsmanship" },
                    Age = 37,
                    Association = "Hero",
                    Level = "S",
                    Rank = 4
                },
                new Person
                {
                    Name = "Child Emperor",
                    Abilities = new [] { string.Empty },
                    Age = 10,
                    Association = "Hero",
                    Level = "S",
                    Rank = 5
                },
                new Person
                {
                    Name = "Metal Knight",
                    Abilities = new [] { "Weapons" },
                    Age = 0,
                    Association = "Hero",
                    Level = "S",
                    Rank = 6
                },
                new Person
                {
                    Name = "King",
                    Abilities = new [] { string.Empty },
                    Age = 29,
                    Association = "Hero",
                    Level = "S",
                    Rank = 7
                },
                new Person
                {
                    Name = "Demon Cyborg",
                    Abilities = new [] { "Cyborg Body" },
                    Age = 19,
                    Association = "Hero",
                    Level = "S",
                    Rank = 14
                },
                new Person
                {
                    Name = "Iaian",
                    Abilities = new [] { "Swordsmanship" },
                    Age = 23,
                    Association = "Hero",
                    Level = "A",
                    Rank = 2
                },
                new Person
                {
                    Name = "Saitama",
                    Abilities = new[] { "Super everything "},
                    Age = 25,
                    Association = "Hero",
                    Level = "B",
                    Rank = 7
                }
            };
        }
    }
}