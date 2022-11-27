using System;

class Program
{
     static void Main (string[] args)
    {
        int choose;
        Console.WriteLine("| ----- Please select the date you want to borrow the book. -----");
        Console.WriteLine("|");
        Console.WriteLine("| Press 1 : 7 days");
        Console.WriteLine("| Press 2 : 15 days");
        Console.WriteLine("|");
        Console.WriteLine("| —--------------------------------------------------------------");
        choose = int.Parse(Console.ReadLine());

        switch(choose){
            case 1: {
                 DateTime today = DateTime.Now;
                 Console.WriteLine("| ---------------------------- 7 days ---------------------------");
                 Console.WriteLine("|");
                 Console.WriteLine("| Book borrowing date : {0}",today);
                 DateTime Deadline = today.AddDays(7);
                 Console.WriteLine("| Book return date (7 days) : {0}",Deadline);
                 Console.WriteLine("|");
                 Console.WriteLine("| --------------- Thank you for using the service. --------------");
            }
            break;
            case 2: {
                 DateTime today = DateTime.Now;
                 Console.WriteLine("| ---------------------------- 15 days --------------------------");
                 Console.WriteLine("|");
                 Console.WriteLine("| Book borrowing date : {0}",today);
                 DateTime Deadline = today.AddDays(15);
                 Console.WriteLine("| Book return date (15 days) : {0}",Deadline);
                 Console.WriteLine("|");
                 Console.WriteLine("| --------------- Thank you for using the service. --------------");
            }
            break;
        }
    }
}