namespace DeepSeeker.AvaloniaUI.Models;

public record ChatText(ChatOrigin Origin, ChatType Type, string Text) {
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