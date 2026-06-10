using GarageExercise.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly T[] vehicles;

        public int Capacity { get; }

        public int Count { get; private set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new T[capacity];
            Count = 0;
        }
    
      public bool AddVehicle(T vehicle)
        {
            if (FindVehicle(vehicle.RegistrationNumber) != null)
            {
                return false;
            }
            if (Count >= Capacity)
            {
                return false;
            }
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    Count++;
                    return true;
                }
            }
            return false;
        }

        public T? FindVehicle(string registrationNumber)
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null &&
                    vehicle.RegistrationNumber.Equals(
                        registrationNumber,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return vehicle;
                }
            }
            return null;
        }

        public bool RemoveVehicle(string registrationNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null &&
                    vehicles[i].RegistrationNumber.Equals(
                        registrationNumber,
                        StringComparison.OrdinalIgnoreCase))

                {
                    vehicles[i] = null;
                    Count--;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var  vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }   

        public Dictionary<string, int > GetVehicleTypesCount()
        { Dictionary<string, int> vehicleTypes = new Dictionary<string, int>();
            foreach (var vehicle in this)
            {
                string TypeName = vehicle.GetType().Name;
                if (vehicleTypes.ContainsKey(TypeName))
                {
                    vehicleTypes[TypeName]++;
                }
                else
                {
                    vehicleTypes[TypeName] = 1;
                }
                
            }
            return vehicleTypes;
        }

        public List<T> SearchByColorAndWheels(
            string color,
            int numberOfWheels)
        {
            List<T> result = new List<T>();

            foreach (var vehicle in this)
            {
                if (vehicle.Color.Equals(
                    color,
                    StringComparison.OrdinalIgnoreCase)
                    && vehicle.NumberOfWheels == numberOfWheels)
                {
                    result.Add(vehicle);
                }
            }
            return result;

        }

        public List<T> SearchByType(string type)
        {
            List<T> result = new List<T>();
            foreach (var vehicle in this)
            {
                if (vehicle.GetType().Name.Equals(
                    type,
                    StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(vehicle);
                }
            }
            return result;
        }
    }
}