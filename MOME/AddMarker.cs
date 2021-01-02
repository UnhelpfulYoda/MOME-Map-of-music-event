using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MOME
{
    class AddMarker : CMapObject
    {
        GMapMarker marker;
        PointLatLng location;

        public AddMarker(string country, string city, string title, string artists, PointLatLng location, string img) : base(country, city,title,artists)
        {
            this.location = location;
            marker = new GMapMarker(location)
            {
                Shape = new Image
                {
                    Width = 32, // ширина маркера
                    Height = 32, // высота маркер
                    ToolTip = (country,city,title,artists),
                    Source = new BitmapImage(new Uri("pack://application:,,,/images/location.png")) // картинка
                }
            };
        }

        public override GMapMarker getMarker()
        {
            return marker;
        }
    }
}
