using Newtonsoft.Json;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Services
{
    public class UserService
    {
        ApplicationDbContext context;
        HttpClient httpClient;

        public UserService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public UserService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        //CREATE
        public async Task<UserInfo> AddUserInfo(UserInfo _info)
        {
            string jsonStr = JsonConvert.SerializeObject(_info);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");

            var result = await httpClient.PostAsync("api/users", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("Add User Failed");

            var resultContent = await result.Content.ReadAsStringAsync();

            UserInfo resultInfo = JsonConvert.DeserializeObject<UserInfo>(resultContent);

            return resultInfo;
        }
        //UPDATE//

        public async Task<bool> UpdateInfo(UserInfo _info)
        {
            string jsonStr = JsonConvert.SerializeObject(_info);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");

            var result = await httpClient.PutAsync("api/users", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("Update User Failed");

            return true;
        }
        //READ
        public async Task<List<UserInfo>> GetUserInfoAsync()
        {
            var result = await httpClient.GetAsync("api/users");

            if (result.IsSuccessStatusCode == false)
            {
                throw new Exception("Get All USer Failed");
            }
            var resultContent = await result.Content.ReadAsStringAsync();

            List<UserInfo> results = JsonConvert.DeserializeObject<List<UserInfo>>(resultContent);

            return results;
        }

        //DELETE
        public async Task<bool> DeleteInfo(UserInfo _info)
        {

            var result = await httpClient.DeleteAsync($"api/users/{_info.userID}");
            if (result.IsSuccessStatusCode == false)
            {
                throw new Exception("Delete USer Failed");
            }


            return true;
        }
    }
}
