using Domain;
using Domain.Services;
using System;

namespace StrategyPattern {
    public class Program {
        static void Main(string[] args) {
            var order = new Order {
                Origin = new Address {
                    ContactName = "José da Silva",
                    Country = "Brasil",
                    City = "São José do Rio Preto",
                    PostalCode = "15050-132",
                    AddressLine1 = "Rua XXX"
                },
                Destination = new Address {
                    ContactName = "Lucas Palhares",
                    Country = "Brasil",
                    City = "São José do Rio Preto",
                    PostalCode = "15050-130",
                    AddressLine1 = "Rua ABC"
                }
            };
            var service = new CostCalculationService_WithStrategy(new FedexShippingStrategy());

            var cost = service.CalculateShippingCost(order);

            Console.WriteLine(cost);

            Console.ReadKey();
        }
    }
}
