using ExceptionProject;
using System;
using System.Collections.Generic;
using ConsoleApp30;

internal class Program
{
    private static void Main(string[] args)
    {
        var deleviry = new Deleviry { Id = 1001, Address = "8 Al-AnsaarST", CustomerName = "Yahia", };
        var deliveryService = new DeliveryService();
        deliveryService.start(deleviry);
      
        Console.WriteLine(deleviry);
    }
}