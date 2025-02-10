using System;
using System.Collections;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryStoreDiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList items = new ArrayList();
            AddCart cart = new AddCart();
            CannedGoods cg = new CannedGoods(cart);
            Fruits fruit = new Fruits(cart);
            Vegetables veggie = new Vegetables(cart);
            Snacks sncks = new Snacks(cart);
            Sweets sweet = new Sweets(cart);

            Boolean valid = true;
            while (valid)
            {
                Console.WriteLine("====== GROCERY MENU CATEGORIES ======");
                Console.WriteLine("[1] Canned Goods");
                Console.WriteLine("[2] Meat");
                Console.WriteLine("[3] Fruits");
                Console.WriteLine("[4] Vegetables");
                Console.WriteLine("[5] Snacks");
                Console.WriteLine("[6] Sweets");
                Console.WriteLine("[7] Sauces and Condiments");
                Console.WriteLine("[8] Beverages");
                Console.WriteLine("[9] Personal Care");
                Console.WriteLine("[10] Household and Cleaning");
                Console.WriteLine("[x] View Cart");
                Console.WriteLine("=====================================");
                Console.Write("Enter the number of your choice: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        cg.cgMenu();
                        break;
                    case "2":
                        break;
                    case "3":
                        fruit.fruitsMenu();
                        break;
                    case "4":
                        veggie.veggieMenu();
                        break;
                    case "5":
                        sncks.snacksMenu();
                        break;
                    case "6":
                        sweet.sweetsMenu();
                        break;
                    case "x":
                        cart.showCart();
                        Console.WriteLine("[1] Proceed CheckOut");
                        Console.WriteLine("[2] Return");

                        Console.Write("\nSelect option: ");
                        string input = Console.ReadLine();
                        if (input.Equals("1"))
                        {
                            //process
                        }
                        else if (input.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                           
                        }
                        else {
                            Console.WriteLine("[INVALID INPUT, PLEASE TRY AGAIN]");
                        }
                        valid = false;

                        break;
                    default:
                        Console.WriteLine("\n----------- INVALID INPUT> PLEAASE TRY AGAIN -----------\n");
                        break;

                }
            }
        }
    }
    /*
     //ADD, REMOVE
     // SHOW PRICE OF EACH ITEM AND THE SUBTOTAL
     // MAG MINUS FOR DISCOUNTS DEPENDING ON THE AMOUNT
     // -ONCE CONFIRMED OR CUSTOMER AGREE TO CHECK OUT, PRINT RECEIPT
     //[RECEIPT : QUANTITY , PRODUCT, PRICE, SUBTOTAL, DISCOUNT , TOTAL]
    */
    public class AddCart
    {
        ArrayList addToCart = new ArrayList(); 

        public void addCart(object[] product)
        {
            addToCart.Add(product);
            Console.WriteLine("\n------- Product added to cart! -------\n");
        }

        public void showCart()
        {
            Console.WriteLine("\n================================ YOUR CART ==================================");
            if (addToCart.Count != 0)
            {
                foreach (object[] product in addToCart)
                {
                    Console.WriteLine($"{product[0],-50} PHP {product[1],8:F2}  Quantity: {product[2]}");

                }
                Console.WriteLine("=============================================================================\n");
                Console.WriteLine("\nSubtotal: ");
            }
            else
            {
                Console.WriteLine("Your cart is empty...");

            }

            Console.WriteLine("=============================================================================\n\n");
        }
       // public void subTotal() { //continue
        
        //}
    }
    public class CannedGoods
    {
        private AddCart cart; 
        public CannedGoods(AddCart cart)
        {
            this.cart = cart;  
        }

        public void cgMenu()
        {         

            ArrayList products = new ArrayList()
            {
                new object[] { "555 Sardines Spanish Style (155g)", 90.00, 0 },
                new object[] { "555 Sardines Tomato Sauce with Chili (15oz)", 198.00, 0 },
                new object[] { "Argentina Luncheon Meat (12oz)", 330.00, 0 },
                new object[] { "Blue Bay Fried Sardines Hot & Spicy", 82.00, 0},
                new object[] { "Blue Bay Sardines in Tomato Sauce", 82.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Olive Oil", 180.00, 0 },                   
                new object[] { "Century Tuna - Tuna with Calamansi (Lime)", 210.00, 0 },                
                new object[] { "Ligo Sardines Regular (Green, Small)", 92.00, 0 },
                new object[] { "Ligo Sardines with Chili (Red, Small)", 95.00, 0 },
                new object[] { "Maling Luncheon Meat Premium", 290.00, 0 }
            };
            Boolean valid = true;
            while (valid) {
                Console.WriteLine("================================ CANNED GOODS ================================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ==================================================== PRICE =====");

                for (int i = 0; i < products.Count; i++)
                {
                    object[] product = (object[])products[i];
                    Console.WriteLine($"{i + 1,2}. {product[0],-60} PHP {product[1],8:F2}");
                }
                Console.WriteLine("[x] Return to Main Menu");
                Console.WriteLine("==============================================================================");
                Console.Write("Enter product number: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Name of product: ");
                        string search = Console.ReadLine();

                        Console.WriteLine("===== PRODUCT ==================================================== PRICE =====");
                        foreach (object[] product in products) {
                            string productName = product[0].ToString().ToLower();
                            if (productName.StartsWith(search))
                            {
                                Console.WriteLine($"{product[0],-60} PHP {product[1],8:F2}");
                                valid = true;
                            }
                        }

                        Console.Clear();
                        if (!valid)
                        {
                            Console.WriteLine("[Stock not available!]");
                        }
                        break;
                    case "1":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");                        
                        Console.Write("\nSelect option: ");
                        string input = Console.ReadLine();

                        if (input.Equals("1")) {
                           object[] product = (object[])products[0];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);                  
                            continue;
                        }
                        if (input.Equals("x") || input.Equals("X")) {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "2":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input1 = Console.ReadLine();

                        if (input1.Equals("1"))
                        {
                            object[] product = (object[])products[1];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);                            
                            continue;
                        }
                        if (input1.Equals("x") || input1.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "3":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input2 = Console.ReadLine();

                        if (input2.Equals("1"))
                        {
                            object[] product = (object[])products[2];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input2.Equals("x") || input2.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "4":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input3 = Console.ReadLine();

                        if (input3.Equals("1"))
                        {
                            object[] product = (object[])products[3];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input3.Equals("x") || input3.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "5":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input4 = Console.ReadLine();

                        if (input4.Equals("1"))
                        {
                            object[] product = (object[])products[4];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input4.Equals("x") || input4.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "6":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input5 = Console.ReadLine();

                        if (input5.Equals("1"))
                        {
                            object[] product = (object[])products[5];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input5.Equals("x") || input5.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "7":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input6 = Console.ReadLine();

                        if (input6.Equals("1"))
                        {
                            object[] product = (object[])products[6];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input6.Equals("x") || input6.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "8":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input7 = Console.ReadLine();

                        if (input7.Equals("1"))
                        {
                            object[] product = (object[])products[7];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input7.Equals("x") || input7.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "9":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input8 = Console.ReadLine();

                        if (input8.Equals("1"))
                        {
                            object[] product = (object[])products[8];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input8.Equals("x") || input8.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "10":
                        Console.WriteLine("[1] Input Quantity");
                        Console.WriteLine("[x] Return");
                        Console.Write("\nSelect option: ");
                        string input9 = Console.ReadLine();

                        if (input9.Equals("1"))
                        {
                            object[] product = (object[])products[9];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input9.Equals("x") || input9.Equals("X"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "x":
                        Console.WriteLine();
                        valid = false;
                        break;
                }
            }
        }
    }
    public class Fruits
    {
        AddCart cart;
        public Fruits (AddCart cart)
        {
            this.cart = cart;
        }
        public void fruitsMenu()
        {
            bool valid = true;
            while (valid)
            {
                ArrayList fruitList = new ArrayList{
                    new object[] {"Apple", 20.00, 0},
                    new object[] {"Banana", 30.00, 0},
                    new object[] {"Blueberry", 75.00, 0 },
                    new object[] {"Coconut", 20.00, 0 },
                    new object[] {"Grapes", 60.00, 0 },
                    new object[] {"Mango", 50.00 , 0 },
                    new object[] {"Orange", 40.00, 0 },
                    new object[] {"Papaya", 45.00, 0 },
                    new object[] {"Strawberry", 55.00, 0 },
                    new object[] {"Watermelon", 35.00, 0 }
                };
                Console.WriteLine("================================= FRUITS ================================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ======================================== PRICE PER KG =====");
                for (int i = 0; i < fruitList.Count; i++){
                    object[] fruit = (object[])fruitList[i];
                    Console.WriteLine($"{i + 1,2}. {fruit[0],-50} PHP {fruit[1],8:F2}");
                }
                Console.WriteLine("\n[x] Return to Main Menu");
                Console.WriteLine("=========================================================================");

                Console.WriteLine("Enter product number: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice){
                    case "0":
                        Console.WriteLine("Enter an item (fruit) to search: ");
                        string userFruit = Console.ReadLine();

                        bool found = false;

                        foreach (object[] item in fruitList){
                            string fruitName = item[0].ToString().ToLower();
                            if (fruitName.StartsWith(userFruit)){
                                Console.WriteLine($"Item: {item[0]} Price: Php {item[1]}");
                                found = true;
                            }
                        }
                        if (!found){
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "1":
                        while (true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return");
                            Console.WriteLine("Select option: ");
                            string appleChoice = Console.ReadLine();
                            if (appleChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int appleQuantity = Convert.ToInt16(Console.ReadLine());
                                Console.Clear();
                                fruit[2] = appleQuantity;
                                cart.addCart(fruit);
                                break;
                            }
                            else if (appleChoice == "x" || appleChoice == "X"){
                                Console.Clear();
                                break;
                            } else{
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                            }
                        }
                        break;
                    case "2":
                        while (true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            Console.WriteLine("Select option: ");
                            string bananaChoice = Console.ReadLine();
                            if (bananaChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int bananaQuantity = Convert.ToInt16(Console.ReadLine());
                                Console.Clear();
                                fruit[2] = bananaQuantity;
                                cart.addCart(fruit);
                                break;
                            } else if (bananaChoice == "x" || bananaChoice == "X"){
                                Console.Clear();
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                            }
                        }
                        break;
                    case "3":
                        while (true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            Console.WriteLine("Select option: ");
                            string blueberryChoice = Console.ReadLine();
                            if (blueberryChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int blueberryQuantity = Convert.ToInt16(Console.ReadLine());
                                Console.Clear();
                                fruit[2] = blueberryQuantity;
                                cart.addCart(fruit);
                            } else if (blueberryChoice == "x" || blueberryChoice == "X"){
                                Console.Clear();
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                            }
                        }
                        break;
                    case "4":
                        while (true) {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string coconutChoice = Console.ReadLine();
                            if (coconutChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int coconutQuantity = Convert.ToInt16(Console.ReadLine());
                                Console.Clear();
                                fruit[2] = coconutQuantity;
                                cart.addCart(fruit);
                            } else if (coconutChoice == "x" || coconutChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                            break;
                        }
                        break;
                    case "5":
                        while (true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string grapesChoice = Console.ReadLine();
                            if (grapesChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int grapesQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = grapesQuantity;
                                cart.addCart(fruit);
                            } else if (grapesChoice == "x" || grapesChoice == "X") {
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "6":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[2] Return to Fruits Menu");
                            string mangoChoice = Console.ReadLine();
                            if (mangoChoice == "1")
                            {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int mangoQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = mangoQuantity;
                                cart.addCart(fruit);
                            }
                            else if (mangoChoice == "x" || mangoChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "7":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string orangeChoice = Console.ReadLine();
                            if (orangeChoice == "1")
                            {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int orangeQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = orangeQuantity;
                                cart.addCart(fruit);
                            }
                            else if (orangeChoice == "x" || orangeChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "8":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string papayaChoice = Console.ReadLine();
                            if (papayaChoice == "1")
                            {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int papayaQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = papayaQuantity;
                                cart.addCart(fruit);
                            }
                            else if (papayaChoice == "x" || papayaChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, Please try again.");
                            }
                        }
                        break;
                    case "9":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string strawberryChoice = Console.ReadLine();
                            if (strawberryChoice == "1")
                            {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int strawberryQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = strawberryQuantity;
                                cart.addCart(fruit);
                            }
                            else if (strawberryChoice == "x" || strawberryChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "10":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string watermelonChoice = Console.ReadLine();
                            if (watermelonChoice == "1")
                            {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int watermelonQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[2] = watermelonQuantity;
                                cart.addCart(fruit);
                            }
                            else if (watermelonChoice == "x" || watermelonChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "x":
                    case "X":
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
    public class Vegetables
    {
        AddCart cart;
        public Vegetables(AddCart cart) { 
            this.cart = cart;
        }
        public void veggieMenu()
        {
            bool valid = true;
            while (valid)
            {
                ArrayList veggieList = new ArrayList{
                    new object[] {"Beans", 60.00, 0 },
                    new object[] {"Broccoli", 75.00, 0 },
                    new object[] {"Cabbage", 85.00, 0 },
                    new object[] {"Carrot", 20.00, 0 },
                    new object[] {"Cucumber", 55.00, 0 },
                    new object[] {"Eggplant", 50.00, 0 },
                    new object[] {"Garlic", 40.00, 0 },
                    new object[] {"Ginger", 45.00, 0 },
                    new object[] {"Onion", 35.00, 0 },
                    new object[] {"Potato", 60.00, 0 }
                };
                Console.WriteLine("============================== VEGETABLES ===============================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ======================================== PRICE PER KG =====");
                for (int i = 0; i < veggieList.Count; i++)
                {
                    object[] veggie = (object[])veggieList[i];
                    Console.WriteLine($"{i + 1,2}. {veggie[0],-15} PHP {veggie[1],8:F2}");
                }
                Console.WriteLine("\n[x] Return to Main Menu");
                Console.WriteLine("=========================================================================");

                Console.WriteLine("Enter the assigned number of your desired product: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Enter an item (vegetable) to search: ");
                        string userVeggie = Console.ReadLine();

                        bool found = false;

                        foreach (object[] item in veggieList)
                        {
                            string veggieName = item[0].ToString().ToLower();
                            if (veggieName.StartsWith(userVeggie))
                            {
                                Console.WriteLine($"Item: {item[0]} Price: Php {item[1]}");
                                found = true;
                                // break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string beansChoice = Console.ReadLine();
                            if (beansChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int beansQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = beansQuantity;
                                cart.addCart(veggies);
                            }
                            else if (beansChoice == "x" || beansChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string broccoliChoice = Console.ReadLine();
                            if (broccoliChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int broccoliQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = broccoliQuantity;
                                cart.addCart(veggies);
                            }
                            else if (broccoliChoice == "x" || broccoliChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "3":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string cabbageChoice = Console.ReadLine();
                            if (cabbageChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int cabbageQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = cabbageQuantity;
                                cart.addCart(veggies);
                            }
                            else if (cabbageChoice == "x" || cabbageChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "4":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string carrotChoice = Console.ReadLine();
                            if (carrotChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int carrotQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = carrotQuantity;
                                cart.addCart(veggies);
                            }
                            else if (carrotChoice == "x" || carrotChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "5":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string cucumberChoice = Console.ReadLine();
                            if (cucumberChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int cucumberQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = cucumberQuantity;
                                cart.addCart(veggies);
                            }
                            else if (cucumberChoice == "x" || cucumberChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "6":
                        while (true) {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string eggplantChoice = Console.ReadLine();
                            if (eggplantChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int eggplantQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = eggplantQuantity;
                                cart.addCart(veggies);
                            }
                            else if (eggplantChoice == "x" || eggplantChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                            break;
                        }
                        break;
                    case "7":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string garlicChoice = Console.ReadLine();
                            if (garlicChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int garlicQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = garlicQuantity;
                                cart.addCart(veggies);
                            }
                            else if (garlicChoice == "x" || garlicChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("[1] Enter Quantity");
                        Console.WriteLine("[x] Return to Fruits Menu");
                        string gingerChoice = Console.ReadLine();
                        if (gingerChoice == "1")
                        {
                            object[] veggies = (object[])veggieList[0];
                            Console.WriteLine("How many would you like to buy: ");
                            int gingerQuantity = Convert.ToInt16(Console.ReadLine());
                            veggies[2] = gingerQuantity;
                            cart.addCart(veggies);
                        }
                        else if (gingerChoice == "x" || gingerChoice == "X")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;
                    case "9":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string onionChoice = Console.ReadLine();
                            if (onionChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int onionQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[2] = onionQuantity;
                                cart.addCart(veggies);
                            }
                            else if (onionChoice == "x" || onionChoice == "X")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "10":
                        while (true)
                        {
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string potatoChoice = Console.ReadLine();
                            if (potatoChoice == "1")
                            {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int potatoQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[26] = potatoQuantity;
                                cart.addCart(veggies);
                            }
                            else if (potatoChoice == "x" || potatoChoice == "X")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "x":
                    case "X":
                        valid = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
    public class Snacks
    {
        private AddCart cart;


        public Snacks(AddCart cart)
        {
            this.cart = cart;
        }

        public void snacksMenu()
        {

            ArrayList snacksList = new ArrayList()
            {
                new object[] { "Lays Classic (100g)", 65.00, 0 },
                new object[] { "Lays Sour Cream & Onion (100g)", 70.00, 0 },
                new object[] { "Doritos Nacho Cheese (150g)", 99.00, 0 },
                new object[] { "Doritos Cool Ranch (150g)", 105.00, 0 },
                new object[] { "Oreo Chocolate Cream (133g)", 75.00, 0 },
                new object[] { "Oreo Vanilla Cream (133g)", 75.00, 0 },
                new object[] { "Piattos Cheese (85g)", 40.00, 0 },
                new object[] { "Piattos Sour Cream (85g)", 42.00, 0 },
                new object[] { "Nova Multigrain Chips (80g)", 45.00, 0 },
                new object[] { "Clover Chips Cheese (55g)", 37.00, 0 },
                new object[] { "Chippy Chili & Cheese (110g)", 42.00, 0 }
            };

            bool valid = true;
            while (valid)
            {
                Console.WriteLine("============= SNACKS MENU =============");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ==================================== PRICE =====");

                for (int i = 0; i < snacksList.Count; i++)
                {
                    object[] product = (object[])snacksList[i];
                    Console.WriteLine($"{i + 1,2}. {product[0],-40} PHP {product[1],8:F2}");
                }

                Console.WriteLine("[x] Return to Main Menu");
                Console.WriteLine("============================================");
                Console.Write("Enter product number: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "0":
                        Console.Write("Enter snack name: ");
                        string search = Console.ReadLine().ToLower();

                        Console.WriteLine("===== PRODUCT ==================================== PRICE =====");
                        bool found = false;
                        foreach (object[] product in snacksList)
                        {
                            string productName = product[0].ToString().ToLower();
                            if (productName.Contains(search))
                            {
                                Console.WriteLine($"{product[0],-40} PHP {product[1],8:F2}");
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("[Snack not found!]");
                        }
                        break;

                    case "x":
                        valid = false;
                        break;
                    default:
                        if (int.TryParse(choice, out int index) && index >= 1 && index <= snacksList.Count)
                        {
                            object[] selectedProduct = (object[])snacksList[index - 1];

                            Console.Write($"Enter quantity for {selectedProduct[0]}: ");
                            int quantity;
                            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                            {
                                selectedProduct[2] = quantity;
                                cart.addCart(selectedProduct);
                                Console.WriteLine($"{quantity}x {selectedProduct[0]} added to cart!");

                                // Ask what to do next
                                Console.WriteLine("\nWould you like to:");
                                Console.WriteLine("[1] Continue shopping in Snacks");
                                Console.WriteLine("[2] Return to Main Menu");
                                Console.Write("Enter your choice: ");
                                string nextChoice = Console.ReadLine();
                                Console.Clear();

                                if (nextChoice == "2") valid = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;

                }
            }
        }
    }

    public class Sweets

    {
        private AddCart cart;


        public Sweets(AddCart cart)
        {
            this.cart = cart;
        }

        public void sweetsMenu()
        {

            ArrayList sweetsList = new ArrayList()
        {
            new object[] { "Toblerone Milk Chocolate (100g)", 120.00, 0 },
            new object[] { "Toblerone Dark Chocolate (100g)", 125.00, 0 },
            new object[] { "Cadbury Dairy Milk (150g)", 140.00, 0 },
            new object[] { "Cadbury Fruit & Nut (150g)", 150.00, 0 },
            new object[] { "KitKat 4-Finger (37g)", 55.00, 0 },
            new object[] { "KitKat Chunky (50g)", 65.00, 0 },
            new object[] { "Snickers Bar (50g)", 50.00, 0 },
            new object[] { "Twix Bar (50g)", 50.00, 0 },
            new object[] { "Ferrero Rocher (3 pieces)", 150.00, 0 },
            new object[] { "Reese's Peanut Butter Cups (42g)", 60.00, 0 },

            new object[] { "Gummy Bears (100g)", 85.00, 0 }
        };

            bool valid = true;
            while (valid)
            {
                Console.WriteLine("============= SWEETS MENU =============");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ==================================== PRICE =====");

                for (int i = 0; i < sweetsList.Count; i++)
                {
                    object[] product = (object[])sweetsList[i];
                    Console.WriteLine($"{i + 1,2}. {product[0],-40} PHP {product[1],8:F2}");
                }

                Console.WriteLine("[x] Return to Main Menu");
                Console.WriteLine("============================================");
                Console.Write("Enter product number: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "0":
                        Console.Write("Enter sweet name: ");
                        string search = Console.ReadLine().ToLower();

                        Console.WriteLine("===== PRODUCT ==================================== PRICE =====");
                        bool found = false;
                        foreach (object[] product in sweetsList)
                        {
                            string productName = product[0].ToString().ToLower();
                            if (productName.Contains(search))
                            {
                                Console.WriteLine($"{product[0],-40} PHP {product[1],8:F2}");
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("[Sweet not found!]");
                        }
                        break;

                    case "x":
                        valid = false;
                        break;

                    default:
                        if (int.TryParse(choice, out int index) && index >= 1 && index <= sweetsList.Count)
                        {
                            object[] selectedProduct = (object[])sweetsList[index - 1];

                            Console.Write($"Enter quantity for {selectedProduct[0]}: ");
                            int quantity;
                            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                            {
                                selectedProduct[2] = quantity;
                                cart.addCart(selectedProduct);
                                Console.WriteLine($"{quantity}x {selectedProduct[0]} added to cart!");


                                Console.WriteLine("\nWould you like to:");
                                Console.WriteLine("[1] Continue shopping in Sweets");
                                Console.WriteLine("[2] Return to Main Menu");
                                Console.Write("Enter your choice: ");
                                string nextChoice = Console.ReadLine();
                                Console.Clear();

                                if (nextChoice == "2") valid = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                        }
                        break;
                }
            }
        }
    }
}

