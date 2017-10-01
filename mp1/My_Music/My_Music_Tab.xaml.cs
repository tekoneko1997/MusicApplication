using mp1.Method;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace mp1.My_Music
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class My_Music_Tab : Page
    {

      //  private ListView listView1 = new ListView();
        private ScrollViewer scrollview = new ScrollViewer();

        public  My_Music_Tab()
        {
            this.InitializeComponent();
            
            // Create a new ListView and add content. 
            CreateListView();
                        
            // Add the ListView to a parent container in the visual tree. 
           // stackPanel1.Children.Add(listView1);
        }

        public async void CreateListView()
        {
            StorageFolder Folder ;

            var Filelist = new List<StorageFile>();
            var Folderlist = new List<StorageFolder>();
            var SubFolderlist = new List<StorageFolder>();
            var mru = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList;

            foreach (Windows.Storage.AccessCache.AccessListEntry entry in mru.Entries)
            {
                string token = entry.Token;
                string metadata = entry.Metadata;

                
                Folder = await mru.GetFolderAsync(entry.Token);
                Debug.WriteLine(Folder.Name + "\n");
                
                Folderlist.AddRange(await Folder.GetFoldersAsync());
                foreach (var folderlist in Folderlist)
                {
                    Debug.WriteLine(folderlist.Name + "\n");
                }

            }

            foreach (var filelist in Folderlist)
            {
                Filelist.AddRange(await filelist.GetFilesAsync());
                Debug.WriteLine(filelist.Name + "\n");                

            }
            foreach (var filelist in Filelist)
            {              
                Debug.WriteLine(filelist.Provider + "\n");

                listView1.Items.Add(filelist.DisplayName);

            }


        }
    }
}
