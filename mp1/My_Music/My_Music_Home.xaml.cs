using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.Storage.Search;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace mp1.My_Music
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class My_Music_Home : Page
    {
        public My_Music_Home()
        {
            this.InitializeComponent();


        }



        private async void Button(object sender, RoutedEventArgs e)
        {
            /*
            var picker = new FileOpenPicker();
            
            picker.ViewMode = PickerViewMode.List;
            picker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            picker.FileTypeFilter.Add(".mp3");

            var files = await picker.PickMultipleFilesAsync();
            if (files.Count > 0)
            {
                StringBuilder output = new StringBuilder("Picked files:\n");

                // Application now has read/write access to the picked file(s)
                foreach (Windows.Storage.StorageFile file in files)
                {
                    output.Append(file.Name + "\n");
                }
                Debug.WriteLine(output.ToString());
            }
            else
            {
                Debug.WriteLine("Operation cancelled.");
            }

            Debug.WriteLine("FinAndGo");
            
            var storage = Windows.Storage.KnownFolders.MusicLibrary;
            var filess = await storage.GetFilesAsync();
            var folderPicker = new Windows.Storage.Pickers.FolderPicker();

            // ピクチャライブラリの一番目のファイル要素を取得
            var firstItem = filess.First();
            var dlg = new MessageDialog(firstItem.Name);
            await dlg.ShowAsync();
            */


        }
    }
}
