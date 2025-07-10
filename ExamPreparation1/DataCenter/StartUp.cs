using System.ComponentModel;

namespace DataCenter
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Rack rack = new Rack(8);

            Server server1 = new("SN001", "Dell PowerEdge T340", 100, 450);

            Server server2 = new("SN002", "HP Proliant DL360", 200, 220);

            Server server3 = new("SN003", "Dell PowerEdge T340", 250, 350);

            Server server4 = new("SN004", "IBM Power System S922", 220, 330);

            Server server5 = new("SN005", "Lenovo ThinkSystem SR650", 250, 550);

            Server server6 = new("SN006", "HPE Synergy 480 Gen10", 80, 180);

            Server server7 = new("SN007", "Fujitsu PRIMERGY RX2530 M5", 120, 250);

            Server server8 = new("SN008", "Dell EMC PowerEdge R740xd", 160, 380);

            Server server9 = new("SN006", "Supermicro SuperServer 1029P-WTR", 150, 280);

            Server server10 = new("SN009", "Cisco UCS B200 M5", 180, 400);



            rack.AddServer(server1);

            rack.AddServer(server2);

            rack.AddServer(server3);

            rack.AddServer(server4);

            rack.AddServer(server5);

            rack.AddServer(server6);

            rack.AddServer(server7);
            rack.AddServer(server9);
          

            rack.RemoveServer("SN001"); 
            rack.AddServer(server10);
            Console.WriteLine(rack.GetCount);

            rack.RemoveServer("SN011");

            rack.AddServer(server10);

            Console.WriteLine(rack.GetCount);

            Console.WriteLine(rack.GetHighestPowerUsage());

            Console.WriteLine(rack.GetTotalCapacity());

            Console.WriteLine(rack.DeviceManager());
        }
    }
}
