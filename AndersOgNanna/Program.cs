using System;

namespace AndersOgNanna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person Anders = new Person(false, 15, "Anders", "anders@gmail.com", 150000);
            //Nanna kan godt have mindre info end Anders - hun er stadig oprettet
            Person Nanna = new Person(true, 23, "Nanna");
            // Her kalder vi tekst Console.Write for at checke om det virker
            Console.WriteLine("Hello my name is " +Anders.Name +".");
            Console.WriteLine("I am " +Anders.Age + " years old.");
            Anders.HaveABirthday();
            Console.WriteLine("I am now " +Anders.Age + " years old.");
            Console.WriteLine("I have " + Anders.BankAccount + " dollars in my account.");
            Anders.DepositCash(1000);
            Console.WriteLine("I now have " + Anders.BankAccount + " dollars in my account.");
        }
    }

    // Class bliver oprettet her
    public class Person
    {
        public bool IsFemale { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BankAccount { get; set; }
        // Dette er constructor
        public Person(bool isFemale, int age, string name, string email, double bankAccount)
        {
            IsFemale = isFemale;
            Age = age;
            Name = name;
            Email = email;
            BankAccount = bankAccount;
        }
        // Også en constructor - som bliver brugt af Nanna oppe i koden
        public Person(bool isFemale, int age, string name)
        {
            IsFemale = isFemale;
            Age = age;
            Name = name;
        }
        // Dette er en metode
        public void HaveABirthday()
        {
            Age++;
            Console.WriteLine("Yay, i had a birthday!");
        }
        // Også en metode
        public void DepositCash(double amount)
        {
            BankAccount += amount;
            Console.WriteLine("Yay, i got some money!");
        }
    }
}