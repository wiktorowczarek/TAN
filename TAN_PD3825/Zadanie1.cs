using System.Text.RegularExpressions;

namespace Zadanie1
{

    class Program
    {
        static async Task Main(string[] args)
        {
            string websiteUrl = "https://www.pja.edu.pl/";

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(websiteUrl);

            string content = await response.Content.ReadAsStringAsync();

            // Adresy email / Numery telefonow
            MatchCollection result = Regex.Matches(content, "[a-zA-Z]+[@][a-zA-Z.]+");
            foreach (Match match in result)
            {
                Console.WriteLine(match);
            }
        }

    }


}
