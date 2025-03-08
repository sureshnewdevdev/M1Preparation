using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching data...");
        string result = await FetchDataAsync("https://api.example.com/data");
        Console.WriteLine(result);
    }

    static async Task<string> FetchDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // The await keyword allows the method to be non-blocking
            string response = await client.GetStringAsync(url);
            return response;
        }
    }
}