namespace TrainCloud.Models;

[Flags]
public enum Feature 
{
    CarLists = 1, // TenantWgm & TenantOwner
    DisturbanceForcedBrakings = 2, // TenantUser  (new&view)& TenantTfTraincee (new&view)+ TenantOwner
    DisturbanceLocomotive = 4, // TenantUser (new&view)+ TenantOwner & ECM 1-4 & TenantTfTraincee (new&view)
    DisturbanceAvv = 8, // TenantOwner & ECM 1-4 & TenantDamagedCarManager+ TenantWgm (new&view)
    DisturbanceAtb = 16, // TenantUser  (new&view) + TenantOwner& TenantTfTraincee (new&view)
    DisturbanceEtcs = 32, // TenantUser  (new&view)& TenantTfTraincee (new&view)+ TenantOwner
    DisturbanceVehicleBook = 64, // TenantUser & TenantTfTraincee + TenantOwner & ECM 1-4
    Reports = 128, // TenantOwner
    Pzb = 265, // TenantOwner & TenantOperationalEvaluator
    Ecm = 512 // TenantOwner & ECM 1-4
}
