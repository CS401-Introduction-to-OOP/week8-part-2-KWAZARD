namespace Week8;

public abstract class Resource
{
    public string Name { get; set; }
    public bool IsOpen { get; set; }

    public abstract void Open();
    public abstract void Close();
}