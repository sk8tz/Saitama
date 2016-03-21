using System;

namespace PersonPicker.Android.Services.Impl
{
    public class RandomNumberService : INumberService
    {
        public int GetNumber()
        {
            var random = new Random(DateTime.Now.Second);
            return random.Next();
        }
    }
}