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
            ArrayList items = new ArrayList();
            CannedGoods cg = new CannedGoods();
            Fruits fruit = new Fruits();
            Vegetables veggie = new Vegetables();

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
                    break;
                case "6":
                    break;

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
    public class AddCart {
        public void addCart(Array[] product) {
            ArrayList addTOCart = new ArrayList();
            addTOCart.Add(product);

        }
        public void showCart() {
            //
        }
    } 
    public class CannedGoods
    {
        public void cgMenu()
        {
            AddCart cart = new AddCart();
            ArrayList products = new ArrayList()
            {
                new object[] { "555 Sardines Spanish Style (155g)", 90.00, 0 },
                new object[] { "555 Sardines Tomato Sauce with Chili (15oz)", 198.00, 0 },
                new object[] { "Argentina Luncheon Meat (12oz)", 330.00, 0 },
                new object[] { "Blue Bay Fried Sardines Hot & Spicy", 82.00, 0},
                new object[] { "Blue Bay Sardines in Tomato Sauce", 82.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Olive Oil", 180.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Tomato Sauce", 180.00, 0 },
                new object[] { "Century Tuna - Corned Tuna Style", 170.00, 0 },
                new object[] { "Century Tuna - Chili Corned Tuna Style", 180.00, 0 },
                new object[] { "Century Tuna - Tuna Adobo Style", 136.00, 0 },
                new object[] { "Century Tuna - Tuna Afritada Style", 163.00, 0 },
                new object[] { "Century Tuna - Tuna Caldereta Style", 163.00, 0 },
                new object[] { "Century Tuna - Tuna Flakes in Soya Oil", 190.00, 0 },
                new object[] { "Century Tuna - Tuna Hot & Spicy Style", 200.00, 0 },
                new object[] { "Century Tuna - Tuna Mechado Style", 180.00, 0 },
                new object[] { "Century Tuna - Tuna with Calamansi (Lime)", 210.00, 0 },
                new object[] { "Ligo Sardines in Tomato Sauce Extra Hot", 50.00, 0 },
                new object[] { "Ligo Sardines Regular (Green, Small)", 92.00, 0 },
                new object[] { "Ligo Sardines with Chili (Red, Small)", 95.00, 0 },
                new object[] { "Maling Luncheon Meat Premium", 290.00, 0 }
            };
            Console.WriteLine("================================ CANNED GOODS ================================");
            Console.WriteLine("[0] Search an Item");
            Console.WriteLine("===== PRODUCT ==================================================== PRICE =====");
           
            for (int i = 0; i < products.Count; i++)
            {
                object[] product = (object[])products[i];
                Console.WriteLine($"{i + 1,2}. {product[0],-60} PHP {product[1],8:F2}");
            }
            Console.WriteLine("==============================================================================");
            Console.Write("Enter product number: ");
            string choice = Console.ReadLine();
            Console.Clear();    

            switch (choice)
            {
                case "0":
                    Boolean valid = false;

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
                    Console.WriteLine("[1]Input Quantity");
                    Console.WriteLine("[2] return");
                    Console.Write("Enter 1 to set quantity or 2 to return: ");
                    string input = Console.ReadLine();
                    
                    if (input.Equals("1")){ 
                        object[] product = (object[])products[0];

                        Console.WriteLine("How many would you like to buy: ");
                        string quantity1 = Console.ReadLine();

                        product[3] = quantity1;
                        cart.addCart(product[]);


                    }
                    if (input.Equals("2")) {
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    Console.WriteLine("[1]Quantity");
                    Console.WriteLine("[2] return");
                    Console.Write("Enter 1 to set quantity or 2 to return: ");
                    string quantity2 = Console.ReadLine();
                    break;
                case "x":
                case "X":
                    Console.WriteLine();
                    break;
            }
        }
    }
    public class Fruits{
        public void fruitsMenu(){
            while (true){
                ArrayList fruitList = new ArrayList{
                    new object[] {"Apple", 20.00, 0},
                    new object[] {"Banana", 30.00, 0},
                    new object[] {"Blueberry", 75.00, 0},
                    new object[] {"Coconut", 20.00, 0},
                    new object[] {"Grapes", 60.00, 0},
                    new object[] {"Mango", 50.00, 0},
                    new object[] {"Orange", 40.00, 0},
                    new object[] {"Papaya", 45.00, 0},
                    new object[] {"Strawberry", 55.00, 0},
                    new object[] {"Watermelon", 35.00, 0}
                };
                Console.WriteLine("================================= FRUITS ================================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ======================================== PRICE PER KG =====");
                for (int i = 0; i < fruitList.Count; i++) {
                    object[] fruit = (object[]) fruitList[i];
                    Console.WriteLine($"{i + 1,2}. {fruit[0],-15} PHP {fruit[1],8:F2}");
                }
                Console.WriteLine("\n[x] Return to Main Menu");
                Console.WriteLine("=========================================================================");
                
                Console.WriteLine("Enter the assigned number of your desired product: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice){
                    case "0":
                        Console.WriteLine("Enter an item (fruit) to search: ");
                        string userFruit = Console.ReadLine();

                        bool found = false;

                            foreach (object[] item in fruitList) { 
                                string fruitName = item[0].ToString().ToLower();
                                if (fruitName.StartsWith(userFruit)){
                                        Console.WriteLine($"Item: {item[0]} Price: Php {item[1]}");
                                        found = true;
                                       // break;
                                }
                            } 
                        if (!found){
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "1":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string appleChoice = Console.ReadLine();
                            if(appleChoice == "1") {
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int appleQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = appleQuantity;
                                //cart.addCart(fruit[]);
                            } else if(appleChoice == "x" || appleChoice == "X") {
                                break; 
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "2":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string bananaChoice = Console.ReadLine();
                            if(bananaChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int bananaQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = bananaQuantity;
                                //cart.addCart(fruit[]);
                            } else if(bananaChoice == "x" || bananaChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "3":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string blueberryChoice = Console.ReadLine();
                            if(blueberryChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int blueberryQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = blueberryQuantity;
                                //cart.addCart(fruit[]);
                            } else if(blueberryChoice == "x" || blueberryChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "4":
                        while(true){}
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string coconutChoice = Console.ReadLine();
                            if(coconutChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int coconutQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = coconutQuantity;
                                //cart.addCart(fruit[]);
                            } else if(coconutChoice == "x" || coconutChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        break;
                    case "5":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string grapesChoice = Console.ReadLine();
                            if(grapesChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int grapesQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = grapesQuantity;
                                //cart.addCart(fruit[]);
                            } else if (grapesChoice == "x" || grapesChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "6":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[2] Return to Fruits Menu");
                            string mangoChoice = Console.ReadLine();
                            if(mangoChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int mangoQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = mangoQuantity;
                                //cart.addCart(fruit[]);
                            } else if(mangoChoice == "x" || mangoChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "7":    
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string orangeChoice = Console.ReadLine();
                            if(orangeChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int orangeQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = orangeQuantity;
                                //cart.addCart(fruit[]);
                            } else if(orangeChoice == "x" || orangeChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "8":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string papayaChoice = Console.ReadLine();
                            if(papayaChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int papayaQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = papayaQuantity;
                                //cart.addCart(fruit[]);
                            } else if(papayaChoice == "x" || papayaChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input, Please try again.");
                            }
                        }
                        break;    
                    case "9":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string strawberryChoice = Console.ReadLine();
                            if(strawberryChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int strawberryQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = strawberryQuantity;
                                //cart.addCart(fruit[]);
                            } else if(strawberryChoice == "x" || strawberryChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;    
                    case "10":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string watermelonChoice = Console.ReadLine();
                            if(watermelonChoice == "1"){
                                object[] fruit = (object[])fruitList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int watermelonQuantity = Convert.ToInt16(Console.ReadLine());
                                fruit[3] = watermelonQuantity;
                                //cart.addCart(fruit[]);
                            } else if (watermelonChoice == "x" || watermelonChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;    
                    case "x":
                    case "X":
                        Console.Write("Returning to Main Menu.");
                        try{
                            Thread.Sleep(1000);
                        }catch (Exception e){
                            Console.WriteLine(e);
                        }
                        Console.Write(".");
                        try{
                            Thread.Sleep(500);
                        }
                        catch (Exception e){
                            Console.WriteLine(e);
                        }
                        Console.Write(".");
                        try{
                            Thread.Sleep(1000);
                        }catch (Exception e){
                            Console.WriteLine(e);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
    public class Vegetables {
        public void veggieMenu(){
            while (true){
                ArrayList veggieList = new ArrayList{
                    new object[] {"Beans", 60.00},
                    new object[] {"Broccoli", 75.00},
                    new object[] {"Cabbage", 85.00},
                    new object[] {"Carrot", 20.00},
                    new object[] {"Cucumber", 55.00},
                    new object[] {"Eggplant", 50.00},
                    new object[] {"Garlic", 40.00},
                    new object[] {"Ginger", 45.00},
                    new object[] {"Onion", 35.00},
                    new object[] {"Potato", 60.00}
                };
                Console.WriteLine("============================== VEGETABLES ===============================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ======================================== PRICE PER KG =====");
                for (int i = 0; i < veggieList.Count; i++) {
                    object[] veggie = (object[]) veggieList[i];
                    Console.WriteLine($"{i + 1,2}. {veggie[0],-15} PHP {veggie[1],8:F2}");
                }
                Console.WriteLine("\n[x] Return to Main Menu");
                Console.WriteLine("=========================================================================");
                
                Console.WriteLine("Enter the assigned number of your desired product: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice){
                    case "0":
                        Console.WriteLine("Enter an item (vegetable) to search: ");
                        string userVeggie = Console.ReadLine();

                        bool found = false;

                            foreach (object[] item in veggieList) { 
                                string veggieName = item[0].ToString().ToLower();
                                if (veggieName.StartsWith(userVeggie)){
                                        Console.WriteLine($"Item: {item[0]} Price: Php {item[1]}");
                                        found = true;
                                       // break;
                                }
                            } 
                        if (!found){
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "1":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string beansChoice = Console.ReadLine();
                            if(beansChoice == "1") {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int beansQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = beansQuantity;
                                //cart.addCart(fruit[]);
                            } else if(beansChoice == "x" || beansChoice == "X") {
                                break; 
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "2":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string broccoliChoice = Console.ReadLine();
                            if(broccoliChoice == "1") {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int broccoliQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = broccoliQuantity;
                                //cart.addCart(fruit[]);
                            } else if(broccoliChoice == "x" || broccoliChoice == "X") {
                                break; 
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "3":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Vegetables Menu");
                            string cabbageChoice = Console.ReadLine();
                            if(cabbageChoice == "1") {
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int cabbageQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = cabbageQuantity;
                                //cart.addCart(fruit[]);
                            } else if(cabbageChoice == "x" || cabbageChoice == "X") {
                                break; 
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "4":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string carrotChoice = Console.ReadLine();
                            if(carrotChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int carrotQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = carrotQuantity;
                                //cart.addCart(fruit[]);
                            } else if(carrotChoice == "x" || carrotChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "5":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string cucumberChoice = Console.ReadLine();
                            if(cucumberChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int cucumberQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = cucumberQuantity;
                                //cart.addCart(fruit[]);
                            } else if(cucumberChoice == "x" || cucumberChoice == "X") {
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "6":
                        while(true){}
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string eggplantChoice = Console.ReadLine();
                            if(eggplantChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int eggplantQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = eggplantQuantity;
                                //cart.addCart(fruit[]);
                            } else if(eggplantChoice == "x" || eggplantChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        break;
                    case "7":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string garlicChoice = Console.ReadLine();
                            if(garlicChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int garlicQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = garlicQuantity;
                                //cart.addCart(fruit[]);
                            } else if (garlicChoice == "x" || garlicChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("[1] Enter Quantity");
                        Console.WriteLine("[x] Return to Fruits Menu");
                        string gingerChoice = Console.ReadLine();
                            if(gingerChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int gingerQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = gingerQuantity;
                                //cart.addCart(fruit[]);
                            } else if(gingerChoice == "x" || gingerChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        break;
                    case "9":
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string onionChoice = Console.ReadLine();
                            if(onionChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int onionQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = onionQuantity;
                                //cart.addCart(fruit[]);
                            } else if(onionChoice == "x" || onionChoice == "X"){
                                break;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "10":    
                        while(true){
                            Console.WriteLine("[1] Enter Quantity");
                            Console.WriteLine("[x] Return to Fruits Menu");
                            string potatoChoice = Console.ReadLine();
                            if(potatoChoice == "1"){
                                object[] veggies = (object[])veggieList[0];
                                Console.WriteLine("How many would you like to buy: ");
                                int potatoQuantity = Convert.ToInt16(Console.ReadLine());
                                veggies[3] = potatoQuantity;
                                //cart.addCart(fruit[]);
                            } else if(potatoChoice == "x" || potatoChoice == "X"){
                                return;
                            } else {
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                    case "x":
                    case "X":
                        Console.Write("Returning to Main Menu.");
                        try{
                            Thread.Sleep(1000);
                        }catch (Exception e){
                            Console.WriteLine(e);
                        }
                        Console.Write(".");
                        try{
                            Thread.Sleep(500);
                        }
                        catch (Exception e){
                            Console.WriteLine(e);
                        }
                        Console.Write(".");
                        try{
                            Thread.Sleep(1000);
                        }catch (Exception e){
                            Console.WriteLine(e);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
