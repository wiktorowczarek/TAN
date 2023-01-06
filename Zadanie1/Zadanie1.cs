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

            string Telefony = @"\+48\s[0-9]{2}\s[0-9]{2}\s[0-9]{2}\s[0-9]{3}|" +
                                   @"\+48\s[0-9]{3}\s[0-9]{3}\s[0-9]{3}|\+48\s[0-9]{9}|" +
                                    @"[0-9]{2}\s[0-9]{3}\s[0-9]{2}\s[0-9]{2}|" +
                                    @"[0-9]{2}\s[0-9]{2}\s[0-9]{3}\s[0-9]{2}"; 
            
            // Adresy email / Numery telefonow
            MatchCollection result = Regex.Matches(content, Telefony);
            foreach (Match match in result)
            {
                Console.WriteLine(match);
            }
        }

    }


}
