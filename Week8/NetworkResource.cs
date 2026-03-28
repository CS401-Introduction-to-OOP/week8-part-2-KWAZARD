namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name, bool isOpen) : base(name, isOpen)
    {
    }

    public void Dispose()
    {
        Close();
    }

    public override void Open()
    {
        Console.WriteLine("Open, NetworkResource");
    }

    public override void Close()
    {
        Console.WriteLine("Close, NetworkResource");
    }
}