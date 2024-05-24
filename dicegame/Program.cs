class DiceGame
{
    static void Main(string[] args)
    {
        int playerRandomNum;
        int enemyRandomNum;
        int playerPoints = 0;
        int enemyPoints = 0;
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press any key to roll the dice.");
            playerRandomNum = random.Next(1,7);
            Console.WriteLine("You rolled a "+ playerRandomNum);

            enemyRandomNum = random.Next(1,7);
            Console.WriteLine("Enemy AI rolled a "+ enemyRandomNum);

            Console.WriteLine("....");
            System.Threading.Thread.Sleep(1000);
            if (playerRandomNum > enemyRandomNum) 
            { 
                playerPoints++;
                Console.WriteLine("Player wins this round");
            }
            else if (enemyRandomNum > playerRandomNum)
            {
                enemyPoints++;
                Console.WriteLine("Enemy wins this round");
            }
            else
            {
                Console.WriteLine("You draw");
            }
            Console.WriteLine("The score is now " + playerPoints + ".Enemy: " + enemyPoints+".");
            Console.WriteLine();

        }
        if (playerPoints > enemyPoints) 
        { 
            Console.WriteLine("You win");
        }
        else if (enemyPoints > playerPoints) 
        { 
            Console.WriteLine("You lose");
        }
        else
        {
            Console.WriteLine("You draw");
        }
        Console.ReadKey();
        

    }
}