using githubWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubWPF.DL
{
    public class Repositories 
    {
        public static List<Repository> get(String username)
        {
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(System.Net.HttpRequestHeader.UserAgent, "request");
                var json = webClient.DownloadString($"https://api.github.com/users/{username}/repos");
                List<Repository> repositories = JsonConvert.DeserializeObject<List<Repository>>(json);
                return repositories;
            }
        }
        public static async Task<List<Repository>> getAsync(String username)
        {
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(System.Net.HttpRequestHeader.UserAgent, "request");
                var json = await webClient.DownloadStringTaskAsync($"https://api.github.com/users/{username}/repos");
                
                List<Repository> repositories = JsonConvert.DeserializeObject<List<Repository>>(json);
                return repositories;
            }
        }
    }
}
