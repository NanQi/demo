using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSelectDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            chbxAll.IsChecked = checkListBox.SelectedItems.Count == 0 ? false :
                    checkListBox.SelectedItems.Count == checkListBox.Items.Count ? (bool?)true : null;
        }

        private void chbxAll_Checked(object sender, RoutedEventArgs e)
        {
            checkListBox.SelectAll();
        }

        private void chbxAll_Unchecked(object sender, RoutedEventArgs e)
        {
            checkListBox.UnselectAll();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
