using System.Xml;

namespace Week8;

public class FileResouce : Resource, IDisposable
{
    public FileResouce(string name, bool isOpen) : base(name, isOpen)
    {
    }

    public void Dispose()
    {
        Close();
    }

    public override void Open()
    {
        Console.WriteLine("Open, FileResource");
    }

    public override void Close()
    {
        Console.WriteLine("Close, FileResource");
    }
}