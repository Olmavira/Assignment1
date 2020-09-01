using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Assignment1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args[0] == "realtime")
            {
                RealTimeCityBikeDataFetcher querier = new RealTimeCityBikeDataFetcher();
                Task<int> bikeamount = querier.GetBikeCountInStation(args[1]);
                int result = await bikeamount;
                Console.WriteLine(result);
            }
            else if (args[0] == "offline")
            {
                OfflineCityBikeDataFetcher offQuerier = new OfflineCityBikeDataFetcher();
                Task<int> bikeamount = offQuerier.GetBikeCountInStation(args[1]);
                int result = await bikeamount;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
