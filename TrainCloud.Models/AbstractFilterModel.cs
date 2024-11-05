using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models;

/// <summary>
/// AbstractFilterModel Comment
/// </summary>
public abstract class AbstractFilterModel 
{
    /// <summary>
    /// The requested page in the results dataset according to the other filter settings
    /// </summary>
    /// <value></value>
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
    [DefaultValue(1)]
    public int PageNr { get; set; } = 1;

    /// <summary>
    /// Number of elements a page can contain
    /// </summary>
    /// <value></value>
    [Required]
    [Range(1, 100, ErrorMessage = "Please enter a value bigger than 0 and smaller than 101")]
    [DefaultValue(10)]
    public int PageSize { get; set; } = 10;

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string? SearchString { get; set; } 
}

