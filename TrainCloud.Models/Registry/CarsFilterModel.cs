using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Registry;

public class CarsFilterModel : AbstractFilterModel, IFilterModel
{
    public new string OrderBy { get; set; } = "FullUIC";
}

