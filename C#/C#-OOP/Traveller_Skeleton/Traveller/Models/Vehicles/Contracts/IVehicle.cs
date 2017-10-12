namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int PassangerCapacity { get; }

        VehicleType Type { get; set; }

        decimal PricePerKilometer { get; }
    }
}