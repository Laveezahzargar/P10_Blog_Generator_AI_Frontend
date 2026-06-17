using P10_Blog_Generator_AI_Frontend.DTOs;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace P10_Blog_Generator_AI_Frontend.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5238/");
        }
        private void AddAuthorizationHeader()
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    UserSession.Token);
        }
        public async Task<HttpResponseMessage> RegisterAsync(RegisterRequestDto request)
        {
            return await _httpClient.PostAsJsonAsync(
                "api/Auth/register",
                request);
        }
        public async Task<HttpResponseMessage> LoginAsync(LoginRequestDto request)
        {
            return await _httpClient.PostAsJsonAsync(
                "api/Auth/login",
                request);
        }
        public async Task<List<BlogListDto>> GetBlogsAsync()
        {
            AddAuthorizationHeader(); 
            return await _httpClient.GetFromJsonAsync<List<BlogListDto>>("api/blog/myblogs");
        }
        public async Task<HttpResponseMessage> GenerateBlogAsync(
    GenerateBlogRequestDto request)
        {
            AddAuthorizationHeader();

            return await _httpClient.PostAsJsonAsync(
                "api/blog/generate",
                request);
        }
        public async Task<HttpResponseMessage> DeleteBlogAsync(int blogId)
        {
            AddAuthorizationHeader();

            return await _httpClient.DeleteAsync(
                $"api/blog/{blogId}");
        }
        public async Task<HttpResponseMessage> RegenerateBlogAsync(int blogId)
        {
            AddAuthorizationHeader();

            return await _httpClient.PostAsync(
                $"api/Blog/regenerate/{blogId}",
                null);
        }
        public async Task<BlogDto?> GetBlogByIdAsync(int blogId)
        {
            AddAuthorizationHeader();
            return await _httpClient.GetFromJsonAsync<BlogDto>($"api/blog/{blogId}");
        }
    }
}