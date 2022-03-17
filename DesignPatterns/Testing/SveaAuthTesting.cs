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
        private static HttpRequestMessage httpRequest;

        public static void Main(string[] args)
        //public static void Old(string[] args)
        {
            //TestAuth().Wait();
            //Task.Run(() => TestAuth());

            ExecuteAsync_Request();
            SveaAuthTestingV2 v2 = new SveaAuthTestingV2();
            //v2.TestAuthV2();
            Console.ReadLine();
        }

        private static async void ExecuteAsync_Request()
        {
            await TestAuth();
        }

        private static async Task TestAuth()
        {
            var client = new HttpClient();
            //httpRequest = new HttpRequestMessage(HttpMethod.Get, "https://paymentadminapistage.svea.com/api/v1/orders/1");
            httpRequest = new HttpRequestMessage(HttpMethod.Get, "https://paymentadminapistage.svea.com/api/v1/orders/6609003");

            //httpRequest = new HttpRequestMessage(HttpMethod.Get, "https://checkoutapistage.svea.com/api/orders/1");

            //Task task = SetHttpRequestHeaders(client, "", String.Empty);
            //await Task.WhenAll(task);

            await SetHttpRequestHeaders(client, "", String.Empty);
            //SetHttpRequestHeaders(client, "", String.Empty);
            Console.WriteLine("CreatAuth task done");

            var response = await client.SendAsync(httpRequest);
            //response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Console.WriteLine("reponse: " + response);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("response body: " + responseBody);
            await Task.CompletedTask;
        }

        protected static async Task SetHttpRequestHeaders(HttpClient client, string operation, string requestMessage)
        //private static void SetHttpRequestHeaders(HttpClient client, string operation, string requestMessage)
        {
            client.Timeout = new TimeSpan(0, 0, 30);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string token = CreateAuthenticationToken(requestMessage, timestamp);

            //client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Svea " + token);
            //client.DefaultRequestHeaders.TryAddWithoutValidation("Timestamp", timestamp);
            httpRequest.Headers.Add("Authorization", "Svea" + " " + token);
            httpRequest.Headers.Add("Timestamp", timestamp);
            await Task.CompletedTask;
        }

        public static string EncodeNonAsciiCharacters(string value) {
         StringBuilder sb = new StringBuilder();
         foreach( char c in value ) {
             if( c > 127 ) {
                 // This character is too big for ASCII
                 string encodedValue = "\\u" + ((int) c).ToString( "x4" );
                 sb.Append( encodedValue );
             }
             else {
                 sb.Append( c );
             }
         }
         return sb.ToString();
     }

        private static String CreateAuthenticationToken (string requestMessage, string timestamp)
        {
            using (var sha512 = SHA512.Create())
            {
                //String SecretKey = "124842";
                //String MerchantId = "1NDxpT2WQ4PW6Ud95rLWKD98xVr45Q8O9Vd52nomC7U9B18jp7lHCu7nsiTJO1NWXjSx26vE41jJ4rul7FUP1cGKXm4wakxt3iF7k63ayleb1xX9Di2wW46t9felsSPW";
                String MerchantId = "124842";
                String SecretKey ="1NDxpT2WQ4PW6Ud95rLWKD98xVr45Q8O9Vd52nomC7U9B18jp7lHCu7nsiTJO1NWXjSx26vE41jJ4rul7FUP1cGKXm4wakxt3iF7k63ayleb1xX9Di2wW46t9felsSPW";

                var hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(requestMessage, SecretKey, timestamp)));
                var hashString = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(MerchantId + ":" + hashString));
            }
        }
    }
}
