// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        string answer;
        int result=0;


        Console.WriteLine("Hello, Welcome to the Elvis's calculator program!");
        Console.WriteLine("Please enter your first number");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which Operation would you like to perform?");
        Console.WriteLine("Kindly select A for addition, S for subtraction, D for Divison and M for Multiplication");

        answer = Console.ReadLine();
        
        if (answer == "A")
        {
            result= num1 + num2;
        }

        else if (answer == "S")
        {
            result= num1 - num2;
        }

        else if (answer == "M") 
        {
            result= num1*num2;
        }

        else if (answer == "D")
        {
            result = num1 / num2;
        }

        else
        {
            Console.WriteLine("Kindly enter a valid input");
        }

        Console.WriteLine("The answer is: " + result );

        Console.WriteLine("Thank you for using my simple Calculator");
  }
}

