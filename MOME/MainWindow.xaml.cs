using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOME
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<CMapObject> objs = new List<CMapObject>();
        int count;
        List<EventsData> dataconvert = new List<EventsData>();
        public MainWindow()
        {
            InitializeComponent();

            clientComboBox.Items.Add("xml");
            clientComboBox.Items.Add("json");

            cityComboBox.Items.Add("Hasselt");

            ApiClient apiClient = new ApiClient();
            dataconvert = apiClient.LoadEventsData();




        }
        private void map_Loaded(object sender, RoutedEventArgs e)
        {
            // настройка доступа к данным
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // установка провайдера карт
            map.MapProvider = YandexMapProvider.Instance;

            // установка зума карты
            map.MinZoom = 2;
            map.MaxZoom = 17;
            map.Zoom = 15;
            // установка фокуса карты
            
            map.Position = new PointLatLng(50.9333333, 5.3333333);

            // настройка взаимодействия с картой
            map.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            map.CanDragMap = true;
            map.DragButton = MouseButton.Left;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            foreach (EventsData element in dataconvert)
            {
                objs.Add(new AddMarker(element.Name, 
                    new PointLatLng(Convert.ToDouble(element.Latitude, CultureInfo.InvariantCulture),
                    Convert.ToDouble(element.Longitude, CultureInfo.InvariantCulture)),  
                    "location.png"));
            }

            foreach (CMapObject pl in objs)
                map.Markers.Add(pl.getMarker());
        }

        private void start_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach (EventsData inf in dataconvert)
            {
                objs.Add(new AddMarker(inf.Name,
                    new PointLatLng(Convert.ToDouble(inf.Latitude, CultureInfo.InvariantCulture),
                    Convert.ToDouble(inf.Longitude, CultureInfo.InvariantCulture)),
                    "location.png"));
            }
        }
    }
}
