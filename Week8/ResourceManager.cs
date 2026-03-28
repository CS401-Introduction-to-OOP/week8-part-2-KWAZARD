namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private List<T> manager = new List<T>();
    public void Add(T resource)
    {
        manager.Add(resource);
        Console.WriteLine("Resource is added to list");
    }

    public void OpenAll()
    {
        foreach (var obj in manager)
        {
            obj.Open();
            
        }

        Console.WriteLine("All resources is opened");
    }
    public void CloseAll()
    {
        foreach (var obj in manager)
        {
            obj.Close();
            
        }

        Console.WriteLine("All resources is closed");
    }
}