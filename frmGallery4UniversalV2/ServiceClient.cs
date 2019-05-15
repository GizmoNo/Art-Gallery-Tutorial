using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace frmGallery4UniversalV2
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetArtistNamesAsync()
        { using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/gallery/GetArtistNames/"));
        }

        internal async static Task<clsArtist> GetArtistAsync(string prArtistName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsArtist>
                    (await lcHttpClient.GetStringAsync
                    ("http://localhost:60064/api/gallery/GetArtist?Name=" + prArtistName));
        }

        internal async static Task<string> UpdateWorkAsync(clsAllWork prWork)
        {
            return await InsertOrUpdateAsync(prWork, "http://localhost:60064/api/gallery/PutArtWork", "PUT");
        }

        internal async static Task<string> InsertWorkAsync(clsAllWork prWork)
        {
            return await InsertOrUpdateAsync(prWork, "http://localhost:60064/api/gallery/PostArtWork", "POST");
        }

        internal async static Task<string> UpdateArtistAsync(clsArtist prArtist)
        {
            return await InsertOrUpdateAsync(prArtist, "http://localhost:60064/api/gallery/PutArtist", "PUT");
        }

        internal async static Task<string> InsertArtistAsync(clsArtist prArtist)
        {
            return await InsertOrUpdateAsync(prArtist, "http://localhost:60064/api/gallery/PostArtist", "POST");
        }

        internal async static Task<string> DeleteArtWorkAsync(clsAllWork prWork)
        {
            return await InsertOrUpdateAsync(prWork, "http://localhost:60064/api/gallery/DeleteArtWork", "DELETE");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
                new StringContent(JsonConvert.SerializeObject(prItem), Encoding.UTF8, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> DeleteArtistAsync(string prArtistName)
        {


            return await InsertOrUpdateAsync(prArtistName, "http://localhost:60064/api/gallery/DeleteArtist", "DELETE");








            //using(HttpClient lcHttpClient = new HttpClient())
            //{
            //    HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync(
            //        $"http://localhost:60064/api/gallery/DeleteArtist?Name={prArtistName}");
            //    return await lcRespMessage.Content.ReadAsStringAsync();
            //}

        }
    }
}
