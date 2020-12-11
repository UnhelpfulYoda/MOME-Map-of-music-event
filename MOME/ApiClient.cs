using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOME
{
    class ApiClient
    {
        const string API_KEY = "d89e4eb83aa95db3c184350931fa7136";
        const string URL = "https://www.bandsintown.com/e/123456?app_id=d89e4eb83aa95db3c184350931fa7136-id&came_from=267&utm_medium=api&utm_source=public_api&utm_campaign=event";
        const string PARAMS = "https://rest.bandsintown.com/v4/artists/*/events?app_id=d89e4eb83aa95db3c184350931fa7136-id";

        RestClient client = null;

        public ApiClient()
        {
            client = new RestClient(URL);
            client.Timeout = -1;
        }

        public List<EventsData> LoadEventsData(string artists = "artists")
        {
            string uri = string.Format(PARAMS, artists, "xml", API_KEY);
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);
            string data = response.Content;
            return new List<EventsData>();
        }


    }
}
