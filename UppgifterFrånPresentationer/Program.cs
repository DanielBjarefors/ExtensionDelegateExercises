using System;
using System.Text;
using System.Threading;
using static UppgifterFrånPresentationer.Student;

namespace UppgifterFrånPresentationer
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder boho = new StringBuilder("0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19");
            //Console.WriteLine(boho);
            //Console.WriteLine(boho.Substring(4, 10));
            //Console.WriteLine("-----------------------------------");

            //float[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(numbers.SumEnum());
            //Console.WriteLine("-----------------------------------");

            //Student[] stud = {
            //    new Student("Alf","Zero",12),
            //    new Student("Janne", "Grillspade", 17),
            //    new Student("Kalle", "Woho", 20),
            //    new Student("Bingo", "Zubbles", 22),
            //    new Student("Lennart", "Klok", 55),
            //    new Student("Qwerty", "Mobav", 44),
            //};

            //foreach (var e in SortName(stud))
            //{
            //    Console.WriteLine(e.Fname+"  "+e.Lname);
            //}
            //Console.WriteLine("-----------------------------------------");

            //foreach (var e in BetweenAge(stud))
            //{
            //    Console.WriteLine(e.Fname + "  " + e.Lname);
            //}
            //Console.WriteLine("-------------------------------------------");

            //foreach (var e in SortStudents(stud))
            //{
            //    Console.WriteLine(e.Fname + "  " + e.Lname);
            //}
            //Console.WriteLine("-------------------------------------------");
            //ListOfNumbers.Divide();
            //Console.WriteLine("-------------------------------------------");


            Timer.Interval(Timer.MyMethod,5,2);
            Timer.Interval(ListOfNumbers.Divide,4,2);
        }
       

    }
}
