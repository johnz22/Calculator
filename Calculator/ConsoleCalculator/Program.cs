

public class Calculator
{
    public static void Main()
    {
        int Choise = 0;
        int FN;
        int SN;

        while (Choise == 0)
        {
            Console.WriteLine("1. Add Number");
            Console.WriteLine("2. Subtract Number");
            Console.WriteLine("3. Multiply Number");
            Console.WriteLine("4. Divide Number");
            Console.WriteLine("\nPlease choose from 1-4");
            Choise = Convert.ToInt32(Console.ReadLine());
        }
        try
        {
            switch (Choise)
            {
                case 1:
                    Choise = 1;

                    Console.WriteLine("Enter the First Number");
                    FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number");
                    SN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total Equal = {0}", FN + SN);
                    break;
                case 2: Choise = 2;
                    Console.WriteLine("Enter the First Number");
                    FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number");
                    SN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total Equal = {0}", FN - SN);
                    break;
                case 3: Choise = 3;
                    Console.WriteLine("Enter the First Number");
                    FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number");
                    SN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total Equal = {0}", FN * SN);
                    break;
                case 4: Choise = 4;
                    Console.WriteLine("Enter the First Number");
                    FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number");
                    SN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Total Equal = {0}", FN / SN);
                    break;

                default:
                    break;
            }
        }
        catch (Exception e)
        {
            if (Choise < 1 || Choise > 4)
            {
                Console.WriteLine("Please enter numeric value number between 1 to 4");
            }
            else
            {
                Console.WriteLine(e.Message);
            }
        }
    }




}