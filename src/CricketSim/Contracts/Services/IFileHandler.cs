using System.IO;

public interface IFileHandler
{
    StreamReader Open(string path);
}