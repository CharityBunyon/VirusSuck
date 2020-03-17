using System;
using System.Collections.Generic;
using System.Text;

namespace VirusSuck
{
    class Virus
    {
        //properties, fields, methods

        public string Name { get; set; }
        public List<string> Symptoms { get; set; }
        public int NumberOfDeathsWorldWide { get; set; }
        public int IncubationDays { get; set; }

        //constructor
        public Virus(string name, int incubationDays)
        {
            Name = name;
            IncubationDays = incubationDays;
            Symptoms = new List<string>();
        }
    }
}
