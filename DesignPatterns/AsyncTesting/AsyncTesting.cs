using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatterns.AsyncTesting
{
    class AsyncTesting
    {

        private String reportedWebSiteInfo;

        //private async void executeAsync_Click(object sender, RoutedEventArgs e)
        public async void ExecuteAsync_Click()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadParallelAsync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            //resultsWindow.Text += $"Total execution time: { elapsedMs }";
            Console.WriteLine($"Total execution time: { elapsedMs }");
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (string site in websites)
            {
                tasks.Add(DownloadWebsiteAsync(site));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }
            // Print end result (for non gui version)
            Console.WriteLine(reportedWebSiteInfo);
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();

            //resultsWindow.Text = "";
            reportedWebSiteInfo = "";

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }

        private async Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            //resultsWindow.Text += $"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long.{ Environment.NewLine }";
            reportedWebSiteInfo += $"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long.{ Environment.NewLine }";
            Debug.WriteLine("xx");
        }
    }
}
