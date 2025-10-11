using System;

class Program
{
    static void Main(string[] args)
    {
           Address addr1 = new Address("1600 Pennylvania Avenue", "NW", "Washington, D.C.", "USA");
        Customer cust1 = new Customer("Sibey B. Norris", addr1);

        Address addr2 = new Address("3rd Street Sinkor", "Montserrado", "Monrovia", "Liberia");
        Customer cust2 = new Customer("Famata Jalloh", addr2);

        Address addr3 = new Address("140 Allison Street", "Montserrado", "Monrovia", "Liberia");
        Customer cust3 = new Customer("Tetta George", addr3);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Keyboard", "KB001", 7, 5));
        order1.AddProduct(new Product("Chacha", "CS002", 5, 6));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Perfume", "Perfume006", 10, 8));
        order2.AddProduct(new Product("Hair Greece", "HGreece004", 12, 6));

        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("Hair Conditional", "HC005", 10, 5));
        order3.AddProduct(new Product("Powder", "PD-003", 15, 8));

        order1.DisplayOrder();
        order2.DisplayOrder();
        order3.DisplayOrder();
    }
}