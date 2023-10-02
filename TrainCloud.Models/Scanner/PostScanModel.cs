using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Scanner;
public class PostScanModel
{
    [Required]
    public byte[] ImageBytes { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }
}
