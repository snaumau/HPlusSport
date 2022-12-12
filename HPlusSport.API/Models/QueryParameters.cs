namespace HPlusSport.API.Models;

public class QueryParameters
{
    private const int MaxSize = 100;
    private int _size = 50;
    private string _sortOrder = "asc";

    public int Page { get; set; } = 1;

    public int Size
    {
        get => _size;
        set => _size = Math.Min(MaxSize, value);
    }

    public string SortBy { get; set; } = "Id";

    public string SortOrder
    {
        get => _sortOrder;
        set
        {
            if (value == "asc" || value == "desc")
            {
                _sortOrder = value;
            }
        }
    }
}