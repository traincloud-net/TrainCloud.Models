using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrainCloud.Models;

/// <summary>
/// AbstractFilterModel Comment
/// </summary>
public abstract class AbstractFilterModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private int _pageNr = 1;
    /// <summary>
    /// The requested page in the results dataset according to the other filter settings
    /// </summary>
    /// <value></value>
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
    [DefaultValue(1)]
    public int PageNr 
    { 
        get { return _pageNr; }
        set 
        {
            _pageNr = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PageNr)));
        }
    }

    private int _pageSize = 10;
    /// <summary>
    /// Number of elements a page can contain
    /// </summary>
    /// <value></value>
    [Required]
    [Range(1, 100, ErrorMessage = "Please enter a value bigger than 0 and smaller than 101")]
    [DefaultValue(10)]
    public int PageSize
    {
        get { return _pageSize; }
        set
        {
            _pageSize = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PageSize)));
        }
    }

    private string? _searchString;
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string? SearchString
    {
        get { return _searchString; }
        set
        {
            _searchString = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchString)));
        }
    } 
}

