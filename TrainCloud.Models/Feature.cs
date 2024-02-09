namespace TrainCloud.Models;

[Flags]
public enum Feature
{
    CarLists = 1,
    ForcedBrakings = 2,
    FaultReports = 4
}
