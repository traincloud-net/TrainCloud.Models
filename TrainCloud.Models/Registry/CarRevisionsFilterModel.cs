using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Registry;

public class CarRevisionsFilterModel : AbstractFilterModel, IFilterModel
{
    public override string OrderBy { get; set; } = "RevisionDate";

    public override SortOrder Order { get; set; } = SortOrder.Descending;
}

