
using Week8;

class Program
{
    public static void Main()
    {
        FileResouce fileResouce1 = new FileResouce("fileResouce1", false);
        FileResouce fileResouce2 = new FileResouce("fileResouce2", false);
        NetworkResource networkResource1 = new NetworkResource("networkResource1", false);
        NetworkResource networkResource2 = new NetworkResource("networkResource2", false);
        ResourceManager<Resource> manager = new ResourceManager<Resource>();
        
        manager.Add(fileResouce1);
        manager.Add(fileResouce2);
        manager.Add(networkResource1);
        manager.Add(networkResource2);
        
        manager.OpenAll();
        using (fileResouce1)
        {
            fileResouce1.Open();
        }
        manager.CloseAll();

        Console.WriteLine("Done.");
    }
    
}