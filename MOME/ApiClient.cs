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
        const string URL = "https://www.bandsintown.com/e/123456?app_id=yOUrSuP3r3ven7aPp-id&came_from=267&utm_medium=api&utm_source=public_api&utm_campaign=event";
        const string PARAMS = "https://rest.bandsintown.com/v4/artists/{{artist_name}}/events/?app_id=d89e4eb83aa95db3c184350931fa7136-id";

        RestClient client = null;

        public ApiClient()
        {
            client = new RestClient(URL);
            client.Timeout = -1;
        }


    }
}
