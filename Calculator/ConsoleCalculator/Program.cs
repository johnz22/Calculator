

public class Calculator
{
    public static void Main()
    {
        int Number = 0;

        while (Number == 0)
        {
            Console.Write("Enter number: ");
            try
            {
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 1 || Number > 10)
                {
                    Console.WriteLine("Please enter number between 1 to 10");
                    Number = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter numeric value number between 1 to 10");
            }
        }

        for (int i = 0; i <= 10; i++)
        {
            if (i == 11)
                break;
            Console.WriteLine("{0} x {1} = {2}", Number, i , i * Number);
        }
    }
}