/*Zadachi za reshavane:
            * 3 ta ot vhodniq izpit
            * Arrays: 13, 18, 19, 20, 21
            * Multidimensional Arrays : 6
            * Methods : 15
            * Strings : 11, 13, 14, 15, 17, 18, 19, 20, 21, 22, 24, 25
            * Text files : 10, 13
            * Exception handling : 3 i 4 ne e qsno kolko sa taka
            * ----------------------------------------------------
            * Defining Classes Part 2 - Problem 10 11
            * Bubble Sort
            * Extension Methods, Lambda Expressions and LINQ - 7, 8, 13, 14, 16, 20
            * Linear Data Structures -10, 11, 12 ,13 ,14
            * Recursion - 5, 6, 7, 8, 9, 10, 11, 12
            * Searching Algorithms - 1, 2, 4
            * Dynamic Programming - Live Demo 1 - 1.Trees , 2.HelpDoge , Demos - SubsetSum , MinAndMax i drugite - da si gi preresha 
            * ----------------------------------------------------------------------------------------------------------------------
            * 01. Unit Testing - Demos NUnitDemos Bank.UnitTest BankShould da se napravqt testovete za Bankklasa
            */
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Probni
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car();
            car.Money = 50;
            Console.WriteLine(car.Money);
        }

    }

    public class Car
    {
        private int money;

        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value + 50;
            }
        }
    }
}



