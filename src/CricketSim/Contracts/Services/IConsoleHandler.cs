using System;

public interface IConsoleHandler
{
    ConsoleKeyInfo Read();

    void Write(string text);
}