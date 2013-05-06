using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ColorBlindness
{
    public static class GlobalCache
    {
        public static readonly Color[] ItemColors = { Colors.Red, Colors.Blue, Colors.Cyan, Colors.Purple, Colors.Yellow, Colors.Green };
        public static readonly string[] ItemsColorsName = { AppResource.Red, AppResource.Blue, AppResource.Cyan, AppResource.Purple, AppResource.Yellow, AppResource.Green };
    }
}
