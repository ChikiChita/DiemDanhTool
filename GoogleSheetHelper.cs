using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DiemDanhTool
{
    public class GoogleSheetHelper
    {
        private readonly string apiUrl;
        private readonly HttpClient client = new HttpClient();

        public GoogleSheetHelper(string apiUrl)
        {
            this.apiUrl = apiUrl;
        }

        public async Task<string[]> GetEmployeesAsync()
        {
            try
            {
                var response = await client.GetAsync($"{apiUrl}?action=getEmployees");
                response.EnsureSuccessStatusCode();
                var txt = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<string[]>(txt) ?? Array.Empty<string>();
            }
            catch
            {
                return Array.Empty<string>();
            }
        }

        public async Task<bool> PostCellAsync(int row, int col, string value)
        {
            var payload = new { row, col, value };
            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(apiUrl, content);
            return response.IsSuccessStatusCode;
        }
    }
}
