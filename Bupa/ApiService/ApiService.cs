using Bupa.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Bupa.ApiService
{
    public class ApiService
    {
        private static readonly string _url = "https://beta.check-mot.service.gov.uk/trade/vehicles/mot-tests?registration=XX10ABC";

        static async Task<string> getMOT()
        {
            string result="";
            using (var httpClient = new HttpClient())
            {
                // Set default request headers
                httpClient.DefaultRequestHeaders.Add("x-api-key", "fZi8YcjrZN1cGkQeZP7Uaa4rTxua8HovaswPuIno");

                // Make a request
                HttpResponseMessage response = await httpClient.GetAsync(_url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    result = content;
                }
            }
            return result;
        }

    }
}
