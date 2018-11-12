using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructuresCode.SortedList
{
    public class EmployeeTracker
    {
        public void DisplayEmployeesNameAge()
        {
            System.Collections.SortedList nameAge = new System.Collections.SortedList();
            nameAge.Add("Alicia", 30);
            nameAge.Add("Mike", 29);
            nameAge.Add("Adam", 22);
            nameAge.Add("Andrew", 39);


            for (int i = 0; i < nameAge.Count; i++)
            {
                Console.WriteLine("{0}: {1}", nameAge.GetKey(i), nameAge.GetByIndex(i));
            }
        }
    }
}
