using System.Collections.ObjectModel;
using DeepSeeker.AvaloniaUI.Models;

namespace DeepSeeker.AvaloniaUI.ViewModels;

public class MainWindowViewModel : ViewModelBase {
    private ObservableCollection<ChatText> _items;

    public ObservableCollection<ChatText> Items
    {
        get { return _items; }
        set { SetProperty(ref _items, value); }
    }

    public MainWindowViewModel() {
        Items = [];
    }
}