namespace GitCalc
{
    public class Program
    {
        static void Main()
        {
            decimal num1;
            decimal num2;
            char choice;
            decimal result = 0;
            Console.Write("Enter first number: ");
            num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter action: ");
            choice = char.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = decimal.Parse(Console.ReadLine());
            switch (choice) 
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;

                    break;

                case '*':
                    result = num1 * num2;

                    break;

                case '/':
                    result = num1 / num2;

                    break;

            }
            Console.WriteLine($"{num1} {choice} {num2} = {result} ");

        }
    }
}