using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientSample
{
    class Program
    {
        private const string uri = "https://ods.railway.gov.tw/tra-ods-web/ods/download/dataResource/2e9974cb150843348b2c9cff9f89db1e";

        static void Main(string[] args)
        {
            Run();

            Console.WriteLine("Hit enter to exit...");
            Console.WriteLine("臺鐵局機車、客貨車輛數："); 
            Console.ReadKey();
        }

        static async void Run()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.Timeout = TimeSpan.FromSeconds(30);
                    HttpResponseMessage response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }
    }
}

