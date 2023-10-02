using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models.Scanner;

public class ScansFilterModel : AbstractFilterModel, IFilterModel
{
    [Required]
    public bool OnlyFailed { get; set; } = true;
}

