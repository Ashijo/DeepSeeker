using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using DeepSeeker.AvaloniaUI.Models;
using DeepSeeker.AvaloniaUI.ViewModels;

namespace DeepSeeker.AvaloniaUI.Views;

public partial class MainWindow : Window {
    private readonly TextBox _entry;
    private MainWindowViewModel? _castedDataContext;

    public MainWindow() {
        InitializeComponent();
        _entry = this.FindControl<TextBox>("Entry") ?? throw new NullReferenceException();

        KeyDown += (sender, args) => {
            if (args.Key == Key.Enter) {
                if (args.KeyModifiers == KeyModifiers.Shift) {
                    _entry.Text += Environment.NewLine;
                    _entry.CaretIndex = _entry.Text.Length;
                    return;
                }
                
                PostEntry();
            }
        };
    }

    private void HandleBorderColor() {
        
    }

    private void PostEntry() {
        var entryVal = _entry.Text ?? "";
        if (string.IsNullOrWhiteSpace(entryVal)) return;

        _castedDataContext ??= (MainWindowViewModel)DataContext!;
        if (_castedDataContext is null) throw new NullReferenceException("DataContext is null");

        var newText = new ChatText(ChatOrigin.User, ChatType.Message, entryVal);
        _castedDataContext.Items.Add(newText);

        _entry!.Text = "";
    }
}