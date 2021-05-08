using System;

class UsingDecimal
{
    static void Main()
    {
        decimal price;
        decimal discount;
        decimal discounted_price;

        price = 19.95m;
        discount = 0.15m;

        discounted_price = price - (price * discount);

        Console.WriteLine("Цена со скидкой: " + discounted_price);
    }
}