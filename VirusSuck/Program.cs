using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var names = new List<string>();

            //add items to the list one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");
            names.Insert(0, "Shebola");

            //remove items from the list. Lists are keyed by their index.
            names.Remove("Stupidity");

            //removes at a certain index
            names.RemoveAt(3);

            //add multiple items (called a collection initalizer, so I don't need the .Add stuff)
            var people = new List<string> { "Nathan", "Martin", "Randy's Kid"};
            names.AddRange(people); // or

            // names.AddRange(new List<string> { "Nathan", "Martin", "Randy's Kid"});

            //remove multiple items
            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //Dictionarys- specialized collections. Takes a key and value. Differnt from a list

            var symptoms = new Dictionary<string, string> ();

            //add single items
            symptoms.Add("COVID-19","Dry cough, fever, respiratory problems");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu","Fever, dry cough, fatigue, can't breath");
            symptoms.Add("SARS", "fever, cough, headache, pains");
            symptoms.Add("Spanish Flue", "fever, headache, excess salivation, musslce spasms, paralysis, and mental confusion");

            //get single thing
            var covidSymptoms = symptoms["COVID-19"];

            //remove single item- BELOW Is just removing the key
            symptoms.Remove("Ebola");

            //collection initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            //destructoring
            foreach ( var (key, value) in symptoms)
            {
                Console.WriteLine($"The {key} virus has the following symptoms: {value}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown.");
                }

            //Queues- also a collection

                var diseasesToCure = new Queue<string>();
                //use enqueue as "add"
                diseasesToCure.Enqueue("SARS");
                diseasesToCure.Enqueue("COVID-19");

                var thingsToCure = diseasesToCure.Dequeue(); //FIRST THING IN, FIRST OUT--- Stack collection is different
                }

            //Hashset- slow to write things(adding), getting things out of is fast

            var vectors = new HashSet<string>();

            vectors.Add("airborne");
            vectors.Add("droplet");
            vectors.Add("bloodborne");

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever"); //symptoms is a property of our virus class
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels Everything except work");
            covid19.NumberOfDeathsWorldWide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever"); 
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldWide = 50000000;

            var rabies = new Virus("rabies", 11);
            rabies.Symptoms.Add("Fever"); 
            rabies.Symptoms.Add("Dry Cough");
            rabies.NumberOfDeathsWorldWide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };
            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumberOfDeathsWorldWide} people.");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }
        }
    }
}
