using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
public class BikeRentalStationList
{
    public Stations[] Stations { get; set; }
    public BikeRentalStationList(Stations[] station)
    {
        Stations = station;
    }
}