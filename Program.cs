namespace HelloWorld
{
    class Program
    {
        static int program_execution_count = 0;
        static String banner = @"
                                                                            Welcome to

                                        ███    ███  ██████      ██  ██████  ██      ██      ██ ██████  ███████ ███████ 
                                        ████  ████ ██           ██ ██    ██ ██      ██      ██ ██   ██ ██      ██      
                                        ██ ████ ██ ██           ██ ██    ██ ██      ██      ██ ██████  █████   █████   
                                        ██  ██  ██ ██      ██   ██ ██    ██ ██      ██      ██ ██   ██ ██      ██      
                                        ██      ██  ██████  █████   ██████  ███████ ███████ ██ ██████  ███████ ███████ 
        ";

        static String menuScreen = @"
     __  __                                                                                                              ___            _                  
    |  \/  |  ___  _ __   _   _                                                                                         / _ \  _ __  __| |  ___  _ __  ___ 
    | |\/| | / _ \| '_ \ | | | |                                                                                       | | | || '__|/ _` | / _ \| '__|/ __|
    | |  | ||  __/| | | || |_| |                                                                                       | |_| || |  | (_| ||  __/| |   \__ \
    |_|  |_| \___||_| |_| \__,_|                                                                                        \___/ |_|   \__,_| \___||_|   |___/




     ___________________________        ___________________________        ___________________________                  +---------------------------------------+
    |                           |      |                           |      |                           |                 |                                       |
    |     Chicken with Rice     |      |           Burger          |      |           Fries           |                 |               McJollibee              |
    |                           |      |                           |      |                           |                 |                                       |  
    |    ₱100    Code: chkwr    |      |    ₱50    Code: burg      |      |    ₱45    Code: fries     |                 |                                       |
    |___________________________|      |___________________________|      |___________________________|                 |        Edsa Corner Evangelista        |
                                                                                                                        |            Bangkal, Makati            |
                                                                                                                        |              Metro Manila             |
     ___________________________        ___________________________                                                     |                                       |
    |                           |      |                           |                                                    |                                       |
    |           Sundae          |      |         Softdrinks        |                                                    |    Qty    Product             Price   |
    |                           |      |                           |                                                    |                                       |
    |    ₱30    Code: sundi     |      |    ₱20    Code: sftdnk    |                                                    |              -                        |
    |___________________________|      |___________________________|                                                    |              -                        |
                                                                                                                        |              -                        |
                                                                                                                        |              -                        |
                                                                                                                        |
        
        
        ";
        



        static void welcomeScreen() {
            Console.Clear();
            //column, row
            Console.SetCursorPosition(10,15);
            Console.Write(banner);
            
            if (program_execution_count == 0) 
            {
                            }


            Console.ReadLine();
            Console.Clear();
            
        }
        


        static void Main(string[] args)
        {
            program_execution_count += 1;
            welcomeScreen();
            //column, row
            Console.SetCursorPosition(5,0);
            Console.Write(menuScreen);
        }


        
    }
}
