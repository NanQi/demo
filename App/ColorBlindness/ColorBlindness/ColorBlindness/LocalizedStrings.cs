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
    public class LocalizedStrings
    {
        public LocalizedStrings()
        {

        }

        private static ColorBlindness.AppResource localizedresources = new AppResource();

        public ColorBlindness.AppResource Localizedresources 
        {
            get 
            { 
                return localizedresources; 
            } 
        }
    }
}
