﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Zoopla.Net.Models;

namespace Zoopla.Net
{
    public class ZooplaHttpClient
    {
        // Only have one instance which get's re-used (https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
        private static readonly HttpClient _client = new HttpClient();

        public async Task<T> GetObject<T>(string url) where T : ResponseModelBase
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync();

                var deserializedResponse = JsonConvert.DeserializeObject<T>(responseJson);
                deserializedResponse.RawResponse = responseJson;
                return deserializedResponse;
            }
            else
            {
                T errorResponse = (T)Activator.CreateInstance(typeof(T));
                errorResponse.ErrorString = await response.Content.ReadAsStringAsync();
                errorResponse.ErrorCode = response.StatusCode.ToString();
                errorResponse.RawResponse = errorResponse.ErrorString;
                return errorResponse;
            }
        }
    }
}
