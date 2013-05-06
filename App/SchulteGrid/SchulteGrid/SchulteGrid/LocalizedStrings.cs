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

namespace SchulteGrid
{
    public class LocalizedStrings
    {
        public LocalizedStrings()
        {

        }

        private static SchulteGrid.AppResource localizedresources = new AppResource();

        public SchulteGrid.AppResource Localizedresources 
        {
            get 
            { 
                return localizedresources; 
            } 
        }
    }
}
