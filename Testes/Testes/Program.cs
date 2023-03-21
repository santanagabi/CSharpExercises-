using System;
using System.Collections.Generic;
using System.Globalization;
using Testes.Entities;
using Testes.Entities.Enums;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumeraação e Composição
            // conjunto de constantes // OrderStatus
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayement
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayement.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            // Composição = objeto contenha outro
        }
    }
}