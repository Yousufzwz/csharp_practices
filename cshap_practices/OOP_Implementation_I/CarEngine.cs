

public class CarEngine:EngineFactory
{
    public string MachineID { get; set; }
    public string MachineName { get; set; }

    public CarEngine(string machineID, string machineName)
    {
        MachineID = machineID;
        MachineName = machineName;
    }
}