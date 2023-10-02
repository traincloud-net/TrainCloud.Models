using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Registry;
public class CarModel
{
    public Guid Id { get; set; }

    public string CarTypeCode { get; set; } = string.Empty;

    public string CountryCode { get; set; } = string.Empty;

    public string CarClassCode { get; set; } = string.Empty;

    public string CarClassSerialNr { get; set; } = string.Empty;

    public string Checksum { get; set; } = string.Empty;

    public string FullUIC { get; set; } = string.Empty;

    public string CarCategory { get; set; } = string.Empty;

    public string? VKMCode { get; set; }

    public string? VKM { get; set; }

    public decimal? LengthOverBuffers { get; set; }

    public decimal? TareWeight { get; set; }

    public decimal? MaximumPayload { get; set; }

    public decimal? BruttoWeight { get; set; }

    public decimal? NumberOfWheels { get; set; }

    public string? TypeOfBrakes { get; set; }

    public string? BreakShoeSole { get; set; }

    public string? SpecialBrakeType { get; set; }

    public decimal? HandbrakeWeightFreightCar { get; set; }

    public decimal? HandbrakeForceFreightCar { get; set; }

    public decimal? ConversionWeightFreightWagon { get; set; }

    public decimal? BrakeWeightFreightCarEmpty { get; set; }

    public decimal? BrakeWeightFreightCarLoaded { get; set; }

    public bool DangerousGoodsCar { get; set; }

    public string? ECMMail { get; set; }

    public string? FreightCarCategory { get; set; }

    public string? ReferenceProfile { get; set; }

    public string? RMin { get; set; }

    public decimal? BrakeRPlusE160 { get; set; }

    public decimal? BrakeRPlusE { get; set; }

    public decimal? BrakeR { get; set; }

    public decimal? BrakePPlusE { get; set; }

    public decimal? BrakeP2 { get; set; }

    public decimal? BrakeP { get; set; }

    public decimal? BrakeG { get; set; }

    public decimal? BrakeRPlusMgrot { get; set; }

    public decimal? BrakeRplusMg { get; set; }

    public decimal? BrakeRrot { get; set; }

    public decimal? BrakePplusMgRot { get; set; }

    public decimal? BrakePPlusMg { get; set; }

    public decimal? BrakeProt { get; set; }

    public decimal? BrakeGrot { get; set; }

    public DateTimeOffset LastChange { get; set; }

    public string? CarComment { get; set; }
}
