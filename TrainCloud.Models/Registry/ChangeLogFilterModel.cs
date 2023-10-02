using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Registry;

public class ChangeLogFilterModel : AbstractFilterModel, IFilterModel
{
    public new string OrderBy { get; set; } = "FullUIC";

    public new  SortOrder Order { get; set; } = SortOrder.Descending;

}

