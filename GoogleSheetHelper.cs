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
            this.apiUrl = apiUrl.TrimEnd('/');
        }

        public async Task<string[]> GetEmployeesAsync()
        {
            var url = $""{apiUrl}?action=getEmployees"";
            using var res = await client.GetAsync(url);
            res.EnsureSuccessStatusCode();
            var s = await res.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<string[]>(s) ?? Array.Empty<string>();
        }

        public async Task<bool> PostCellAsync(int row, int col, string value)
        {
            var payload = new { row = row, col = col, value = value };
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, ""application/json"");
            using var res = await client.PostAsync(apiUrl, content);
            return res.IsSuccessStatusCode;
        }
    }
}
