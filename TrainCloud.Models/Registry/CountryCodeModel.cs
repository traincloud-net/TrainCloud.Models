using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Registry;
public class CountryCodeModel
{
    public string Code { get; set; }

    public string AlphabeticalCode { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }
}
