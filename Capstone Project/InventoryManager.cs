using System;
using System.Collections.Generic;
class InventoryManager
{
    static List<string> products = new List<string>();
    static List<string> productPrices = new List<string>();
    static List<string> productQuantities = new List<string>();
   
    static void Main(string[]args)
    {
    bool exit = false;
        while(!exit)
        {
            Console.WriteLine("\nInventor Manager Menu");
            Console.WriteLine("1. Add New product");
            Console.WriteLine("2. View products in stock");
            Console.WriteLine("3. Remove Products");
            Console.WriteLine("4. Update stock");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\n Please select an option 1-5");
            string selectOption=Console.ReadLine();
           
            switch (selectOption)
            {
                case "1":
                addProduct();
                break;
               
                case "2":
                viewProducts();
                break;
               
                case "3":
                removeProduct();
                break;
               
                case "4":
                updateStock();
                break;
               
                case "5":
                exit = true;
                break;
               
                default:
                Console.WriteLine("Please enter a valid selection");
                break;
            }
            static void addProduct()
            {
                while(true)
                {
                Console.WriteLine("Enter the product: ");
                string product = Console.ReadLine();
                  while(product == "")
                    {
                    Console.WriteLine("Cannot leave the product description empty.");
                    Console.WriteLine("Enter the product: ");
                    product = Console.ReadLine();
                    continue;
                    }
               
                Console.WriteLine("Enter the product Price: ");
                string price = Console.ReadLine();
                   while(price == "")
                    {
                        Console.WriteLine("Cannot leave price blank, Kindly enter the product price ");
                        Console.WriteLine("Enter the product Price: ");
                        price = Console.ReadLine();
                        continue;
                    }
               
                Console.WriteLine("Enter the quantity to be added : ");
                string quantity = Console.ReadLine();
                    while(quantity  == "")
                    {
                        Console.WriteLine("Cannot leave the quantity blank, Kindly enter the product quantity");
                        Console.WriteLine("Enter the quantity to be added : ");
                        quantity = Console.ReadLine();
                        continue;
                    }
                products.Add(product);
                productPrices.Add(price);    
                productQuantities.Add(quantity);
               
                Console.WriteLine("Product added succesfully!");
                break;
                }    
            }
            static void viewProducts()
            {
                if (products.Count == 0)
                 {
                      Console.WriteLine("No products available in the system. Please add some to view!");
                    return;
                 }

                Console.WriteLine("Products:");
                    for (int i = 0; i < products.Count; i++)
                    {
                       Console.WriteLine($"{i + 1}. Name: {products[i]}, Price: {productPrices[i]}, Quantity: {productQuantities[i]}");

                    }
            }
            static void removeProduct()
            {
                if (products.Count == 0)
                {
                        Console.WriteLine("No products available to remove.");
                        return;
                }

                Console.WriteLine("Select a product to remove:");
                    for (int i = 0; i < products.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {products[i]} - Price: {productPrices[i]}, Quantity: {productQuantities[i]}");
                        }

                Console.Write("Enter the product number to remove: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > products.Count)
                        {
                            Console.WriteLine("Invalid selection.");
                            return;
                        }
                int index = choice - 1;
                Console.WriteLine($"Are you sure you want to remove {products[index]}? (yes/no)");
                string confirmation = Console.ReadLine().Trim().ToLower();

                    if (confirmation == "yes")
                        {
                            products.RemoveAt(index);
                            productPrices.RemoveAt(index);
                            productQuantities.RemoveAt(index);
                            Console.WriteLine("Product removed successfully.");
                        }
                    else
                        {
                            Console.WriteLine("Product removal cancelled.");
                        }
            }
            static void updateStock()
            {
                 if (products.Count == 0)
                     {
                         Console.WriteLine("No products available to update. Please add some products first.");
                        return;
                      }

                Console.WriteLine("Select a product to update stock:");
                        for (int i = 0; i < products.Count; i++)
                                 {
                                     Console.WriteLine($"{i +1}. {products[i] } - Current Quantity: {productQuantities[i]}");
                                }

                Console.Write("Enter the product number: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > products.Count)
                          {
                            Console.WriteLine("Invalid selection.");
                               return;
                         }

              int index = choice - 1;
           
                 Console.WriteLine("Do you want to 'sell' or 'restock' the product?");
                    string action = Console.ReadLine().Trim().ToLower();

                if (action != "sell" && action != "restock")
                    {
                      Console.WriteLine("Invalid action. Please enter 'sell' or 'restock'.");
                        return;
                     }

                 Console.Write("Enter the quantity: ");
                     if (!int.TryParse(Console.ReadLine(), out int amount) || amount < 1)
                         {
                         Console.WriteLine("Invalid quantity.");
                         return;
                         }

                  int currentQuantity = int.Parse(productQuantities[index]);

                       if (action == "sell")
                             {
                                 if (amount > currentQuantity)
                             {
                        Console.WriteLine("Not enough stock to sell that amount.");
                        return;
                     }

                 currentQuantity -= amount;
                     }
                   else if (action == "restock")
                          {
                          currentQuantity += amount;
                          }

                 productQuantities[index] = currentQuantity.ToString();
                         Console.WriteLine($"Stock updated. New quantity for {products[index]}: {currentQuantity}");
            }
   
        }
    }
}
