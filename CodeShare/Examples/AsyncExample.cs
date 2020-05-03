using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CodeShare.Examples
{
    internal class AsyncExample
    {
        public async Task ExampleAsync()
        {
            var task = MakeSomeCallAsync();
            HighCpuUsageProcess();
            await task;
        }

        private async Task MakeSomeCallAsync()
        {
            HttpClient client = null;
            try
            {
                client = new HttpClient();
                var results = await client.GetAsync("https://www.reddit.com/");
                Console.WriteLine(results.Content.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                client?.Dispose();
            }
        }

        private void HighCpuUsageProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
