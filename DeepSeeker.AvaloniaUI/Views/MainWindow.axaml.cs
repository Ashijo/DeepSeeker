using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DeepSeeker.AvaloniaUI.ViewModels;

namespace DeepSeeker.AvaloniaUI.Views;

public partial class MainWindow : Window {
    private readonly TextBox _entry;
    private MainWindowViewModel? _castedDataContext;
    
    public MainWindow() {
        InitializeComponent();
        _entry = this.FindControl<TextBox>("Entry") ?? throw new NullReferenceException();
        
    }

    private void HandleSubmit(object sender, RoutedEventArgs e) {
       PostEntry();
    }

    private void PostEntry() {
        var entryVal = _entry.Text ?? "";
        if (string.IsNullOrWhiteSpace(entryVal)) return;
        
        _castedDataContext ??= (MainWindowViewModel)DataContext!;
        if (_castedDataContext is null) throw new NullReferenceException("DataContext is null");

        _castedDataContext.Items.Add(entryVal);

        _entry!.Text = "";
    }
}