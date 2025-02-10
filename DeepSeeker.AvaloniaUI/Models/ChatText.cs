using System;
using Avalonia.Media;
using Avalonia.Media.Immutable;

namespace DeepSeeker.AvaloniaUI.Models;

public record ChatText(ChatOrigin Origin, ChatType Type, string Text) {
    public IBrush Color {
        get => Origin switch {
            ChatOrigin.Bot => Brushes.LightCyan,
            ChatOrigin.User => Brushes.Wheat,
            ChatOrigin.System => 
                Type switch {
                    ChatType.Message => Brushes.Chartreuse,
                    ChatType.Error => Brushes.Red,
                    ChatType.Warning => Brushes.Orange,
                    _ => throw new ArgumentOutOfRangeException()
                },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public enum ChatOrigin {
    Bot,
    User,
    System
}

public enum ChatType {
    Message,
    Error,
    Warning
}