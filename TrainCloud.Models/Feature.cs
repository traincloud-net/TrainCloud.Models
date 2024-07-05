namespace TrainCloud.Models;

[Flags]
public enum Feature 
{
    CarLists = 1,
    ForcedBrakings = 2,
    FaultReportsLocomotive = 4,
    FaultReportsAvv = 8,
    FaultReportsAtb = 16,
    FaultReportsEtcs =32,
    VehicleBook = 64,
    Reports = 128
}
