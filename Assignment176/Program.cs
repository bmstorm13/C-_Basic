﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment176
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.ID = 1;
            //employee.SayName(employee.FirstName, employee.LastName);

            //Employee employee2 = new Employee();
            //employee2.FirstName = "Student";
            //employee2.LastName = "Sample";
            //employee2.ID = 2;
            //employee2.SayName(employee2.FirstName, employee2.LastName);

            //employee.CheckID(employee.ID, employee2.ID);  //this is for step 184

            //IQuittable quitter = new Employee();  //this was step 179
            //quitter.Quit();

            List<string> things = new List<string> {"phone","cup","shoe","watch" };  //187
            foreach (object thing in things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        
        
            

            List<int> things2 = new List<int> { 1, 2, 3, 4 };       //187
            foreach (object thang in things2)
            {
                Console.WriteLine(thang);
            }
            Console.ReadLine();



        }



    }
}