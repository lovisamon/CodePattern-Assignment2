using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");
            var data = DataRepository.GetData();
            var customer = DataRepository.GetCustomer();
            var animal = DataRepository.GetAnimal();
            DataRepository.SaveData(data);
            DataRepository.SaveCustomer(customer);
            DataRepository.SaveAnimal(animal);
            Console.WriteLine();
        }
    }
}