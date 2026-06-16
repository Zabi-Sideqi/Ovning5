using GarageExercise.Garage;
using GarageExercise.Models;

namespace GarageExercise.Tests;

public class RemoveVehicleTests
{
    [Fact]
    public void RemoveVehicle_ExistingVehicle_ReturnsTrue()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        // Act
        bool result =
            garage.RemoveVehicle("ABC123");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void RemoveVehicle_NonExistingVehicle_ReturnsFalse()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        // Act
        bool result =
            garage.RemoveVehicle("XYZ999");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void RemoveVehicle_RemovedVehicle_CannotBeFound()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        // Act
        garage.RemoveVehicle("ABC123");

        var result =
            garage.FindVehicle("ABC123");

        // Assert
        Assert.Null(result);
    }
}