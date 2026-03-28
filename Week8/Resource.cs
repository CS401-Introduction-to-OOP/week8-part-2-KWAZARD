namespace Week8;

public abstract class Resource
{
    public string Name { get; set; }
    public bool IsOpen { get; set; }

    public Resource(string name, bool isOpen)
    {
        Name = name;
        IsOpen = isOpen;
    }
    
    public abstract void Open();
    public abstract void Close();
}