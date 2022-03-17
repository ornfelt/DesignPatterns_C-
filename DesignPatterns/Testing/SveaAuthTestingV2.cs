using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace DesignPatterns.Testing
{
    class SveaAuthTestingV2
    {
        HttpClient _client = new HttpClient();
        public async void TestAuthV2()
        {
            Console.WriteLine("Start");
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://checkoutapistage.svea.com/api/orders/1");
            await SendHttpRequestAndProcessHttpResponse(requestMessage, false);
            Console.WriteLine("Fin");
        }

        internal async Task SendHttpRequestAndProcessHttpResponse(HttpRequestMessage httpRequest, bool configureAwait)
        {
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            await SetRequestHeaders(httpRequest, configureAwait);
            var requestBody = string.Empty;

            // Send request
            //var response = await _client.SendAsync(httpRequest);
            //Console.WriteLine("response: " + response);
            var httpResponse = await _client.SendAsync(httpRequest).ConfigureAwait(configureAwait);
            Console.WriteLine("response: " + httpResponse);
        }

        private async Task SetRequestHeaders(HttpRequestMessage httpRequest, bool configureAwait)
        {
            var timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            //var token = CreateAuthenticationToken(httpRequest.Content != null ? await httpRequest.Content.ReadAsStringAsync().ConfigureAwait(configureAwait) : string.Empty, timestamp);
            var token = CreateAuthenticationToken(string.Empty, timestamp);
            httpRequest.Headers.Add("Authorization", "Svea" + " " + token);
            httpRequest.Headers.Add("Timestamp", timestamp);
        }

        private string CreateAuthenticationToken(string requestBody, string timestamp)
        {
            using (var sha512 = SHA512.Create())
            {
                String MerchantId = "124842";
                String SecretKey ="1NDxpT2WQ4PW6Ud95rLWKD98xVr45Q8O9Vd52nomC7U9B18jp7lHCu7nsiTJO1NWXjSx26vE41jJ4rul7FUP1cGKXm4wakxt3iF7k63ayleb1xX9Di2wW46t9felsSPW";
                var hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(requestBody, SecretKey, timestamp)));
                var hashString = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(MerchantId + ":" + hashString));
            }
        }

    }
}
