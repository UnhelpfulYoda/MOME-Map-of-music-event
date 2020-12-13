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
        const string URL = "https://rest.bandsintown.com/artists/scarlxrd/events?app_id=d89e4eb83aa95db3c184350931fa7136&date=all";
        const string PARAMS = "https://rest.bandsintown.com/v4/artists/scarlxrd/events/?app_id=d89e4eb83aa95db3c184350931fa7136";

        RestClient client = null;
        JsonParser jsonParser = new JsonParser();

        public ApiClient()
        {
            client = new RestClient(URL);
            client.Timeout = -1;
        }

        public List<EventsData> LoadEventsData(string city = "Lisbon")
        {
            string uri = string.Format(PARAMS, city, "json", API_KEY);
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);
            string data = response.Content;
            return jsonParser.ParseEventsData(data);
        }


    }
}
