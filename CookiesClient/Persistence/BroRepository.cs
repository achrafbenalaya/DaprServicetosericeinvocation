using CookiesClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CookiesClient.Persistence
{
    public class BroRepository : IBroRepository
    {
        private readonly HttpClient _httpClient;

        public BroRepository(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Cookies>> Getcookies()
        {
            return await _httpClient.
                  GetFromJsonAsync<IEnumerable<Cookies>>("/api/cookies");
        }
    }
}
