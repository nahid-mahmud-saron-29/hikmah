using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num);

        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine(name);

        if(num>=18)
        {
            Console.Write("You are eligible for voting!");
        }
        else{
            Console.Write("You are not eligible for voting!");
        }
    }
}