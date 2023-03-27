using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerDAL.Errors
{
    public static class ApiErrorHandler
    { 
        public static async Task HandleErrorAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorJson = await response.Content.ReadAsStringAsync();
                var error = JsonConvert.DeserializeObject<ErrorResponse>(errorJson);
                throw new Exception($"API request failed. Status code: {response.StatusCode}. Error message: {error?.Message}");
            }
        }

        public class ErrorResponse
        {
            public string? Message { get; set; }
        }
    }
}
