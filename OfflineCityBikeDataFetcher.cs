using System.Threading.Tasks;
using System;
using System.IO;
using System.Text;

public interface OfflineICityBikeDataFetcher
{
    Task<int> GetBikeCountInStation(string stationName);
}

public class OfflineCityBikeDataFetcher : ICityBikeDataFetcher
{
    public async Task<int> GetBikeCountInStation(string stationName)
    {
        try
        {
            string text = System.IO.File.ReadAllText(@"E:\Koulu\Periodi v3p1\Taustajarjestelmat\Assignment1\bikedata.txt");
            System.Console.WriteLine("Contents of bikedata.txt = {0}", text);
            //     for (int i = 0; i < bikeList.Stations.Length; i++)
            //     {
            //         if (bikeList.Stations[i].Name == stationName)
            //         {
            //             bikeCount = bikeList.Stations[i].BikesAvailable;
            //             Console.WriteLine("There are " + bikeCount + " bikes at the station");
            //             return 0;
            //         }
            //     }
            //     foreach (char c in stationName)
            //     {
            //         if (char.IsDigit(c))
            //         {
            //             System.ArgumentException argEx = new System.ArgumentException("Contains numbers");
            //             throw argEx;
            //         }
            //     }
            NotFoundException notFound = new NotFoundException("Station not found.");
            throw notFound;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid argument: " + ex.Message);
        }
        return 0;
    }
}
