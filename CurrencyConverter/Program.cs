namespace NkrumHub
{
    class Program
    {
        static void Main(string[] args) 
        {
            string response1;
            int response2;  
            float money;


            Console.WriteLine("Welcome to the currency converter app.");
            Console.WriteLine("Please enter 'c' to begin");


            response1 = Console.ReadLine();

            Console.WriteLine("Please enter the following to convert: 1. Dollars to Ghana Cedis 2. Euros to Ghana Cedis 3. Pounds to Ghana cedis ");
            response2=Convert.ToInt32(Console.ReadLine());  
            
            Console.WriteLine("Please enter your amount in your respective currencies");

            money = Convert.ToSingle(Console.ReadLine());

            switch (response2)
            {
                case 1:
                    Console.WriteLine(money + " dollars is equivalent to "+ money * 14.74+ " Ghana Cedis");
                        break;

                case 2:
                    Console.WriteLine(money + " euros is equivalent to " + money * 16 + " Ghana Cedis");
                    break;

                case 3:
                    Console.WriteLine(money + " pounds is equivalent to " + money * 18.77 + " Ghana Cedis");
                    break; 

            }





        }


    }
    
    
}