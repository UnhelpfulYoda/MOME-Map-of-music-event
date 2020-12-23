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
        Venue venue;

        public AddMarker(string title, PointLatLng location, string img) : base(title)
        {
            this.location = location;
            marker = new GMapMarker(location)
            {
                Shape = new Image
                {
                    Width = 32, // ширина маркера
                    Height = 32, // высота маркера
                    ToolTip = title,
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
