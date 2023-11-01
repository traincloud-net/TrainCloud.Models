using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Lists.CarLists;
public class CarListModel
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public DateTimeOffset EditDate { get; set; }

    public string TrainNumber { get; set; } = string.Empty; // "0005421"

    public string StartTrainStation { get; set; } = string.Empty;

    public string DestinationTrainStation { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public string TrainBreakState { get; set; } = string.Empty;

    public short MaxTrainSpeed { get; set; }

    public byte TrainBreakHundredth { get; set; }

    public bool IsTrashTrain { get; set; }

    public string MinimumTrackClass { get; set; } = string.Empty;

    public string? TrainComment { get; set; }

    public string? TravelingComment { get; set; }

    public string? CheckComment { get; set; }

    public DateTimeOffset? CheckDate { get; set; }

    public Guid? CheckUserId { get; set; }

    public List<CarListItemModel> Cars { get; set; } = new();
}
