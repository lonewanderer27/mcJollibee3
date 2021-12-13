

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
    |           Sundae          |      |         Softdrinks        |                                               |     Qty      Item            Price      |
    |                           |      |                           |                                               |                                         |
    |    ₱30    Code: sde       |      |    ₱20    Code: sds       |                                               |                           ₱             |
    |___________________________|      |___________________________|                                               |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |  _____________________________________  |
                                                                                                                   |                                         |
                                                                                                                   |              Subtotal     ₱             |
                                                                                                                   |                                         |
                                                                                                                   |             + 10% VAT     ₱             |
                                                                                                                   |  _____________________________________  |
                                                                                                                   |                                         |
                                                                                                                   |        Total with VAT:    ₱             |
                                                                                                                   |                                         |   
                                                                                                                   +-----------------------------------------+
        ";

        static String paymentScreen = @"
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
    |           Sundae          |      |         Softdrinks        |                                               |     Qty      Item            Price      |
    |                           |      |                           |                                               |                                         |
    |    ₱30    Code: sde       |      |    ₱20    Code: sds       |                                               |                           ₱             |
    |___________________________|      |___________________________|                                               |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |                           ₱             |
                                                                                                                   |  _____________________________________  |
                                                                                                                   |                                         |
                                                                                                                   |              Subtotal     ₱             |
                                                                                                                   |                                         |
                                                                                                                   |             + 10% VAT     ₱             |
                                                                                                                   |  _____________________________________  |
                                                                                                                   |                                         |
                                                                                                                   |        Total with VAT:    ₱             |
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
        static Double[] totalItemPrices = new Double[5];
        static int[] orderQuantities = new int[5];
        static int totalQty, num_userChoice;
        static Double vat, subtotalPrice, totalPrice;

        static string currentUser = "", userChoice = "";




        




        //Computes the VAT from the sub total price
        static void computeVAT() {
            //Takes in the subtotalPrice then returns the 10% of the subtotalPrice.
            vat = subtotalPrice * .10;
        }


        //Computes the total prices of each item
        static void computetotalItemPrices() {
            int counter = 0, row = 20;
            while(counter < 5) {
                Console.SetCursorPosition(146, row);
                totalItemPrices[counter] = orderQuantities[counter] * itemPrices[counter];
                counter++;
                row++;
            }
        }


        //Computes the sub total price of all items
        static void computesubtotalPrice() {
            int counter;
            for (counter=0;counter < 5;counter++) {
                subtotalPrice += totalItemPrices[counter];
            }
        
        }


        //Computes the total quantity of all products
        static void computetotalQty() {
            int qty, totalQty=0;
            for (qty=0;qty<5;qty++) {
                totalQty += orderQuantities[qty];
            }
        }


        //Computes the total price of all products
        static void computetotalPrice() {
            totalPrice = subtotalPrice + vat;
        }

        
        static void updateOrders() {

            //Displays the Qty of the dish if it's not 0
            int counter, row = 20;
            
            for (counter=0; counter < 5;counter++) {
                Console.SetCursorPosition(121, row);
                Console.Write(orderQuantities[counter]);
                totalQty += orderQuantities[counter];
                row++;
            }


            //Displays the Total Qty
            Console.SetCursorPosition(121, 27);
            computetotalQty();
            Console.Write(totalQty);


            //Displays the Item name
            for (counter=0; counter < 5;counter++) {
                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(126, 20);
                    Console.Write("Chick w/ Rice");
                }

                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(126, 21);
                    Console.Write("Burger");
                }

                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(126, 22);
                    Console.Write("Fries");
                }

                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(126, 23);
                    Console.Write("Sundae");
                }
                
                if (orderQuantities[counter] != 0) {
                    Console.SetCursorPosition(126, 24);
                    Console.Write("Softdrinks");
                }
            }

            
            //Displays the calculated price of each product
            row = 20;
            counter = 0;
            computetotalItemPrices();
            while(counter < 5) {
                Console.SetCursorPosition(146, row);
                Console.Write(totalItemPrices[counter]);
                row++;
                counter++;
            }


            //Displays the subtotal Price
            Console.SetCursorPosition(146, 27);
            computesubtotalPrice();
            Console.Write(subtotalPrice);

            
            //Displays the VAT
            Console.SetCursorPosition(146, 29);
            computeVAT();
            Console.Write(vat);


            //Displays the Total Price with VAT
            Console.SetCursorPosition(146, 32);
            computetotalPrice();
            Console.Write(totalPrice);
            

        }


        static String getcurrentUser() {
            int run = 1;
            String currentUser = "";
            while (currentUser == "") {
                Console.SetCursorPosition(53,30);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is your name? ");
                currentUser = Console.ReadLine();
                if (run != 0) {
                    error(53, 32, "You typed invalid name, please try again");
                }
                run++;
            }
            return currentUser;
        }



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



        static String typeChoice(String errorMessage="Error. Please try again.", bool errorEnable = true) {
            int run  = 1;            
            userChoice = " ";    //not overriding this causes it to take the previous 
            while (userChoice == " ") {
                Console.SetCursorPosition(5,30);    //it feels weird that C# doesn't support multiplying strings using integers, what a shame tbh...
                Console.Write("                                                                           ");   //clears whatever the user typed in before
                Console.SetCursorPosition(5,30);
                Console.Write("Type your choice: ");
                userChoice = Console.ReadLine();
                if (run != 1) {
                        if (errorEnable == true) {
                            error(5, 32, errorMessage);
                        }
                    }
                    run++;
            }
            //Debugging purposes...
            //Console.Write("typeChoice succeeded?");
            //Console.ReadLine();
            return userChoice;
        }



        static int typeNum() {
            int verified_typeNum_input;
            String userNum;
            bool success_typeNum;

            do {
                Console.SetCursorPosition(5,30);
                Console.Write("                                                                           ");   //clears whatever the user typed in before
                Console.SetCursorPosition(5,30);
                Console.Write("Type your choice: ");
                userNum = Console.ReadLine();
                success_typeNum = Int32.TryParse(userNum, out verified_typeNum_input);
                if (success_typeNum) {
                    return verified_typeNum_input;
                }
                else {
                    error(5, 32, errorMessage: "Invalid number, please try again.");
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



        static string determineItemName(String itemCode) {
            string itemName = "";

            if (itemCode == "cwr") {
                itemName = "Chicken with Rice";
            }

            if (itemCode == "bgr") {
                itemName = "Burger";
            }

            if (itemCode == "frs") {
                itemName = "Fries";
            }

            if (itemCode == "sde") {
                itemName = "Sundae";
            }

            if (itemCode == "sds") {
                itemName = "Softdrinks";
            }

            return itemName;
        }



        static void welcomeScreen() {
            Console.Clear();
            //column, row
            Console.SetCursorPosition(15,10);
            Console.Write(banner);

            Console.SetCursorPosition(54,27);
            Console.Write("For better experience, please use a fixed width font ");
            Console.ReadLine();

            if (program_execution_count == 0) {
                
                currentUser = getcurrentUser();
            }
            

            
        }



        static void addOrder() {
            int counter;
            bool success_addOrder = false, done_addOrder = false;
            userChoice = "";
            while (done_addOrder == false) {
                Console.SetCursorPosition(5, 25);
                Console.Write("To add items, enter its code and amount. Example: frs, 2                              ");
                Console.SetCursorPosition(5, 26);
                Console.Write("Type 'e' once finished.");

                userChoice = typeChoice(errorEnable: false);
                String[] array_userChoice = splitString(userChoice);

                if (userChoice == "e") {
                    success(5, 32, "");
                    done_addOrder = true;
                    break;
                }

                for (counter=0; counter < 5; counter++) {
                    if (array_userChoice[0] == itemCodes[counter])
                    {    
                        totalItemPrices[counter] += (itemPrices[counter] * Int32.Parse(array_userChoice[1]));
                        success_addOrder = true;
                        done_addOrder = true;
                        success(5, 32, $"Successfully added ");
                        break;
                    }
                }

                if (userChoice == "") {
                    error(5, 33);
                }

                else if (success_addOrder == false) {
                    error(5,33, $"Item code '{array_userChoice[0]}' is not found, please try again.");
                }
            }
        }
            

        static void cancelOrder() {
            
        }


        static void payment() {

        }

        
        static void clearOrder() {
            
        }

        

        static void Main(string[] args)
        {
            
                welcomeScreen();
                program_execution_count += 1;
                //column, row
                Console.SetCursorPosition(5,0);
                //Displays the template of the main screen which contains the menu list and current receipt.
                Console.Write(mainScreen);
                //Overlays the values of the orders on top of the main screen's template.
                updateOrders();

                Console.SetCursorPosition(5, 25);
                Console.Write("OPTIONS:     [1]Add      [2]Cancel Orders    [3]Payment      [4]Exit");
                num_userChoice = typeNum();
                if (num_userChoice == 1) {
                    addOrder();
                }
                else if (num_userChoice == 2) {
                    cancelOrder();
                }
                else if (num_userChoice == 3) {
                    payment();
                }
                else if (num_userChoice == 4) {
                    
                }
                else {
                    error(5, 32, "Invalid number choice, please try again.");
                }

            
        }


        
    }
}
