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
        string title;
        public abstract GMapMarker getMarker();

        DateTime creationDate;
        public CMapObject(string title)
        {
            this.title = title;
            creationDate = DateTime.Now;
        }
        public DateTime getCreationDate()
        {
            return creationDate;
        }
    }
}
