using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Analytics;
public class PostClickModel
{
    [Required()]
    public Guid AnalyticsTabId { get; set; }

    public Guid? CookieId { get; set; }

    [Required()]
    public string Uri { get; set; }
}
