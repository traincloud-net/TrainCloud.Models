
namespace TrainCloud.Models;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TPageItem"></typeparam>
public class PageModel<TPageItem>
{ 
    public int CurrentPage { get; set; }

    public int LastPage { get; set; }

    public int PageSize { get; set; }

    public int TotalCount { get; set; }

    public List<TPageItem> Items { get; set; } = new List<TPageItem>();
}

