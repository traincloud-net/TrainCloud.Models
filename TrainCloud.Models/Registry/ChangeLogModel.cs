using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Registry;
public class ChangeLogModel
{
    public DateTimeOffset RevisionDate { get; set; }

    public string UserName { get; set; } =string.Empty;

    public string? RevisionComment { get; set; }
}
