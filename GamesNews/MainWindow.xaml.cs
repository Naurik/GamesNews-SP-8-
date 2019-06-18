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
using GamesNews.Models;
using Newtonsoft.Json;

namespace GamesNews
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gridList.IsReadOnly = true;
        }

        public async void DownLoadInformation()
        {
            using (WebClient web = new WebClient())
            {
                var json = await web.DownloadStringTaskAsync("https://api.rawg.io/api/games");
                var result = JsonConvert.DeserializeObject<GameNewsJSon.GamesNews>(json);
                GameNewsJSon.GamesNews games = result;
                List<Games> gameList = new List<Games>();
                gameList.Clear();

                for(int i=0; i<20; i++)
                {
                    gameList.Add(new Games
                    {
                        FullName = games.results[i].name,
                        ImageSources = games.results[i].background_image,
                        Ratings = games.results[i].rating,
                        Description = games.description //описание почему-то пустое
                    });
                }
                gridList.ItemsSource = gameList; 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DownLoadInformation();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DownLoadInformation();
        }
    }
}
