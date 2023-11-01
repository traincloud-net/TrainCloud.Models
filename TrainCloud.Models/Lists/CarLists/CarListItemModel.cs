using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Lists.CarLists;

public class CarListItemModel
{
    public Guid Id { get; set; }

    public string FullUIC { get; set; } = string.Empty;

    public string? FreightCarCategory { get; set; }

    public decimal? NumberOfWheels { get; set; }

    public decimal? LengthOverBuffers { get; set; }

    public decimal? MaximumPayload { get; set; }

    public decimal? TareWeight { get; set; }

    public string? BreakShoeSole { get; set; }

    public decimal? BrakeWeightFreightCarEmpty { get; set; }

    public decimal? BrakeWeightFreightCarLoaded { get; set; }

    public decimal? ConversionWeightFreightWagon { get; set; }

    public string? TypeOfBrakes { get; set; }

    public string? SpecialBrakeType { get; set; }

    public decimal? HandbrakeForceFreightCar { get; set; }

    public string? VKM { get; set; }

    public decimal? KemlerNumber { get; set; }

    public string? SubstanceNumber { get; set; }

    public decimal? Payload { get; set; }

    public short? MaxSpeed { get; set; }

    public string? CarBreakState { get; set; }

    public decimal? BrakeP { get; set; }

    public decimal? BrakeG { get; set; }

    public string? Comment { get; set; }
}
