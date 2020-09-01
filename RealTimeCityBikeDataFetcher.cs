using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

class RealTimeCityBikeDataFetcher : ICityBikeDataFetcher
{
    int bikeCount;
    public async Task<int> GetBikeCountInStation(string stationName)
    {
        HttpClient client = new HttpClient();

        try
        {
            string json = await client.GetStringAsync("http://api.digitransit.fi/routing/v1/routers/hsl/bike_rental");
            BikeRentalStationList bikeList = JsonConvert.DeserializeObject<BikeRentalStationList>(json);
            for (int i = 0; i < bikeList.Stations.Length; i++)
            {
                if (bikeList.Stations[i].Name == stationName)
                {
                    bikeCount = bikeList.Stations[i].BikesAvailable;
                    Console.WriteLine("There are " + bikeCount + " bikes at the station");
                    return 0;
                }
            }
            foreach (char c in stationName)
            {
                if (char.IsDigit(c))
                {
                    System.ArgumentException argEx = new System.ArgumentException("Contains numbers");
                    throw argEx;
                }
            }
            NotFoundException notFound = new NotFoundException("Station not found.");
            throw notFound;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid argument: "+ ex.Message);
        }
        catch (NotFoundException ex) {
            Console.WriteLine("Not Found: "+ ex.Message);
        }
        return 0;
    }
}