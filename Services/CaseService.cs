using ElevatorMobileApplication.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace ElevatorMobileApplication.Services
{
    public class CaseService : ICaseService
    {
        public static string BaseAddress =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static string Url = $"{BaseAddress}/api/case/";

        public async Task<List<Case>> GetCasesAsync()
        {
            var Cases = new List<Case>();
            var client = new HttpClient();

            //client.BaseAddress = new Uri(TodoItemsUrl);

            HttpResponseMessage response = await client.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Cases = JsonConvert.DeserializeObject<List<Case>>(content);
                return Cases;
            }
            else
            {
                return null;
            }

        }
        
    }
}
