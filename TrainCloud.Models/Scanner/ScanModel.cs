using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Scanner;
public class ScanModel
{
    public Guid Id { get; set; } 
    public Guid? UserId { get; set; }
    public DateTimeOffset ScanDate { get; set; }
    public string? Annotations { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string? FullUIC { get; set; }
    public string? ProcessingLog { get; set; }
    public string? Comment { get; set; }
}
