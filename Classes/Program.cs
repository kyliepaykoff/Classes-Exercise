using System;
using System.Collections.Generic;


namespace Classes
{

    public class Program
    {



        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2020;

            var carList = new List<Car>() { myCar };
            foreach (var car in carList)
            {
                Console.WriteLine($"{myCar.Make} {car.Model} {myCar.Year}");
            }



        }

















    }









}