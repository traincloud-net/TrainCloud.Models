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
    public ApplicationType Application { get; set; } 

    [Required()]
    public Guid AnalyticsTabId { get; set; }

    public Guid? CookieId { get; set; }

    public string? Referrer { get; set; }

    [Required()]
    public required string Uri { get; set; }

    public string? AcceptLanguage { get; set; }

    public string? UserAgent { get; set; }
}
