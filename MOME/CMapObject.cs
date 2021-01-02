using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOME
{
    public abstract class CMapObject : ApiClient
    {
        public abstract GMapMarker getMarker();

        DateTime creationDate;

        string title;
        string city;
        string country;
        string artist;
        public CMapObject(string country, string city,string title,string artist)
        {
            this.title = title;
            this.city = city;
            this.country = country;
            this.artist = artist;
            creationDate = DateTime.Now;
        }
        public DateTime getCreationDate()
        {
            return creationDate;
        }
    }
}
