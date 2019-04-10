using System;
using System.Collections.Generic;

namespace myApp
{
    public class Exercise
    {
        private string _name { get; set; }
        private string _language { get; set; }

        public Exercise(string name, string language)
        {
            _name = name;
            _language = language;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {_name}, Language: {_language} ");
        }

    }
}