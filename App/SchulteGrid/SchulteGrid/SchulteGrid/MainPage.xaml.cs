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
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using Microsoft.Phone.Tasks;

namespace SchulteGrid
{
   public partial class MainPage : PhoneApplicationPage
   {
      int currentNumber;
      Border border;

      Random ran;

      DispatcherTimer timer;
      DateTime dt;

      // 构造函数
      public MainPage()
      {
         InitializeComponent();
         ran = new Random();
      }

      private void Init()
      {
         currentNumber = 0;

         GameOverGrid.Visibility = System.Windows.Visibility.Collapsed;
         ContentPanel.Visibility = System.Windows.Visibility.Visible;
         AboutGrid.Visibility = System.Windows.Visibility.Collapsed;

         List<int> lst = new List<int>();

         for (int i = 0; i < 25; i++)
         {
            lst.Add(i + 1);
         }

         foreach (Button btn in Schulte_Grid.Children)
         {
            ControlTemplate ct = btn.Template;
            btn.Template = null;
            btn.Template = ct;

            int index = lst[ran.Next(lst.Count)];

            string str = index.ToString();

            btn.Content = str;

            lst.Remove(index);
         }

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
      }

      private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
      {
         Border bor = sender as Border;
         TextBlock txt = bor.Child as TextBlock;
         int number = Convert.ToInt32(txt.Text);

         if (number == currentNumber + 1)
         {
            bor.Background = new SolidColorBrush((Color)Application.Current.Resources["PhoneAccentColor"]);

            if (border != null)
            {
               border.Background = new SolidColorBrush((Color)Application.Current.Resources["PhoneBackgroundColor"]);
            }

            border = bor;

            currentNumber++;

            if (currentNumber == 25)
            {
               GameOver();
            }
         }
      }

      private void GameOver()
      {
         ScoreTimeTextBlock.Text = TimeTextBlock.Text;

         GameOverGrid.Visibility = System.Windows.Visibility.Visible;
         GameGrid.Visibility = System.Windows.Visibility.Collapsed;
         ContentPanel.Visibility = System.Windows.Visibility.Collapsed;
         AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
      }

      private void ButtonStackPanel_Click(object sender, RoutedEventArgs e)
      {
         if (GameGrid.Visibility == System.Windows.Visibility.Collapsed)
         {
            Init();
            GameGrid.Visibility = System.Windows.Visibility.Visible;
            HelpTextBlock.Visibility = System.Windows.Visibility.Collapsed;
            AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
         }
         else
         {
            MessageBoxResult result = MessageBox.Show(AppResource.MessageBoxRestart, AppResource.MessageBoxQuestion, MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
               Init();
            }
         }
      }

      private void btnAuthor_Click(object sender, RoutedEventArgs e)
      {
         EmailComposeTask task = new EmailComposeTask();
         task.To = "luyu_1216@126.com";
         task.Show();
      }

      private void btnAbout_Click(object sender, RoutedEventArgs e)
      {
         if (GameGrid.Visibility == System.Windows.Visibility.Visible)
         {
            MessageBoxResult result = MessageBox.Show(AppResource.MessageBoxExit, AppResource.MessageBoxQuestion, MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.Cancel)
            {
               return;
            }
         }

         if (AboutGrid.Visibility == System.Windows.Visibility.Collapsed)
         {
            AboutGrid.Visibility = System.Windows.Visibility.Visible;
            GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            HelpTextBlock.Visibility = System.Windows.Visibility.Collapsed;
         }
      }

      private void btnShare_Click(object sender, RoutedEventArgs e)
      {
         MarketplaceDetailTask task = new MarketplaceDetailTask();
         task.ContentType = MarketplaceContentType.Applications;
         task.Show();
      }

      private void RestartButton_Click(object sender, RoutedEventArgs e)
      {
         Init();
         ContentPanel.Visibility = System.Windows.Visibility.Visible;
         GameGrid.Visibility = System.Windows.Visibility.Visible;
         GameOverGrid.Visibility = System.Windows.Visibility.Collapsed;
         AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
         HelpTextBlock.Visibility = System.Windows.Visibility.Collapsed;
      }

      protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
      {
         if (GameGrid.Visibility == System.Windows.Visibility.Visible)
         {
            MessageBoxResult result = MessageBox.Show(AppResource.MessageBoxExit, AppResource.MessageBoxQuestion, MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
               AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
               GameGrid.Visibility = System.Windows.Visibility.Collapsed;
               HelpTextBlock.Visibility = System.Windows.Visibility.Visible;

               e.Cancel = true;
            }
         }

         if (GameOverGrid.Visibility == System.Windows.Visibility.Visible)
         {
            GameOverGrid.Visibility = System.Windows.Visibility.Collapsed;
            AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
            GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            ContentPanel.Visibility = System.Windows.Visibility.Visible;
            HelpTextBlock.Visibility = System.Windows.Visibility.Visible;

            e.Cancel = true;
         }
      }
   }
}