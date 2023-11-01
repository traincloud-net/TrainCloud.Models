using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Lists.CarLists;
public class PostCarListModel
{
    [Required]
    public string TrainNumber { get; set; } = string.Empty; // "0005421"

    [Required]
    public string StartTrainStation { get; set; } = string.Empty;

    [Required]
    public string DestinationTrainStation { get; set; } = string.Empty;

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public string TrainBreakState { get; set; } = string.Empty;

    [Required]
    public short MaxTrainSpeed { get; set; }

    [Required]
    public byte TrainBreakHundredth { get; set; }

    [Required]
    public bool IsTrashTrain { get; set; }

    [Required]
    public string MinimumTrackClass { get; set; } = string.Empty;

    public string? TrainComment { get; set; }

    public string? TravelingComment { get; set; }

    public string? CheckComment { get; set; }

    [Required]
    public DateTimeOffset? CheckDate { get; set; }

    public Guid? CheckUserId { get; set; }

    public List<CarListItemModel> Cars { get; set; } = new();
}
