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
using Microsoft.Phone.Tasks;

namespace ColorBlindness
{
    public partial class MainPage : PhoneApplicationPage
    {
        //#region InitApplicationBar
        //ApplicationBarIconButton btnShare;
        //ApplicationBarIconButton btnAbout;
        //ApplicationBarIconButton btnEmail;
        //ApplicationBarIconButton btnSettings;

        //private void InitAppbar()
        //{
        //    base.ApplicationBar = new ApplicationBar();
        //    base.ApplicationBar.Buttons.Clear();

        //    btnShare = new ApplicationBarIconButton
        //    {
        //        Text = AppResource.Share,
        //        IconUri = new Uri("/icons/appbar.share.rest.png", UriKind.Relative)
        //    };
        //    btnShare.Click += btnShare_Click;
        //    base.ApplicationBar.Buttons.Add(btnShare);

        //    btnAbout = new ApplicationBarIconButton
        //    {
        //        Text = AppResource.About,
        //        IconUri = new Uri("/icons/appbar.questionmark.rest.png", UriKind.Relative)
        //    };
        //    btnAbout.Click += btnAbout_Click;
        //    base.ApplicationBar.Buttons.Add(btnAbout);

        //    btnEmail = new ApplicationBarIconButton
        //    {
        //        Text = AppResource.Email,
        //        IconUri = new Uri("/icons/appbar.feature.email.rest.png", UriKind.Relative)
        //    };
        //    btnEmail.Click += btnEmail_Click;
        //    base.ApplicationBar.Buttons.Add(btnEmail);

        //    btnSettings = new ApplicationBarIconButton
        //    {
        //        Text = AppResource.Settings,
        //        IconUri = new Uri("/icons/appbar.feature.settings.rest.png", UriKind.Relative)
        //    };
        //    btnSettings.Click += btnSettings_Click;
        //    base.ApplicationBar.Buttons.Add(btnSettings);
        //}

        //private void btnShare_Click(object sender, System.EventArgs e)
        //{
        //    // 在此处添加事件处理程序实现。
        //}

        //private void btnAbout_Click(object sender, System.EventArgs e)
        //{
        //    // 在此处添加事件处理程序实现。
        //}

        //private void btnEmail_Click(object sender, System.EventArgs e)
        //{
        //    // 在此处添加事件处理程序实现。
        //}

        //private void btnSettings_Click(object sender, System.EventArgs e)
        //{
        //    // 在此处添加事件处理程序实现。
        //}
        //#endregion

        // 构造函数
        public MainPage()
        {
            InitializeComponent();
            //InitAppbar();
            InitHelpTextBlock();
        }

        private void InitHelpTextBlock()
        {
            if (System.Globalization.CultureInfo.CurrentCulture.Name != "zh-CN" &&
                System.Globalization.CultureInfo.CurrentCulture.Name != "zh-TW")
            {
                #region en-US:Help
                HelpTextBlock.Inlines.Clear();
                HelpTextBlock.Inlines.Add("The start of the game appears at the top of a color of the text such as text [");

                Span span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Blue);
                span.Inlines.Add("Red");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("], but this is the text color is blue, the answer is [blue]");
                HelpTextBlock.Inlines.Add(new LineBreak());
                HelpTextBlock.Inlines.Add("Under a total of six options, this choice of words have different colors, such as[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Blue);
                span.Inlines.Add("Cyan");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Yellow);
                span.Inlines.Add("Purple");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Green);
                span.Inlines.Add("Blue");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Cyan);
                span.Inlines.Add("Red");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Red);
                span.Inlines.Add("Green");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Purple);
                span.Inlines.Add("Yellow");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("] will have to select the top of the [");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Green);
                span.Inlines.Add("Blue");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("] is the correct answer");
                HelpTextBlock.Inlines.Add(new LineBreak());
                HelpTextBlock.Inlines.Add("To the start of the game there will be 1000 points, each time you press the wrong by 20 points the entire game a total of 20 questions, all answered that the game will end");

                HelpTextBlock.LineHeight = 20;
                HelpTextBlock.Margin = new Thickness(20, 10, 20, 10);
                #endregion
            }
            else
            {
                #region zh-CN:Help
                HelpTextBlock.Inlines.Clear();
                HelpTextBlock.Inlines.Add("游戏开始时上方会出现一个有颜色的文字例如文字是[");

                Span span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Blue);
                span.Inlines.Add("红色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]，但这文字的颜色是蓝色，这个答案就是[蓝色]");
                HelpTextBlock.Inlines.Add(new LineBreak());
                HelpTextBlock.Inlines.Add("下方共有6个选择，这选择的字亦有不同颜色，例如[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Blue);
                span.Inlines.Add("青色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Yellow);
                span.Inlines.Add("紫色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Green);
                span.Inlines.Add("蓝色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Cyan);
                span.Inlines.Add("红色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Red);
                span.Inlines.Add("绿色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]、[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Purple);
                span.Inlines.Add("黄色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]便要选择上方的[");

                span = new Span();
                span.Foreground = new SolidColorBrush(Colors.Green);
                span.Inlines.Add("蓝色");
                HelpTextBlock.Inlines.Add(span);

                HelpTextBlock.Inlines.Add("]，才是正确答案");
                HelpTextBlock.Inlines.Add(new LineBreak());
                HelpTextBlock.Inlines.Add("游戏开始时会有1000分，每按错1次减20分，整个游戏共有20题，全部答完就会结束游戏");

                HelpTextBlock.LineHeight = 35;
                HelpTextBlock.Margin = new Thickness(20);
                #endregion
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GamePage.xaml", UriKind.Relative));
        }

        private void hbtnShare_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceDetailTask task = new MarketplaceDetailTask();
            task.ContentType = MarketplaceContentType.Applications;
            task.Show();
        }

        private void hbtnAbout_Click(object sender, RoutedEventArgs e)
        {
            if (AboutGrid.Visibility == System.Windows.Visibility.Collapsed)
            {
                AboutGrid.Visibility = System.Windows.Visibility.Visible;
                HelpTextBlock.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                AboutGrid.Visibility = System.Windows.Visibility.Collapsed;
                HelpTextBlock.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void btnAuthor_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.To = "luyu_1216@126.com";
            task.Show();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //App.Current
        }
    }
}