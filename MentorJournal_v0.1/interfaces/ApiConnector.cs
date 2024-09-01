using MentorJournal_v0._1.common;
using MentorJournal_v0._1.model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows;

namespace MentorJournal_v0._1.interfaces
{
    class ApiConnector
    {
        private readonly HttpClient _httpClient;
        public CommonThings commonThings = new CommonThings();

        public ApiConnector(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Mentor> GetMentorByLoginAndPasswordAsync(string login, string password)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{commonThings.apiUrl}/get_mentor/{login}/{password}");
                response.EnsureSuccessStatusCode();

                var mentor = await response.Content.ReadFromJsonAsync<Mentor>();
                return mentor;
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                return null;
            }
        }

        public async Task<Admin> GetAdminByLoginAndPasswordAsync(string login, string password)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{commonThings.apiUrl}/get_admin/{login}/{password}");
                response.EnsureSuccessStatusCode();

                var admin = await response.Content.ReadFromJsonAsync<Admin>();
                return admin;
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                return null;
            }
        }

    }
}
