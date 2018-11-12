using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.Dictionary
{
    public class DictionaryExamples
    {
        public void DisplayAnimalCategorization()
        {
            Dictionary<string, string> animals = new Dictionary<string, string>();
            animals.Add("cat", "feline");
            animals.Add("dog", "canine");

            foreach (KeyValuePair<string, string> pair in animals)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
        }
        public void DisplayMonthSeason()
        {
            Dictionary<string, string> monthsInSeason = new Dictionary<string, string>();
            monthsInSeason.Add("December", "winter");
            monthsInSeason.Add("July", "summer");
            monthsInSeason.Add("October", "fall");
            monthsInSeason.Add("April", "spring");

            Console.Write("Enter a month: ");
            string key = (Console.ReadLine());

            foreach (KeyValuePair<string, string> month in monthsInSeason)
            {
                if (month.Key == key)
                    Console.WriteLine("Month " + month.Key + " is of season " + month.Value);
            }
        }
        public void DisplayEmployeeIdName()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1337, "Terrill");
            employees.Add(1234, "Heinisch");
            employees.Add(9541, "Carlson");

            Console.Write("Enter an employee name: ");
            string value = Console.ReadLine();
            foreach (KeyValuePair<int, string> employee in employees)
            {
                if (employee.Value == value)
                    Console.WriteLine($"Employee ID: {employee.Key} Employee Name: {employee.Value}");
            }
        }
    }
}
