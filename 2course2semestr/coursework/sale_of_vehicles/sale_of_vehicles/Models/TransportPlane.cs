﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_vehicles.Models
{
    public class TransportPlane : Vehicle
    {
        public TransportPlane(string name, double price, int numberOfSeats, TypesOfFuel fuelType) : base(name, price, numberOfSeats, fuelType)
        {

        }

        public override bool CheckFunctionality()
        {
            throw new NotImplementedException();
        }
    }
}