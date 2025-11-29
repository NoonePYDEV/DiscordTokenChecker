using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordTokenChecker
{
    internal class Checker
    {
        public static async Task<string> GetDiscordTokenInfos(string token)
        {
            JObject obj;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", token);

                try
                {
                    string response = await client.GetStringAsync("https://discord.com/api/v6/users/@me");

                    obj = JObject.Parse(response);
                    obj.Add(new JProperty("token", token));
                    obj.Add(new JProperty("status", "ok"));
                    return obj.ToString();
                }
                catch (Exception)
                {
                    obj = JObject.Parse("{\"status\": \"notok\"}");
                    return obj.ToString();
                }
            }
        }

        public static async Task<Bitmap?> GetUserAvatar(string AvatarID, string UserID)
        {
            string Url;

            if (!string.IsNullOrEmpty(AvatarID))
                Url = $"https://cdn.discordapp.com/avatars/{UserID}/{AvatarID}.png";
            else
                Url = $"https://cdn.discordapp.com/embed/avatars/{UserID}/{long.Parse(UserID) % 5}.png";

            using (HttpClient client = new HttpClient()) {
                try
                {
                    byte[] res = await client.GetByteArrayAsync(Url);

                    using (MemoryStream ms = new MemoryStream(res))
                    {
                        return new Bitmap(ms);
                    }
                }
                catch
                {
                    return null;
                } 
            }
        }
    }
}
