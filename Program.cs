using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string originalUrl;
        do
        {
            Console.Write("Geben Sie die zu verkürzende URL ein: ");
            originalUrl = Console.ReadLine();
        } 
        while (!IsValidUrl(originalUrl));

        Console.Write("Geben Sie den gewünschten Alias (optional) ein oder lassen Sie es leer: ");
        string customAlias = Console.ReadLine();

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://fast-url-shortener1.p.rapidapi.com/shorten"),
            Headers =
            {
                { "X-RapidAPI-Key", "c943082d17mshbd35d2979817e91p1e50abjsn15a3cfac2b6e" },
                { "X-RapidAPI-Host", "fast-url-shortener1.p.rapidapi.com" },
            },
            Content = new StringContent($"{{\"url\": \"{originalUrl}\", \"custom_alias\": \"{customAlias}\"}}")
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
            }
        };

        try
        {
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var shortenedUrl = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Verkürzte URL: " + shortenedUrl);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler bei der Anfrage: {ex.Message}");
        }
    }
    
    static bool IsValidUrl(string url)
    {

        string pattern = @"^(https?://)?([\w\d-]+\.)*[\w\d-]+(/[^\s]*)?$";
        return Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);
    }
}

