// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the To-Do List Program");

        int answer = 0;
        string to_add;
        int to_remove;

        List<string> li = new List<string>();
        

        while (answer != 4)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter 1 to add a task to the list");
            Console.WriteLine("Enter 2 to remove a task from the list");
            Console.WriteLine("Enter 3 to view the list");
            Console.WriteLine("Enter 4 to exit the program");

            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Add the task here");
                to_add = Console.ReadLine();
                li.Add(to_add);
                Console.WriteLine("Your list is: ");
                foreach (string item in li)
                {
                    Console.WriteLine($"{item}");
                }



            }
            else if (answer == 2)
            {
                Console.WriteLine(li);
                Console.WriteLine("Which task would you like to remove?");
                Console.WriteLine("Kindly type the position of the number in the list, eg. 1, 2 ");
                to_remove = Convert.ToInt32(Console.ReadLine());
                li.RemoveAt(to_remove);
   


            }
            else if (answer == 3)
            {
                foreach (string g in li)
                {
                    Console.WriteLine($"{g}");
                }
            }
            else if (answer == 4)
            {
                Console.WriteLine("Exiting Program please");

            }

        }


    }

}
