

public class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Title = "Calculator Menu";
            Console.WriteLine("Welcome, What Would you like to do");
            Console.WriteLine("");
            Console.WriteLine("[1]. Add Number");
            Console.WriteLine("[2]. Subtract Number");
            Console.WriteLine("[3]. Multiply Number");
            Console.WriteLine("[4]. Divide Number");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("");
            Console.WriteLine("Please choose from 1-5");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Add();
            }

            else if (input == "2")
            {
                Multiply();
            }
            else if (input == "3")
            {
                Divide();
            }

            else if (input == "4")
            {
                Subtract();
            }

            else if (input == "5")
            {
                Console.WriteLine("Good Bye");
                Environment.Exit(0);
            }
        }
    }

    static decimal Add()
    {
        Console.WriteLine("Enter First Number");
        var FN = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Nnumber");
        var SN = Decimal.Parse(Console.ReadLine());

        var Add = FN + SN;
        Console.WriteLine($"Total = {Add}");
        return (Add);
    }
    static decimal Multiply()
    {
        Console.WriteLine("Enter First Number");
        var FN = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Nnumber");
        var SN = Decimal.Parse(Console.ReadLine());

        var Multiply = FN * SN;
        Console.WriteLine($"Total = {Multiply}");
        return (Multiply);
    }
    static decimal Divide()
    {
        Console.WriteLine("Enter First Number");
        var FN = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Nnumber");
        var SN = Decimal.Parse(Console.ReadLine());

        var Divide = FN / SN;
        Console.WriteLine($"Total = {Divide}");
        return (Divide);
    }
    static decimal Subtract()
    {
        Console.WriteLine("Enter First Number");
        var FN = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Nnumber");
        var SN = Decimal.Parse(Console.ReadLine());

        var Subtract = Convert.ToDecimal(FN - SN);
        Console.WriteLine($"Total = {Subtract}");
        return (Subtract);
    }
}