namespace CharacterCreation
{
    internal class Program : Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome to character creation! ==========");
            DataClass dc = new DataClass();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:\n1. Create a character.\n2. Display characters.\n3. Delete a character.\n4. Exit.");
                int menu = Menu();
                switch (menu)
                {
                    case 1:
                        new Game();
                        break;
                    case 2:
                        dc.Display();
                        break;
                    case 3:
                        dc.Delete();
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
            Console.WriteLine("Thanks for playing and goodbye!");

        }
    }
}
