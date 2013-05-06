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
using System.Windows.Media.Imaging;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System.IO.IsolatedStorage;

namespace Irrigation
{
    public partial class MainPage : PhoneApplicationPage
    {
        Random ran = new Random();
        PicReady[] picReady = new PicReady[3];
        Image[] lstImg;
        Field[] field = new Field[49];
        int num = 0;

        string[] imgPath;
        string[] disImgPath;

        SoundEffect effectPutDown;
        SoundEffect effectWaterDown;

        bool isStart;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            InitializeField();

            disImgPath = new string[11] { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg" };
            imgPath = new string[11] { "H1.jpg", "H2.jpg", "H3.jpg", "H4.jpg", "H5.jpg", "H6.jpg", "H7.jpg", "H8.jpg", "H9.jpg", "H10.jpg", "H11.jpg" };

            lstImg = new Image[44] {img02, img03, img05, img06, img08, img09, img10, img11, img12, img13, img14, img15, img16, img17, img18, img19, img20, img21, img22, img23, img24, img25, img26, img27, img28, img29, img30, img31, img32, img33, img34, img35, img36, img37, img38, img39, img40, img41, img42, img44, img45, img46, img47, img48,};

            effectPutDown = SoundEffect.FromStream(TitleContainer.OpenStream("Audio/putdown.wav"));
            effectWaterDown = SoundEffect.FromStream(TitleContainer.OpenStream("Audio/waterdown.wav"));
            FrameworkDispatcher.Update();
            ShowPicReady();

            ChooseGameLevel();
        }

        void ChooseGameLevel()
        {
            int count = 0;

            switch (App.gameState.Level)
            {
                case GameLevel.Easy:
                    count = 0;
                    break;
                case GameLevel.Normal:
                    count = 5;
                    break;
                case GameLevel.Hard:
                    count = 10;
                    break;
                case GameLevel.VeryHard:
                    count = 20;
                    break;
                default:
                    break;
            }

            isStart = true;

            for (int i = 0; i < count; i++)
            {
                Image img = lstImg[ran.Next(lstImg.Length)];
                Image_MouseLeftButtonUp(img, null);
            }

            isStart = false;
        }

        private void InitializeField()
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = new Field();
            }
            for (int i = 0; i < field.Length; i++)
            {
                if (i % 7 == 0)
                {
                    field[i].IsLinkL = null;
                }
                else
                {
                    field[i].IsLinkL = field[i - 1];
                }
                if ((i + 1) % 7 == 0)
                {
                    field[i].IsLinkR = null;
                }
                else
                {
                    field[i].IsLinkR = field[i + 1];
                }
                if (i < 7)
                {
                    field[i].IsLinkT = null;
                }
                else
                {
                    field[i].IsLinkT = field[i - 7];
                }
                if (i >= 42 && i <= 48)
                {
                    field[i].IsLinkB = null;
                }
                else
                {
                    field[i].IsLinkB = field[i + 7];
                }
            }
        }

        private void ShowPicReady()
        {
            picReady[2] = new PicReady(ran.Next(0, disImgPath.Length));
            ImageBrush ib2 = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/" + disImgPath[picReady[2].FiledNum], UriKind.Relative)) };
            picReady2.Background = ib2;

            picReady[1] = new PicReady(ran.Next(0, disImgPath.Length));
            ImageBrush ib1 = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/" + disImgPath[picReady[1].FiledNum], UriKind.Relative)) };
            picReady1.Background = ib1;

            picReady[0] = new PicReady(ran.Next(0, disImgPath.Length));
            ImageBrush ib0 = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/" + disImgPath[picReady[0].FiledNum], UriKind.Relative)) };
            picReady0.Background = ib0;
        }

        private void ReplacePicReady()
        {
            picReady[0] = picReady[1];
            picReady0.Background = picReady1.Background;
            picReady[1] = picReady[2];
            picReady1.Background = picReady2.Background;

            if (num < 46)
            {
                picReady[2] = new PicReady(ran.Next(0, disImgPath.Length));
                ImageBrush ib0 = new ImageBrush() { ImageSource = new BitmapImage(new Uri("Images/" + disImgPath[picReady[2].FiledNum], UriKind.Relative)) };
                picReady2.Background = ib0;
            }
            else
            {
                picReady[2] = null;
                picReady2.Background = null;
            }
        }

        private void GameOver(int index)
        {
            if (field[index].IsLinkT != null && field[index].Ready.IsOpenT)
            {
                if (field[index].IsLinkT.PicField.Tag != null && field[index].IsLinkT.Ready.IsOpenB)
                {
                    field[index].IsLinkT.PicField.Source = new BitmapImage(new Uri("Images/H" + disImgPath[field[index].IsLinkT.Ready.FiledNum], UriKind.Relative)); 
                    int i = Convert.ToInt32(field[index].IsLinkT.PicField.Tag);
                    field[index].IsLinkT.PicField.Tag = null;
                    GameOver(i);
                }
            }
            if (field[index].IsLinkB != null && field[index].Ready.IsOpenB)
            {
                if (field[index].IsLinkB.PicField.Tag != null && field[index].IsLinkB.Ready.IsOpenT)
                {
                    field[index].IsLinkB.PicField.Source = new BitmapImage(new Uri("Images/H" + disImgPath[field[index].IsLinkB.Ready.FiledNum], UriKind.Relative)) ; 
                    int i = Convert.ToInt32(field[index].IsLinkB.PicField.Tag);
                    field[index].IsLinkB.PicField.Tag = null;
                    GameOver(i);
                }
            }
            if (field[index].IsLinkL != null && field[index].Ready.IsOpenL)
            {
                if (field[index].IsLinkL.PicField.Tag != null && field[index].IsLinkL.Ready.IsOpenR)
                {
                    field[index].IsLinkL.PicField.Source = new BitmapImage(new Uri("Images/H" + disImgPath[field[index].IsLinkL.Ready.FiledNum], UriKind.Relative)); 
                    int i = Convert.ToInt32(field[index].IsLinkL.PicField.Tag);
                    field[index].IsLinkL.PicField.Tag = null;
                    GameOver(i);
                }
            }
            if (field[index].IsLinkR != null && field[index].Ready.IsOpenR)
            {
                if (field[index].IsLinkR.PicField.Tag != null && field[index].IsLinkR.Ready.IsOpenL)
                {
                    field[index].IsLinkR.PicField.Source = new BitmapImage(new Uri("Images/H" + disImgPath[field[index].IsLinkR.Ready.FiledNum], UriKind.Relative)); 
                    int i = Convert.ToInt32(field[index].IsLinkR.PicField.Tag);
                    field[index].IsLinkR.PicField.Tag = null;
                    GameOver(i);
                }
            }
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image b = (Image)sender;
            if (((System.Windows.Media.Imaging.BitmapImage)(b.Source)).UriSource.ToString() == "/Irrigation;component/Images/field.jpg")
            {
                field[int.Parse(b.Tag.ToString())].Ready = picReady[0];
                field[int.Parse(b.Tag.ToString())].PicField = b;

                b.Source = new BitmapImage(new Uri("Images/" + disImgPath[field[int.Parse(b.Tag.ToString())].Ready.FiledNum], UriKind.Relative));
                ReplacePicReady();
                num++;

                if (IsolatedStorageSettings.ApplicationSettings.Contains("SoundEffect"))
                {
                    bool isSoundEffect = (bool)IsolatedStorageSettings.ApplicationSettings["SoundEffect"];

                    if (isSoundEffect && !isStart)
                    {
                        effectPutDown.Play();
                    }
                }

                End();
            }
        }

        private void End()
        {
            if (num >= 49)
            {
                if (field[3].Ready.IsOpenT)
                {
                    GameOver(3);

                    if (IsolatedStorageSettings.ApplicationSettings.Contains("SoundEffect"))
                    {
                        bool isSoundEffect = (bool)IsolatedStorageSettings.ApplicationSettings["SoundEffect"];

                        if (isSoundEffect)
                        {
                            effectWaterDown.Play();
                        }
                    }

                    bool flg = true;

                    for (int i = 0; i < field.Length; i++)
                    {
                        if (field[i].PicField.Tag != null)
                        {
                            flg = false;
                            break;
                        }
                    }

                    if (flg)
                    {
                        GameOverTextBlock.Text = "你真是个天才，灌溉的很完美。";
                    }
                    else
                    {
                        GameOverTextBlock.Text = "很遗憾，你未能完成游戏。";
                    }
                }

                ContentPanel.Visibility = System.Windows.Visibility.Collapsed;
                GameOverGrid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}