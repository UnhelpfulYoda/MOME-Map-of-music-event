﻿using Newtonsoft.Json;
using System.Collections.Generic;


namespace MOME
{
    public class JsonParser
    {
        public List<EventsData> ParseEventsData(string data)
        {
            List<Root> myDeserializedClass = JsonConvert.DeserializeObject <List<Root>>(data);
            return converter(myDeserializedClass);
        }

        public List<EventsData> converter(List<Root> root)
        {
            List<EventsData> dataconvert = new List<EventsData>();
            foreach(Root rt in root)
            {
                var events = new EventsData()
                {
                    Artists = rt.lineup[0],   
                    Country = rt.venue.country,
                    City = rt.venue.city,
                    Name = rt.venue.name,
                    Latitude = rt.venue.latitude,
                    Longitude = rt.venue.longitude,
                };
                dataconvert.Add(events);
            }
            return dataconvert;
        }
    }
}
