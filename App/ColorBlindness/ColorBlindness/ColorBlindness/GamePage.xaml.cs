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
using System.Windows.Threading;

namespace ColorBlindness
{
    public partial class GamePage : PhoneApplicationPage
    {
        int currentIndex;
        readonly SolidColorBrush[] backgroundSolidColorBrush;
        Random ran;
        List<Button> lstItemButton;

        DispatcherTimer timer;
        DateTime dt;

        int errorTimes;
        int scoreTime;
        int score;

        public GamePage()
        {
            InitializeComponent();

            backgroundSolidColorBrush = new SolidColorBrush[]
            {
                new SolidColorBrush((Color)Application.Current.Resources["PhoneBorderColor"]),
                new SolidColorBrush((Color)Application.Current.Resources["PhoneBackgroundColor"])
            };

            lstItemButton = new List<Button>() 
            {
                ItemButton_1, ItemButton_2, ItemButton_3, ItemButton_4, ItemButton_5, ItemButton_6
            };

            ran = new Random();

            Init();
        }

        void Init()
        {
            errorTimes = 0;
            scoreTime = 10000;
            score = 1000;

            GameOverGrid.Visibility = System.Windows.Visibility.Collapsed;
            ContentPanel.Visibility = System.Windows.Visibility.Visible;

            ErrorTimesTextBlock.Text = AppResource.ErrorCount + errorTimes;
            ScoreTextBlock.Text = score.ToString();

            ProgressSlider.Value = 0;

            RefreshColor();

            dt = DateTime.Now;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - dt;
            DateTime n = new DateTime(span.Ticks);
            TimeTextBlock.Text = n.ToString("mm:ss:ff");
            scoreTime--;
            ScoreTimeTextBlock.Text = scoreTime.ToString();

            if (scoreTime < 0)
            {
                GameOver();
            }
        }

        void RefreshColor()
        {
            MainItemBorder.Background = backgroundSolidColorBrush[ran.Next(100) > 66 ? 0 : 1];
            MainItemTextBlock.Text = GlobalCache.ItemsColorsName[ran.Next(GlobalCache.ItemsColorsName.Length)];

            currentIndex = ran.Next(GlobalCache.ItemColors.Length);

            MainItemTextBlock.Foreground = new SolidColorBrush(GlobalCache.ItemColors[currentIndex]);

            List<int> lstColor = new List<int>() { 0, 1, 2, 3, 4, 5 };
            List<int> lstName = new List<int>() { 0, 1, 2, 3, 4, 5 };

            foreach (Button btn in lstItemButton)
            {
                int indexColor = lstColor[ran.Next(lstColor.Count)];
                int indexName = lstName[ran.Next(lstName.Count)];

                btn.IsEnabled = true;
                btn.Foreground = new SolidColorBrush(GlobalCache.ItemColors[indexColor]);
                btn.Content = GlobalCache.ItemsColorsName[indexName];
                btn.Tag = indexName;
                btn.Background = backgroundSolidColorBrush[ran.Next(100) > 66 ? 0 : 1];

                lstColor.Remove(indexColor);
                lstName.Remove(indexName);
            }
        }

        private void ItemButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int index = (int)btn.Tag;

            if (index == currentIndex)
            {
                ProgressSlider.Value++;

                if (ProgressSlider.Value == 20)
                {
                    GameOver();
                }
                else
                {
                    RefreshColor();
                }
            }
            else
            {
                btn.IsEnabled = false;
                errorTimes++;
                score -= 20;

                ErrorTimesTextBlock.Text = AppResource.ErrorCount + errorTimes;
                ScoreTextBlock.Text = score.ToString();
            }
        }

        void GameOver()
        {
            timer.Stop();
            ScoreGameOver.Text = score.ToString();
            ScoreTimeGameOver.Text = scoreTime.ToString();
            Score.Text = (score * 10 + scoreTime).ToString();

            GameOverGrid.Visibility = System.Windows.Visibility.Visible;
            ContentPanel.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Init();
        }
    }
}