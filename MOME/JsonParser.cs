﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOME
{
    class JsonParser
    {
        public List<EventsData> ParseEventsData(string data)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data); 
            return new List<EventsData>();
        }
    }
}
