

using System.Data;

namespace mcJollibee3
{
    class Program
    {
        static int program_execution_count = 0;

        static String banner = @"


                                    ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗        ████████╗ ██████╗ 
                                    ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝        ╚══██╔══╝██╔═══██╗
                                    ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗             ██║   ██║   ██║
                                    ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝             ██║   ██║   ██║
                                    ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗           ██║   ╚██████╔╝
                                    ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝           ╚═╝    ╚═════╝ 
                                                                                                                            
                                        ███╗   ███╗ ██████╗     ██╗ ██████╗ ██╗     ██╗     ██╗██████╗ ███████╗███████╗     
                                        ████╗ ████║██╔════╝     ██║██╔═══██╗██║     ██║     ██║██╔══██╗██╔════╝██╔════╝     
                                        ██╔████╔██║██║          ██║██║   ██║██║     ██║     ██║██████╔╝█████╗  █████╗       
                                        ██║╚██╔╝██║██║     ██   ██║██║   ██║██║     ██║     ██║██╔══██╗██╔══╝  ██╔══╝       
                                        ██║ ╚═╝ ██║╚██████╗╚█████╔╝╚██████╔╝███████╗███████╗██║██████╔╝███████╗███████╗     
                                        ╚═╝     ╚═╝ ╚═════╝ ╚════╝  ╚═════╝ ╚══════╝╚══════╝╚═╝╚═════╝ ╚══════╝╚══════╝     
                                                                                                                        


        ";


        static String mainScreen = @"
     __  __                                                                                                             ___            _                  
    |  \/  |  ___  _ __   _   _                                                                                        / _ \  _ __  __| |  ___  _ __  ___ 
    | |\/| | / _ \| '_ \ | | | |                                                                                      | | | || '__|/ _` | / _ \| '__|/ __|
    | |  | ||  __/| | | || |_| |                                                                                      | |_| || |  | (_| ||  __/| |   \__ \
    |_|  |_| \___||_| |_| \__,_|                                                                                       \___/ |_|   \__,_| \___||_|   |___/


     ___________________________        ___________________________        ___________________________             +-----------------------------------------+
    |                           |      |                           |      |                           |            |                                         |
    |     Chicken with Rice     |      |           Burger          |      |           Fries           |            |                McJollibee               |
    |                           |      |                           |      |                           |            |                                         |  
    |    ₱100    Code: cwr      |      |    ₱50    Code: bgr       |      |    ₱45    Code: frs       |            |                                         |
    |___________________________|      |___________________________|      |___________________________|            |         Edsa Corner Evangelista         |
                                                                                                                   |             Bangkal, Makati             |
                                                                                                                   |               Metro Manila              |
     ___________________________        ___________________________                                                |                                         |
    |                           |      |                           |                                               |                                         |
    |           Sundae          |      |         Softdrinks        |                                               |    QTY       ITEM            PRICE      |
    |                           |      |                           |                                               |                                         |
    |    ₱30    Code: sde       |      |    ₱20    Code: sds       |                                               |                           ₱             |
    |___________________________|      |___________________________|                                               |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |  _______                 _____________  |
                                                                                                                   |                                         |
                                                                                                                   |             SUBTOTAL:     ₱             |
                                                                                                                   |                                         | 
                                                                                                                   +-----------------------------------------+
        ";

        static String paymentScreen = @"


                                                                                                                   Your receipt:

                                                                                                                   +-----------------------------------------+
                                                                                                                   |                                         |
                                                                                                                   |                McJollibee               |
                                                                                                                   |                                         |
                                                                                                                   |                                         |
                                                                                                                   |         Edsa Corner Evangelista         |
                                                                                                                   |             Bangkal, Makati             |
                                                                                                                   |               Metro Manila              |
                                                                                                                   |                                         |
     ____                                        _                                                                 |                                         |
    |  _ \  __ _  _   _  _ __ ___    ___  _ __  | |_                                                               |    QTY       ITEM            PRICE      |
    | |_) |/ _` || | | || '_ ` _ \  / _ \| '_ \ | __|                                                              |                                         |     
    |  __/| (_| || |_| || | | | | ||  __/| | | || |_                                                               |                           ₱             |
    |_|    \__,_| \__, ||_| |_| |_| \___||_| |_| \__|                                                              |                           ₱             |
                  |___/                                                                                            |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |  _______                 _____________  |
                                                                                                                   |                                         |   
                                                                                                                   |              SUBTOTAL:    ₱             |
                                                                                                                   |                                         |
                                                                                                                   |             + 10% VAT:    ₱             |
                                                                                                                   |                          _____________  |
                                                                                                                   |                                         |
                                                                                                                   |        Total WITH VAT:    ₱             |
                                                                                                                   |_________________________________________|    
                                                                                                                   |                                         |
                                                                                                                   |                  CASH:    ₱             |
                                                                                                                   |                                         |
                                                                                                                   |                CHANGE:    ₱             |   
                                                                                                                   |                                         |
                                                                                                                   +-----------------------------------------+
        ";
        
        static String addMenu = @"
    To add an item, enter its code shown above                          
        ";


        /* 
            index 0: Chicken with Rice
            index 1: Burger
            index 2: Fries
            index 3: Sundae
            index 4: Softdrinks
        */

        static Double[] itemPrices =  {100.00, 50.00, 45.00, 30.00, 20.00};
        static String[] itemCodes = {"cwr", "bgr", "frs", "sde", "sds"};
        static String[] itemNames = {"Chicken with Rice", "Burger", "Fries", "Sundae", "Softdrinks"};
        static Double[] totalItemPrices = new Double[5];
        static int[] orderQuantities = new int[5];
        static int totalQty = 0, num_userChoice;
        static Double vat, subtotalPrice, totalPrice;
        static string currentUser = "Customer", userChoice = "";
        
        
        
        
        static void error(int col, int row, string errorMessage = "Error. Please try again") {
            /*
            This module provides error message to the user.
            It takes the values of column and row to determine where it will display the error.
            It can also take a custom message via errorMessage parameter, otherwise it displays the default message.
            */
            Console.SetCursorPosition(col, row);
            Console.Write("                                                                           ");   //clears whatever the user typed in before
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(errorMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }



        static void success(int col, int row, string successMessage = "Action success, proceeding...") {
            /*
            This module provides success message to the user.
            It takes the values of column and row to determine where it will display the success message.
            It can also take a custom message via successMessage parameter, otherwise it displays the default message.
            */
            Console.SetCursorPosition(col, row);
            Console.Write("                                                                           ");   //clears whatever the user typed in before
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(successMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        
        //Computes the total quantity of all products
        static void computetotalQty()
        {
            // int counter;     This code made me scratched my head for hours by multiplying the total Qty into 2!!!
            // for (counter=0;counter<5;counter++)
            // {
            //     totalQty += orderQuantities[counter];
            // }
            totalQty = orderQuantities[0]+orderQuantities[1]+orderQuantities[2]+orderQuantities[3]+orderQuantities[4];
        }


        //Computes the VAT from the sub total price
        static void computeVAT() {
            //Takes in the subtotalPrice then returns the 10% of the subtotalPrice.
            vat = subtotalPrice * .10;
        }



        //Computes the total prices of each item
        static void computetotalItemPrices() {
            int counter = 0;
            while(counter < 5) {
                totalItemPrices[counter] = orderQuantities[counter] * itemPrices[counter];
                counter++;
            }
        }



        //Computes the sub total price of all items
        static void computesubtotalPrice() {
            // int counter;
            // for (counter=0;counter < 5;counter++) {
            //     subtotalPrice += totalItemPrices[counter];
            // }
            subtotalPrice = totalItemPrices[0] + totalItemPrices[1] + totalItemPrices[2] + totalItemPrices[3] + totalItemPrices[4];
        }
        
        
        
        //Computes the total price of all products
        static void computetotalPrice() {
            totalPrice = subtotalPrice + vat;
        }
        
        
        static void computeOrders()
        {
            computetotalQty();
            computetotalItemPrices();
            computesubtotalPrice();
            computeVAT();
            computetotalPrice();
        }
        
        
        static void displayOrders(bool displayReceipt = false) {
            //Displays the contents of orders
            //It can also be used to display the final receipt by calling it with a custom row parameter number.

            int difference = 0,
                row_orderQuantities = 20,
                row_totalQty = 27,
                row_totalItemPrices = 20,
                row_subtotalPrice = 27,
                row_vat = 26,
                row_totalPrice = 29;

            int[] row_itemname = {20, 21, 22, 23, 24};
            int[] column_itemname = {124, 129, 130, 129, 127};

            if (displayReceipt == true)
            {
                difference = 3;
                row_orderQuantities -= difference;
                row_totalQty -=  difference;
                row_totalItemPrices -= difference;
            }
            

            //Displays the Qty of the dish if it's not 0
            int counter;
            
            for (counter=0; counter < 5;counter++) {
                Console.SetCursorPosition(120, row_orderQuantities);
                Console.Write(orderQuantities[counter]);
                row_orderQuantities++;
            }
            
            
            //Displays the Total Qty
            Console.SetCursorPosition(120, row_totalQty);
            Console.Write(totalQty);
            
            
            //Displays the Item name
            for (counter=0; counter < 5;counter++)
            {
                row_itemname[counter] -= difference;
                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(column_itemname[counter], row_itemname[counter]);   //row_itemname initial value: 20
                    Console.Write(itemNames[counter]);
                }
            }
            
            
            //Displays the calculated price of each product
            counter = 0;
            while(counter < 5) {
                Console.SetCursorPosition(146, row_totalItemPrices);
                Console.Write(totalItemPrices[counter]);
                row_totalItemPrices++;
                counter++;
            }
            
            
            //Displays the subtotal Price
            Console.SetCursorPosition(146, row_subtotalPrice -= difference);
            Console.Write(subtotalPrice);

            
            if (displayReceipt == true)
            {
                //Displays the VAT
                Console.SetCursorPosition(146, row_vat);
                Console.Write(vat);
            
                //Displays the Total Price with VAT
                Console.SetCursorPosition(146, row_totalPrice);
                Console.Write(totalPrice);
            }
        }



        

        static String typeChoice(String errorMessage="Error. Please try again.", bool errorEnable = true) {
            int run  = 1;            
            userChoice = " ";    //not overriding this causes it to take the previous 
            while (userChoice == " ") {
                Console.SetCursorPosition(5,33);    //it feels weird that C# doesn't support multiplying strings using integers, what a shame tbh...
                Console.Write("                                                                                                                         ");   //clears whatever the user typed in before
                Console.SetCursorPosition(5,33);
                Console.Write($"{currentUser} type your choice: ");
                userChoice = Console.ReadLine();
                if (run != 1) {
                        if (errorEnable == true) {
                            error(5, 35, errorMessage);
                        }
                }
                run++;
            }
            return userChoice;
        }

        
        
        static int typeNum() {
            int verified_typeNum_input;
            String userNum;
            bool success_typeNum;

            do {
                Console.SetCursorPosition(5,33);
                Console.Write("                                                                           ");   //clears whatever the user typed in before
                Console.SetCursorPosition(5,33);
                Console.Write($"{currentUser} type your choice: ");
                userNum = Console.ReadLine();
                success_typeNum = Int32.TryParse(userNum, out verified_typeNum_input);
                if (success_typeNum) {
                    return verified_typeNum_input;
                }
                else {
                    error(5, 35, errorMessage: "Invalid number, please try again.");
                }
            }
            while (success_typeNum == false);

            return verified_typeNum_input;
        }



        static string[] splitString(String str) {
            String[] spearator = { ", " };
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            return strlist;
        }


        
        static void addOrder() {
            bool done_addOrder = false;
            
            while (done_addOrder == false)
            {
                bool success_addOrder = false;
                userChoice = ""; 
                
                help_addOrder();

                Console.SetCursorPosition(5, 25);
                Console.Write("To add items, enter its code, comma, then the desired amount. Then press enter.                          ");
                Console.SetCursorPosition(5, 27);
                Console.Write("Otherwise type 'e' once you're done.                                                                     ");  

                userChoice = typeChoice(errorEnable: false);
                string[] array_userChoice = splitString(userChoice);    //splits the answer of the user into an array.
                //for example: 'bgr, 2'     array_userChoice[0] = bgr   meanwhile      array_userChoice[1] = 2

                if (userChoice == "e") {
                    success(5, 35);
                    done_addOrder = true;
                    continue;
                }

                if (userChoice == "") 
                {
                    error(5, 35);
                    continue;
                }

                if (array_userChoice.Length != 2)
                {
                    error(5,35);
                    continue;
                }
                
                int num_addOrder = Int32.Parse(array_userChoice[1]);
                if (num_addOrder < 0 || num_addOrder == 0)
                {
                    error(5, 35, errorMessage:"You entered invalid number.");
                    continue;
                } 

                int counter;
                for (counter=0; counter < 5; counter++) {
                    if (array_userChoice[0] == itemCodes[counter] && success_addOrder == false)
                    {    
                        orderQuantities[counter] += Int32.Parse(array_userChoice[1]);
                        display_mainScreen();
                        success(5, 35, $"Added {array_userChoice[1]} {itemNames[counter]}");
                        array_userChoice[0] = "";
                        array_userChoice[1] = "";
                        success_addOrder = true;
                        break;
                    }
                    
                    if (success_addOrder == false) 
                    {
                        error(5,35, $"Item code '{array_userChoice[0]}' is not found, please try again.");
                    }
                }
            }
        }
        
        
        static void help_addOrder() {
            //Displays an instruction on how to add orders
            int displayAmount, random_item;
            String displayItemCode, displayItemName;

            Random random = new Random();
            displayAmount = random.Next(1, 10);
            random_item = random.Next(0, 4);
            displayItemCode = itemCodes[random_item];
            displayItemName = itemNames[random_item];
            Console.SetCursorPosition(5, 26);
            Console.Write($"For example, to add {displayAmount} {displayItemName}(s)   type: '{displayItemCode}, {displayAmount}'                                ");
        }
            
        

        static void cancelOrder() {
            bool done_cancelOrder = false;
            
            while (done_cancelOrder == false)
            {
                bool success_cancelOrder = false;
                userChoice = ""; 
                
                help_cancelOrder();
                
                Console.SetCursorPosition(5, 25);
                Console.Write("To cancel items, enter its code, comma, then the desired amount. Then press enter.                       ");
                Console.SetCursorPosition(5, 27);
                Console.Write("Otherwise type 'e' once you're done.                                                                     ");  

                userChoice = typeChoice(errorEnable: false);
                string[] array_userChoice = splitString(userChoice);    //splits the answer of the user into an array.
                //for example: 'bgr, 2'     array_userChoice[0] = bgr   meanwhile      array_userChoice[1] = 2
                
                if (userChoice == "e") {
                    success(5, 35);
                    done_cancelOrder = true;
                    continue;
                }
                
                if (userChoice == "") 
                {
                    error(5, 35);
                    continue;
                }

                if (array_userChoice.Length != 2)
                {
                    error(5,35);
                    continue;
                }
                
                int num_cancelOrder = Int32.Parse(array_userChoice[1]);
                if (num_cancelOrder < 0 || num_cancelOrder == 0)    //breaks the loop if the user entered a negative number
                {
                    error(5, 35, errorMessage:"You entered invalid number.");
                    continue;
                }

                int counter;
                for (counter=0; counter < 5; counter++) {

                    if (array_userChoice[0] == itemCodes[counter] && success_cancelOrder == false)
                    {    
                        if (num_cancelOrder > orderQuantities[counter])
                        {
                            error(5, 35, "You cancelled amount of items higher than you have!");
                            break;
                        }
                        
                        orderQuantities[counter] -= Int32.Parse(array_userChoice[1]);
                        display_mainScreen();
                        computeOrders();
                        success(5, 35, $"Removed {array_userChoice[1]} {itemNames[counter]}");
                        array_userChoice[0] = "";
                        array_userChoice[1] = "";
                        success_cancelOrder = true;
                        continue;
                    }
                    
                    if (success_cancelOrder == false) 
                    {
                        error(5,35, $"Item code '{array_userChoice[0]}' is not found, please try again.");
                    }
                }
            }
        }

        
        static void help_cancelOrder() {
            //Displays an instruction on how to cancel orders
            int displayAmount, random_item;
            String displayItemCode, displayItemName;

            Random random = new Random();
            displayAmount = random.Next(1, 10);
            random_item = random.Next(0, 4);
            displayItemCode = itemCodes[random_item];
            displayItemName = itemNames[random_item];
            Console.SetCursorPosition(5, 26);
            Console.Write($"For example, to cancel {displayAmount} {displayItemName}(s)     type: '{displayItemCode}, {displayAmount}'                          ");
        }


        
        static void payment() {
            Console.Clear();
            display_paymentScreen();
            Console.ReadLine();
        }

        
        
        static void newCustomer() {
            
        }
        
        

        static void notice_fullscreen()
        {
            Console.Write("Tip: For better experience, please use a fixed width font ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Warning: Please maximize the window before continuing...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Press Enter to continue ");
            Console.ReadLine();
        }
        
        static void getcurrentUser()
        {
            int run = 1;
            while (currentUser == "Customer" || currentUser == "") {
                Console.SetCursorPosition(65,30);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is your name? ");
                currentUser = Console.ReadLine();
                if (run != 1) {
                    error(53, 35, "You typed invalid name, please try again");
                }
                run++;
            }
        }
        
        static void welcomeScreen() 
        {
            Console.Clear();
            //column, row
            Console.SetCursorPosition(15,10);
            Console.Write(banner);

            if (currentUser == "Customer") {
                getcurrentUser();
            }
            
            Console.SetCursorPosition(65, 30);
            Console.Write($"Welcome {currentUser}! press enter to continue");
            Console.Read();
        }


        static void display_paymentScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(5,0);
            //Displays the template of the main screen which contains the menu list and current receipt.
            Console.Write(paymentScreen);
            //Overlays the values of receipt on top of the payment screen's template.
            computeOrders();
            displayOrders(displayReceipt:true);
        }


        static void display_mainScreen() 
        {
            Console.Clear();
            Console.SetCursorPosition(5,0);
            //Displays the template of the main screen which contains the menu list and current orders.
            Console.Write(mainScreen);
            //Overlays the values of the orders on top of the main screen's template.
            computeOrders();
            displayOrders();
        }

        
        static void Main(string[] args)
        {
            notice_fullscreen();
            welcomeScreen();
            while (program_execution_count < 5) {
                display_mainScreen();
                program_execution_count += 1;
                Console.SetCursorPosition(5, 25);
                Console.Write("OPTIONS:     [1]Add      [2]Cancel Orders    [3]Payment      [4]Exit");
                num_userChoice = typeNum();
                
                switch (num_userChoice)
                {
                    case 1: addOrder();
                        break;

                    case 2:
                    {
                        if (totalPrice == 0)
                        {
                            error(5, 35, errorMessage: "You have ordered nothing, please do so by entering '1', then come back here.");
                            Console.ReadLine();
                        }
                        else
                        {
                            cancelOrder();
                        }

                        break;
                    }

                    case 3:
                    {
                        if (totalPrice == 0)
                        {
                            error(5, 35, errorMessage: "You have ordered nothing, please do so by entering '1', then come back here.");
                            Console.ReadLine();
                        }
                        else
                        {
                            payment();
                        }
                        
                        break;
                    }

                    case 4: continue;

                    default:
                    {
                        error(5, 35, errorMessage: "Invalid number choice, please try again.");
                        break;
                    }
                }
            }
        }
    }
}
