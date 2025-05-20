
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TrainCloud.Models;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TPageItem"></typeparam>
public class PageModel<TPageItem> : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private int _currentPage;
    public int CurrentPage
    {
        get { return _currentPage; }
        set
        {
            _currentPage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentPage)));
        }
    }

    private int _lastPage;
    public int LastPage
    {
        get { return _lastPage; }
        set
        {
            _lastPage = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastPage)));
        }
    }

    private int _pageSize;
    public int PageSize
    {
        get { return _pageSize; }
        set
        {
            _pageSize = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PageSize)));
        }
    }

    private int _totalCount;
    public int TotalCount
    {
        get { return _totalCount; }
        set
        {
            _totalCount = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalCount)));
        }
    }

    private ObservableCollection<TPageItem> _items = new();
    public ObservableCollection<TPageItem> Items
    {
        get { return _items; }
        set
        {
            _items = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
        }
    }
}

