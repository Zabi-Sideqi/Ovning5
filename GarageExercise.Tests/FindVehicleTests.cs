using GarageExercise.Garage;
using GarageExercise.Models;

namespace GarageExercise.Tests;

public class FindVehicleTests
{
    [Fact]
    public void FindVehicle_ExistingVehicle_ReturnsVehicle()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        var car = new Car(
            "ABC123",
            "Red",
            4,
            "Gasoline");

        garage.AddVehicle(car);

        // Act
        var result = garage.FindVehicle("ABC123");

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void FindVehicle_NonExistingVehicle_ReturnsNull()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        // Act
        var result = garage.FindVehicle("XYZ999");

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void FindVehicle_CaseInsensitive_ReturnsVehicle()
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
        var result = garage.FindVehicle("abc123");

        // Assert
        Assert.NotNull(result);
    }
}