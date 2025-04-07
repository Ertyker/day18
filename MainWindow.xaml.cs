using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;

namespace day18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }
        public string HotelImage { get; set; }
    }
public partial class MainWindow : Window
    {
        public List<Hotel> CurrentHotels { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var client = new WebClient();
            var response = client.DownloadString("http://localhost:/api/hotels");
            CurrentHotels = JsonConvert.DeserializeObject<List<Hotel>>(response);
            DataContext = this;
        }
    }

}
