using ElevatorMobileApplication.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace ElevatorMobileApplication.Services
{
    public class CaseService : ICaseService
    {
        public static string BaseAddress =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:7169" : "http://localhost:7169";
        public static string Url = $"{BaseAddress}/api/case/";

        public async Task<List<Case>> GetCasesAsync()
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var Cases = JsonConvert.DeserializeObject<List<Case>>(content);
                return Cases;
            }
            else
            {
                return null;
            }

        }

        public async Task<Case> GetCaseByIdAsync(int id)
        {              
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Url + id);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var CurrentCase = JsonConvert.DeserializeObject<Case>(content);
                return CurrentCase;
            }
            else
            {
                return null;
            }
        }
    }
}
