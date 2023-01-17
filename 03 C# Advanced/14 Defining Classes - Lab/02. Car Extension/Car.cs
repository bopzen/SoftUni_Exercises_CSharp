﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make 
        { 
            get { return make; } 
            set { make = value; } 
        }
        public string Model 
        { 
            get { return model; } 
            set { model = value; } 
        }
        public int Year 
        { 
            get { return year; } 
            set { year = value; } 
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double fuelLeft = fuelQuantity - distance * fuelConsumption;
            if (fuelLeft >= 0)
            {
                fuelQuantity = fuelLeft;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
        }

        public string WhoAmI()
        {
            return ($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}");
        }
    }
}
