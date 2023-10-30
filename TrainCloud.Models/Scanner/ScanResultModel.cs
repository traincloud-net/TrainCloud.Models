using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Scanner;
public class ScanResultModel
{
    public string? FullUIC { get; set; }

    public Guid ScanId { get; set; }

    public bool Success { get; set; }
}
