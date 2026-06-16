using GarageExercise.Garage;
using GarageExercise.Models;
using System.Runtime.InteropServices;
namespace GarageExercise.Tests
{
    public class GarageTests
    {
        [Fact]
        public void AddVehicle_ValidVehicle_ReturnsTrue()
        {
            //Arrange
            var garage = new Garage<Vehicle>(5);

            var car = new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline");

            //Act
            bool result = garage.AddVehicle(car);

            // Assert 
            Assert.True(result);

        }

        [Fact]
        public void AddVehicle_DuplicateRegistration_ReturnsFalse()
        {
            // Arrange
            var garage = new Garage<Vehicle>(5);
            garage.AddVehicle(
                new Car(
                    "ABC123",
                    "RED",
                    4,
                    "Gasoline"));

            //Act
            bool result = garage.AddVehicle(
                new Car(
                    "ABC123",
                    "Blue",
                    4,
                    "Diesel"));
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void AddVehicle_GarageFull_ReturnsFalse()
        {
            // Arrange
            var garage = new Garage<Vehicle>(1);

            garage.AddVehicle(
                new Car(
                    "ABC123",
                    "Red",
                    4,
                    "Gasoline"));

            // Act
            bool result = garage.AddVehicle(
                new Car(
                    "DEF456",
                    "Blue",
                    4,
                    "Diesel"));

            // Assert
            Assert.False(result);
        }
    }
}