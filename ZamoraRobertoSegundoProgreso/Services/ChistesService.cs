using ZamoraRobertoSegundoProgreso.Models;
using System.Net.Http.Json;

namespace ZamoraRobertoSegundoProgreso.Services
{
    public interface IChistesService
    {
        Task<Chiste> ObtenerChisteAleatorioAsync();
    }

    public class ChistesService : IChistesService
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "https://official-joke-api.appspot.com/random_joke";

        public ChistesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Chiste> ObtenerChisteAleatorioAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Chiste>(ApiUrl);
            }
            catch
            {
                return new Chiste
                {
                    setup = "No se pudo cargar el chiste",
                    punchline = "Intenta de nuevo más tarde"
                };
            }
        }
    }
}