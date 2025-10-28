namespace Homework8;

using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    // Q1
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;
        foreach (Customer c in customer_list)
        {
            totalCredit += c.customerCredit;
        }
        Console.WriteLine($"Total credit of all customers: {totalCredit}");
    }

    // Q2
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int sumAge = 0;
        int count = 0;
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                sumAge += c.customerAge;
                count++;
            }
        }
        if (count > 0)
        {
            double averageAge = (double)sumAge / count;
            Console.WriteLine($"Average age of customers in Amarillo: {averageAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers found in Amarillo.");
        }
    }

    // Q3
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Customers in Canyon older than 30:");
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Canyon" && c.customerAge > 30)
            {
                Console.WriteLine(c.customerName);
            }
        }
    }
}

// Q0
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}