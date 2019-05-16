using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SteaamNews2
{
    static public class SteamLoadData
    {
        static HttpClient client = new HttpClient();

        static public List<newsitem> GetNewsByID(int ID, int Count =2, int Max=100000)
        {
            RootObject NewsList = new RootObject();

            HttpResponseMessage uff = GetNewsAPI(client, ID, Count, Max).GetAwaiter().GetResult();
            string text = uff.Content.ReadAsStringAsync().GetAwaiter().GetResult();
           // text = text.Replace("\\", "");
            

            if (uff.StatusCode == HttpStatusCode.OK)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    try
                    {
                        NewsList = JsonConvert.DeserializeObject<RootObject>(text);

                    }
                    catch (Exception e)
                    {

                    }
                }
                
          
            }

            return NewsList.appnews.newsitems;



           
        }
        static public List<newsitem> GetNewsByIDs(List<int> IDs, int Count = 2, int Max = 10000)
        {
            RootObject NewsList = new RootObject();
            List<newsitem> newsitems = new List<newsitem>();

            foreach(int ID in IDs)
            {
                HttpResponseMessage uff = GetNewsAPI(client, ID, Count, Max).GetAwaiter().GetResult();
                string text = uff.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                // text = text.Replace("\\", "");


                if (uff.StatusCode == HttpStatusCode.OK)
                {
                    if (!string.IsNullOrEmpty(text))
                    {
                        try
                        {
                            
                            NewsList = JsonConvert.DeserializeObject<RootObject>(text);

                            newsitems.InsertRange(0,NewsList.appnews.newsitems);

                        }
                        catch (Exception e)
                        {

                        }
                    }


                }
            }

            

            return newsitems;




        }
        public static Task<HttpResponseMessage> GetNewsAPI(HttpClient client, int ID, int Count, int Max)
        {
            return client.GetAsync("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid="+ID+"&count="+Count+"&maxlength="+Max+"&format=json");
        }
        
    }
}
