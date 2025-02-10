using System.Collections.ObjectModel;

namespace DeepSeeker.AvaloniaUI.ViewModels;

public class MainWindowViewModel : ViewModelBase {
    private ObservableCollection<string> _items;

    public ObservableCollection<string> Items
    {
        get { return _items; }
        set { SetProperty(ref _items, value); }
    }

    public MainWindowViewModel() {
        Items = ["Item 1", "Item 2", "Item 3"];
    }
}