using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using webimdb.Models;

namespace webimdb.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public MovieService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["OMDBApiKey"];
        }

        public async Task<Movie?> GetMovieAsync(string title, string type)
        {
            var url = $"http://www.omdbapi.com/?t={title}&type={type}&apikey={_apiKey}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                var movie = JsonConvert.DeserializeObject<Movie>(responseJson);

                if (movie?.Response == "True")
                {
                    return movie;
                }else
                {
                    return null;
                }
            }else
            {
                return null;
            }
        }
    }
}