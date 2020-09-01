public class Stations
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public int BikesAvailable { get; set; }
    public int SpacesAvailable { get; set; }
    public bool AllowDropoff { get; set; }
    public bool IsFloatingBike { get; set; }
    public bool IsCarStation { get; set; }
    public string State { get; set; }
    public string[] Networks { get; set; }
    public string RealTimeData { get; set; }
}