﻿using System;

namespace sale_of_vehicles
{
    public abstract class Vehicle : IEquatable<Vehicle>
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public int NumberOfSeats { get; protected set; }
        public FuelType FuelType { get; protected set; }
        public IFunctionality Functionality { get; protected set; }

        protected Vehicle(string name, double price, int numberOfSeats, FuelType fuelType, IFunctionality functionality)
        {
            if (name == "")
                throw new Exception("Incorrect name!");
            if(price <= 0)
                throw new Exception("Incorrect price!");
            if(numberOfSeats <= 0)
                throw new Exception("Incorrect number Of Seats!");
            if (fuelType == null)
                throw new Exception("Fuel type can't be null!");

            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            NumberOfSeats = numberOfSeats;
            FuelType = fuelType;
            Functionality = functionality;
        }

        public abstract bool CheckFunctionality();

        public bool Equals(Vehicle? other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
