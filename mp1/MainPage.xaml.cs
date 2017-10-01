using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace mp1
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            MainFrame.Navigate(typeof(My_Music.My_Music_Home));

        }

        /*-- トグルボタンんがチェックされているとき --*/
        private void ToggleButtonSplitView_Checked(object sender, RoutedEventArgs e)
        {
            /*-- 検索ボックスの表示、非表示 --*/
            SearchBox.Visibility = Visibility.Visible;
            SearchButton.Visibility = Visibility.Collapsed;

            /*-- 再生リストの”＋”の位置が再生リストの横に行くようにする --*/
            Grid.SetRow(NewPlayListButton,0);
            Grid.SetColumn(NewPlayListButton,1);

            /*-- 設定の位置がサインインの横に行くようにする --*/
            Grid.SetRow(SettingsButton, 0);
            Grid.SetColumn(SettingsButton, 1);

            //Debug.WriteLine("VISION");
        }
        /*-- トグルボタンんがチェックされていないとき --*/
        private void ToggleButtonSplitView_UnChecked(object sender, RoutedEventArgs e)
        {
            /*-- 検索ボックスの表示、非表示 --*/
            SearchBox.Visibility = Visibility.Collapsed;
            SearchButton.Visibility = Visibility.Visible;

            /*-- 再生リストの”＋”の位置が再生リストの下に行くようにする --*/
            Grid.SetRow(NewPlayListButton, 1);
            Grid.SetColumn(NewPlayListButton, 0);


            /*-- 設定の位置がサインインの下に行くようにする --*/
            Grid.SetRow(SettingsButton, 1);
            Grid.SetColumn(SettingsButton, 0);

            //Debug.WriteLine("UNVISION");
        }

        private void SearchButton_Checked(object sender, RoutedEventArgs e)
        {
            Splitter.IsPaneOpen = true;
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(My_Music.My_Music_Home));
            Splitter.IsPaneOpen = false;
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(typeof(New_Register));
            Splitter.IsPaneOpen = false;
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(typeof(New_Register));
            Splitter.IsPaneOpen = false;
        }

        private void RadioButton4_Checked(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(typeof(New_Register));
            Splitter.IsPaneOpen = false;
        }

  
        private void MainContentFrame_Navigated(System.Object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            /*            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                                MainFrame.CanGoBack ?
                                AppViewBackButtonVisibility.Visible :
                                AppViewBackButtonVisibility.Collapsed;
              */
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Setting));
            Splitter.IsPaneOpen = false;
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(typeof(New_Register)); 
            Splitter.IsPaneOpen = false;
        }

        private void NewPlayList_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
