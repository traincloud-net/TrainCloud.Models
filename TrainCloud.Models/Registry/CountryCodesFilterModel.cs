using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Registry;

public class CountryCodesFilterModel : AbstractFilterModel, IFilterModel
{
    public new string OrderBy { get; set; } = "Code";
}

