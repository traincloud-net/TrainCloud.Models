namespace TrainCloud.Models;

/// <summary>
/// 
/// </summary>
public interface IFilterModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int PageNr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int PageSize { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string? SearchString { get; set; }
}

