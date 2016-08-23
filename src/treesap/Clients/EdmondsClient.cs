using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using treesap.Extensions;

namespace treesap.Clients
{
    public class EdmondsClient
    {
        public async Task<EdmondsResponse> FindModels()
        {
            try
            {
                var urlString = "https://api.edmunds.com/api/vehicle/v2/ford"
                    .AddQueryParameter("state", "new")
                    .AddQueryParameter("year", "2016")
                    .AddQueryParameter("view", "basic")
                    .AddQueryParameter("fmt", "json")
                    .AddQueryParameter("api_key", "xmnt7665u2e4pajdj7f7wnne");

                var request = new Uri(urlString);

                var requester = WebRequest.Create(request);
                var response = await requester.GetResponseAsync();
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                var data = JsonConvert.DeserializeObject<EdmondsResponse>(responseFromServer);

                return data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<EdmondsResponse> FindModels(int year, string make)
        {
            try
            {
                var urlString = string.Format("https://api.edmunds.com/api/vehicle/v2/ {0}", make)
                    .AddQueryParameter("state", "new")
                    .AddQueryParameter("year", year.ToString())
                    .AddQueryParameter("view", "basic")
                    .AddQueryParameter("fmt", "json")
                    .AddQueryParameter("api_key", "xmnt7665u2e4pajdj7f7wnne");

                var request = new Uri(urlString);

                var requester = WebRequest.Create(request);
                var response = await requester.GetResponseAsync();
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                var data = JsonConvert.DeserializeObject<EdmondsResponse>(responseFromServer);

                return data;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
