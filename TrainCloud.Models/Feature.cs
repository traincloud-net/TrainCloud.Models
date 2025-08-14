namespace TrainCloud.Models;

[Flags]
public enum Feature : short
{
    CarLists = 1, // TenantDispatcher & TenantWgm & TenantOwner
    DisturbanceForcedBrakings = 2, // TenantUser  (new&view)& TenantTfTraincee (new&view)+ TenantOwner
    DisturbanceLocomotive = 4, // TenantUser (new&view)+ TenantOwner & ECM 1-4 & TenantTfTraincee (new&view)
    DisturbanceAvv = 8, // TenantOwner & ECM 1-4 & TenantDamagedCarManager+ TenantWgm (new&view)
    DisturbanceAtb = 16, // TenantUser  (new&view) + TenantOwner& TenantTfTraincee (new&view)
    DisturbanceEtcs = 32, // TenantUser  (new&view)& TenantTfTraincee (new&view)+ TenantOwner
    DisturbanceVehicleBook = 64, // TenantDispatcher & TenantUser & TenantTfTraincee + TenantOwner & ECM 1-4
    DisturbanceBook = 128, // TenantDispatcher & TenantUser & TenantTfTraincee + TenantOwner & ECM 1-4
    Reports = 256, // TenantOwner
    Pzb = 512, // TenantOwner & TenantOperationalEvaluator
    Ecm = 1024, // TenantOwner & ECM 1-4
    IncidentIncident = 2048,// TenantOwner & TenantOperationalEvaluator // TenantUser  (new&view)& TenantTfTraincee (new&view)  // TenantDispatcher (new&view&Edit)
    IncidentTowingDrive = 4096, // TenantOwner & TenantOperationalEvaluator // TenantUser  (new&view)& TenantTfTraincee (new&view)
    IncidentMonitoringIvb = 8192,// TenantOwner & TenantOperationalEvaluator // TenantUser  (new&view)& TenantTfTraincee (new&view)
}
