using Srp.Utils;
using System;

// Single Responsability Principle
namespace Srp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            //Create
            client.CreateCLient();

            //Read
            client.ReadClient();

            //Update
            client.UpdateClient();

            //Delete
            client.DeleteClient();

            Console.WriteLine("Finalizado!");
        }
    }
}
