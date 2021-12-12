

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
        


        /* 
            index 0: Chicken with Rice
            index 1: Burger
            index 2: Fries
            index 3: Sundae
            index 4: Softdrinks
        */

        static Double[] itemPrices =  {100.00, 50.00, 45.00, 30.00, 20.00};
        static Double[] totalItemPrices = new Double[5];
        static int[] orderQuantities = new int[5];
        static int totalQty;
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
            int counter, qty, row = 20;
            
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



        
        static void welcomeScreen() {
            Console.Clear();
            //column, row
            Console.SetCursorPosition(15,10);
            Console.Write(banner);

            Console.SetCursorPosition(53,30);
            Console.Write("For a better experience, please use a fixed width font ");
            Console.ReadLine();

            if (program_execution_count == 0) {
                Console.SetCursorPosition(53,35);
                Console.Write("What is your name? ");
                currentUser = Console.ReadLine();
            }
            

            
        }


        static void choicesMenu(string userChoice) {
            userChoice = userChoice.ToLower();
            switch (userChoice)
            {
                case "": {
                    Console.SetCursorPosition(5, 25);
                    Console.Write("OPTIONS:     [1]Add      [2]Cancel Orders    [3]Payment      [4]Exit");

                    Console.SetCursorPosition(5, 30);
                    Console.Write("Type your choice: ");
                    Console.ReadLine();

                    break;
                }
            }

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

            choicesMenu(userChoice);



            Console.SetCursorPosition(5,60);
        }


        
    }
}
