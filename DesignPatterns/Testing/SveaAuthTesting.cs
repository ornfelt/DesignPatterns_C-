using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Globalization;
using System.Diagnostics;

namespace DesignPatterns.Testing
{
    class SveaAuthTesting
    {
        //public static void Main(string[] args)
        public static void Old(string[] args)
        {
            //TestAuth().Wait();
            Task.Run(() => TestAuth());
            Console.ReadLine();
        }

        private static async Task TestAuth()
        {
            var client = new HttpClient();
            //client.BaseAddress = new Uri("https://paymentadminapistage.svea.com");
            //Task task = SetHttpRequestHeaders(client, "", String.Empty);
            SetHttpRequestHeaders(client, "", String.Empty);
            //await Task.WhenAll(task);
            Console.WriteLine("CreatAuth task done");
            //var result = await client.PostAsync("/api/v1/orders/1");
            //string resultContent = await result.Content.ReadAsStringAsync();
            //Console.WriteLine(resultContent);

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://paymentadminapistage.svea.com/api/v1/orders/1");
            //var response = await client.SendAsync(requestMessage).ConfigureAwait(false);
            var response = await client.SendAsync(requestMessage);
            //response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Console.WriteLine("reponse: " + responseBody);
            Debug.WriteLine("Finished Task1");
            Debug.WriteLine("response: " + responseBody);
            Console.WriteLine("Done...");
            await Task.CompletedTask;
        }

        //protected static async Task SetHttpRequestHeaders(HttpClient client, string operation, string requestMessage)
        private static void SetHttpRequestHeaders(HttpClient client, string operation, string requestMessage)
        {
            //client.Timeout = new TimeSpan(0, 0, 30);
            //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string token = CreateAuthenticationToken(requestMessage, timestamp);
            client.DefaultRequestHeaders.Add("Authorization", "Svea" + " " + token);
            client.DefaultRequestHeaders.Add("Timestamp", timestamp);
            //await Task.CompletedTask;
        }


        private static String CreateAuthenticationToken (string requestMessage, string timestamp)
        {
            using (var sha512 = SHA512.Create())
            {
                String SecretKey = "124842";
                String MerchantId = "1NDxpT2WQ4PW6Ud95rLWKD98xVr45Q8O9Vd52nomC7U9B18jp7lHCu7nsiTJO1NWXjSx26vE41jJ4rul7FUP1cGKXm4wakxt3iF7k63ayleb1xX9Di2wW46t9felsSPW";
                var hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(requestMessage, SecretKey, timestamp)));
                var hashString = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(MerchantId + ":" + hashString));
            }
        }
    }
}
