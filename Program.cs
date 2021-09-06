using System;




namespace LearningC__
{   
    class Program
    {
        static int CalculateCart(string y, int price)
        {
            return Convert.ToInt32(y) * price;
        }

        static void Main()
        {
            Cart myCart = new Cart();
            bool orderDone = false;
            string userInput;
            do
            {
                //Ask question
                Console.WriteLine("Would you like Pasta or Pizza. To quit type Stop. To finalize order type Done.");
                /* Read answer from Console, turn it to lowercase to prevent users from not being able to order due to capitalization */
                userInput = Console.ReadLine().ToLower();

                //If user wants Pasta.
                if (userInput == "pasta")
                {
                    //Ask user how much they want.
                    Console.WriteLine("How much pasta would you like? || Back to return to start.");
                    //Check if user is sure about wanting Pasta, if not return to begin, this is done by calling the method the do-while is in.
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "back") { Main(); break; }
                    //Save total price of Pasta ordered in myCart class (classTest.cs), usesfunction CalcluateCart, this requires 2 parameters. Amount of x Product and price of product.
                    myCart.pastaAmount = CalculateCart(Console.ReadLine(), 10);
                    //Write Pasta Amount to User.
                    Console.WriteLine($"The total price of the pasta is { myCart.pastaAmount}");
                }
                    
                    //If user is done with order
                    if (userInput == "done")
                    {
                        //Set orderDone to true
                        orderDone = true;
                        //Let the user know the total.
                        Console.WriteLine($"Your total amount is {myCart.totalAmount}");
                    }
                    //run the code inside of do{} while this condition is not met.  
                }while (!orderDone);
        }

     
    }
}
