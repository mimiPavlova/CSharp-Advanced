using System.Text;

namespace DataCenter;

public class Rack
{
   public int Slots {  get; set; }
    public List<Server> Servers { get;set; }
    public int GetCount=>Servers.Count;

    public Rack(int slots)
    {
        Slots = slots;
        Servers = new List<Server>();

    }

    public void AddServer(Server server)
    {
        if (Servers.Count<Slots)
        {
            if (!Servers.Any(s => s.SerialNumber==server.SerialNumber))
            {
               Servers.Add(server);
            }
        }
    }
    public bool RemoveServer(string serialNumber)
    {
        Server server=Servers.FirstOrDefault(s => s.SerialNumber==serialNumber);

        if (server!=null)
        {
            Servers.Remove(server);
            return true;
        }
        return false;
    }
    public string GetHighestPowerUsage()
    {
        return Servers.OrderByDescending(s => s.PowerUsage).FirstOrDefault().ToString();
        
    }
    public int GetTotalCapacity()
    {
        return Servers.Sum(s => s.Capacity);
    }
    public string DeviceManager()
    {
      StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{this.GetCount} servers operating:");
        foreach (var item in Servers)
        {
            stringBuilder.AppendLine(item.ToString());
        }
        return stringBuilder.ToString().Trim();

    }


}
