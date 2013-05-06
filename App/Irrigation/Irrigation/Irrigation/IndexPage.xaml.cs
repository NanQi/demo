using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;

namespace Irrigation
{
    public partial class IndexPage : PhoneApplicationPage
    {
        public IndexPage()
        {
            InitializeComponent();

            if (IsolatedStorageSettings.ApplicationSettings.Contains("SoundEffect"))
            {
                bool isSoundEffect = (bool)IsolatedStorageSettings.ApplicationSettings["SoundEffect"];

                tsSoundEffect.IsChecked = isSoundEffect;
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("Background"))
            {
                bool isBackground = (bool)IsolatedStorageSettings.ApplicationSettings["Background"];

                tsBackground.IsChecked = isBackground;

                if (isBackground)
                {
                    ImageBrush ib = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/background.jpg", UriKind.Relative)) };
                    panoramaIndex.Background = ib;
                }
                else
                {
                    Brush brush  = Application.Current.Resources["PhoneBackgroundBrush"] as Brush;

                    panoramaIndex.Background = brush;
                }
            }
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            App.gameState.Level = GameLevel.Easy;
            StartGame();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            App.gameState.Level = GameLevel.Normal;
            StartGame();
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            App.gameState.Level = GameLevel.Hard;
            StartGame();
        }

        private void btnVeryHard_Click(object sender, RoutedEventArgs e)
        {
            App.gameState.Level = GameLevel.VeryHard;
            StartGame();
        }

        void StartGame()
        {
            App.gameState.IsStart = true;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void btnAuthor_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.To = "luyu_1216@126.com";
            task.Show();
        }

        private void btnRating_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceDetailTask task = new MarketplaceDetailTask();
            task.ContentType = MarketplaceContentType.Applications;
            task.ContentIdentifier = null;
            task.Show();
        }

        private void tsSoundEffect_Checked(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["SoundEffect"] = tsSoundEffect.IsChecked;
            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        private void tsBackground_Checked(object sender, RoutedEventArgs e)
        {
            bool flg = (bool)tsBackground.IsChecked;

            IsolatedStorageSettings.ApplicationSettings["Background"] = flg;
            IsolatedStorageSettings.ApplicationSettings.Save();

            if (flg)
            {
                ImageBrush ib = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/background.jpg", UriKind.Relative)) };
                panoramaIndex.Background = ib;
            }
            else
            {
                Brush brush = Application.Current.Resources["PhoneBackgroundBrush"] as Brush;

                panoramaIndex.Background = brush;
            }
        }
    }
}