using GarageExercise.Garage;
using GarageExercise.Models;

namespace GarageExercise.Tests;

public class SearchVehicleTests
{
    [Fact]
    public void SearchByType_ExistingType_ReturnsVehicles()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        garage.AddVehicle(
            new Car(
                "DEF456",
                "Blue",
                4,
                "Diesel"));

        // Act
        var result = garage.SearchByType("Car");

        // Assert
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void SearchByType_NonExistingType_ReturnsEmptyList()
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
        var result = garage.SearchByType("Boat");

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void SearchByColorAndWheels_MatchingVehicles_ReturnsVehicles()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        garage.AddVehicle(
            new Car(
                "DEF456",
                "Blue",
                4,
                "Diesel"));

        // Act
        var result =
            garage.SearchByColorAndWheels(
                "Red",
                4);

        // Assert
        Assert.Single(result);
    }

    [Fact]
    public void SearchVehicles_ColorSearch_ReturnsMatchingVehicles()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        garage.AddVehicle(
            new Car(
                "DEF456",
                "Blue",
                4,
                "Diesel"));

        // Act
        var result =
            garage.SearchVehicles(
                null,
                "Red",
                null);

        // Assert
        Assert.Single(result);
    }

    [Fact]
    public void SearchVehicles_RegistrationNumber_ReturnsVehicle()
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
        var result =
            garage.SearchVehicles(
                "ABC123",
                null,
                null);

        // Assert
        Assert.Single(result);
    }

    [Fact]
    public void SearchVehicles_MultipleCriteria_ReturnsMatchingVehicle()
    {
        // Arrange
        var garage = new Garage<Vehicle>(5);

        garage.AddVehicle(
            new Car(
                "ABC123",
                "Red",
                4,
                "Gasoline"));

        garage.AddVehicle(
            new Car(
                "DEF456",
                "Blue",
                4,
                "Diesel"));

        // Act
        var result =
            garage.SearchVehicles(
                null,
                "Red",
                4);

        // Assert
        Assert.Single(result);
    }
}