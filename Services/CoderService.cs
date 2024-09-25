using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using riwi.Models;

namespace riwi.Services
{
    public class CoderService
    {
        private readonly HttpClient _httpClient;
        public CoderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        } 

        //we realize the petition
        public async Task<List<Coder>> GetCodersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Coder>>("http://localhost:5113/riwitalent/coders");
        }

         public async Task<bool> UpdateCoderAsync(Coder coder)
        {
            var response = await _httpClient.PutAsJsonAsync("http://localhost:5113/riwitalent/updatecoder", coder);
            return response.IsSuccessStatusCode;
        }
    }
}