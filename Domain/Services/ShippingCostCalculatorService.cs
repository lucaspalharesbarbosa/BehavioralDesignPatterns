﻿using Domain.Enums;
using System;

namespace Domain.Services {
    public class ShippingCostCalculatorService {
        public double CalculateShippingCost(Order order) {
            switch (order.ShippingOption) {
                case ShippingOptions.FedEx:
                    return CalculateForFedEx(order);

                case ShippingOptions.UPS:
                    return CalculateForUPS(order);

                case ShippingOptions.Schenker:
                    return CalculateForSchenker(order);

                default:
                    throw new Exception("Unknown carrier");
            }

        }

        double CalculateForSchenker(Order order) {
            return 3.00d;
        }

        double CalculateForUPS(Order order) {
            return 4.25d;
        }

        double CalculateForFedEx(Order order) {
            return 5.00d;
        }
    }
}
