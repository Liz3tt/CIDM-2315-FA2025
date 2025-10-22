using System.Security.Cryptography.X509Certificates;

namespace Homework7;

//Source cited: Microsoft Copilot. Accessed 10/20/2025. "Show me how to fix my customer class"
public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    // Constructor
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    // Method to change customer ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method to print customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer Info: ID = {cus_id}, Name = {cus_name}, Age = {cus_age}");
    }

    // Method to compare age with another customer
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"Older Customer: {this.cus_name}");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"Older Customer: {objCustomer.cus_name}");
        }
        else
        {
            Console.WriteLine("Both customers are the same age.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Print initial info
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Update IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Print updated info
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Compare ages
        customer1.CompareAge(customer2);
    }
}
