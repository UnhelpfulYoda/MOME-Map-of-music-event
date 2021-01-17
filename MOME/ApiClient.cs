using RestSharp;
using System.Collections.Generic;
namespace MOME
{
    public class ApiClient
    {
        const string API_KEY = "d89e4eb83aa95db3c184350931fa7136";
        const string URL = "https://rest.bandsintown.com/artists/Eminem/events?app_id=d89e4eb83aa95db3c184350931fa7136&date=upcoming";
        const string PARAMS = "?mode={0}&appid={1}&date={2}";

        RestClient client = null;
        JsonParser jsonParser = new JsonParser();

        public ApiClient()
        {
            client = new RestClient(URL);
            client.Timeout = -1;
        }

        public List<EventsData> LoadEventsData(string city = " ")
        {
            string uri = string.Format(PARAMS, city, "json", API_KEY);
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);
            string data = response.Content;
            return jsonParser.ParseEventsData(data);
        }


    }
}
