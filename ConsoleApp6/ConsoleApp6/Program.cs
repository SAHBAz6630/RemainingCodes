using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Patient> patients = new List<Patient>();

            Console.WriteLine("Welcome to Sahbaz khan Hospital!");

            while (true)
            {
                Console.WriteLine("\nSelect a department for treatment:");
                Console.WriteLine("1. General              : 400");
                Console.WriteLine("2. ENT                  : 800");
                Console.WriteLine("3. Cardiology           : 1200");
                Console.WriteLine("4. Operation Theater    : 5000");
                Console.WriteLine("5. Intensive care Unit  : 6000");

                int departmentChoice;
                if (int.TryParse(Console.ReadLine(), out departmentChoice))
                {
                    if (departmentChoice >= 1 && departmentChoice <= 5)
                    {
                        Console.WriteLine("Enter patient details:");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Gender: ");
                        string gender = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("State: ");
                        string state = Console.ReadLine();
                        Console.Write("Pincode: ");
                        string pincode = Console.ReadLine();


                        Patient newPatient = new Patient(firstName, lastName, gender, age, phoneNumber, state, pincode);
                        patients.Add(newPatient);

                        Console.WriteLine("Patient added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid department choice. Please select a valid department.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric choice.");
                }
            }
        }
    }
}

    

   