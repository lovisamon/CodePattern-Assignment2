using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    static class DataRepository
    {
        public static string GetData()
        {
            return SimulatedDatabase.Load("Dataset A");
        }

        public static void SaveData(string data)
        {
            SimulatedDatabase.Save(data);
        }

        public static string GetCustomer()
        {
            return SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
        }

        public static void SaveCustomer(string customer)
        {
            SimulatedDatabase.Save(customer);
        }

        public static string GetAnimal()
        {
            return SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
        }

        public static void SaveAnimal(string animal)
        {
            SimulatedDatabase.Save(animal);
        }
    }
}
