using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
public class OfflineBikeRentalStationList
{
    public string StationName { get; set; }
    public OfflineBikeRentalStationList(string station)
    {
        StationName = station;
    }
}