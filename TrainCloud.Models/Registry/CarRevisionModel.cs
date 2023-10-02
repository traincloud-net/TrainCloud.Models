using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Registry;

public class CarRevisionModel
{
    public string FullUIC { get; set; }



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

    public bool? DangerousGoodsCar { get; set; }

    public string? ECMMail { get; set; }
}
