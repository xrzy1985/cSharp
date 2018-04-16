using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    // Create the struct outside of the Class

    struct Customers
    {
        // Set the fields to be private
        private string name;
        private double balance;
        private int idNo;

        // Our "constructor" for our struct
        // this is the way to create a struct
        public void createCustomer(string n, double b, int i)
        {
            name = n;
            balance = b;
            idNo = i;
        }

        //
        public void displayData()
        {
            Console.WriteLine("Customer Struct Display");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("ID: {0}", idNo);

        // END displayData
        }
    //END of Customers
    }

    class CSharp
    {
        static void Main(string[] args)
        {
            // Struct

            // Once our struct is defined
            // create a Customer name = new Customer()
            Customers james = new Customers();

            // name.createCustomer(name, balance, idNo)
            james.createCustomer("James Patterson", 3450.45, 1111);

            // name.displayData()
            james.displayData();

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        //END of Main
        }
    // END of cSharp
    }
//END of namespace std
}
