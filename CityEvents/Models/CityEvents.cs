using System;
using DynamicData.Binding;

namespace CityEvents.Models;

public class CityEvent : AbstractNotifyPropertyChanged
{
    private string _header;
    private string _description;
    private string _image;
    private string _date;
    private EventCategory _category;
    private decimal _price;

    private static string CheckStringLenght(string? str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }
        else if (str.Length > 135)
        {
            return str.Substring(0, 132) + "...";
        }
        else
        {
            return str;
        }
    }

    public CityEvent()
    {
        _header = string.Empty;
        _description = string.Empty;
        _image = string.Empty;
        _date = string.Empty;
        _category = null!;
        _price = Decimal.Zero;
    }
    
    public string Header
    {
        get => _header;
        set => SetAndRaise(ref _header, value);
    }

    public string Description
    {
        get => _description;
        set {
            SetAndRaise(ref _description, CheckStringLenght(value));
        }
    }

    public string Image
    {
        get => _image;
        set => SetAndRaise(ref _image, value);
    }

    public string Date
    {
        get => _date;
        set => SetAndRaise(ref _date, value);
    }

    public EventCategory Category
    {
        get => _category;
        set => SetAndRaise(ref _category, value);
    }

    public decimal Price
    {
        get => _price;
        set => SetAndRaise(ref _price, value);
    }
}
