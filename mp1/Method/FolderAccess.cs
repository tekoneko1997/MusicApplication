using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace mp1.Method
{
    class FolderAccess
    {

        public StorageFolder folder;
        private string mruToken = string.Empty; //フォルダートークン
        


        public async Task FolderSelectSaveAsync()
        {

            /*--- フォルダの選択 ---*/
            var folderPicker = new Windows.Storage.Pickers.FolderPicker();
            folderPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.Desktop;
            folderPicker.FileTypeFilter.Add("*");
            /*--- folderに選んだフォルダを入れる ---*/
            folder = await folderPicker.PickSingleFolderAsync();

            /*--- アプリがaccessしたフォルダを保存 ---*/
            var mru = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList;
            mruToken = mru.Add(folder, "MusicFolder");
        }

        public async void FolderGet()
        {

            var Filelist = new List<StorageFile>();
            var Folderlist = new List<StorageFolder>();
            var SubFolderlist = new List<StorageFolder>();

            var accessList = Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList;
            accessList.Add(folder, folder.DisplayName);

            var mru = Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList;

            foreach (Windows.Storage.AccessCache.AccessListEntry entry in mru.Entries)
            {
                string token = entry.Token;
                string metadata = entry.Metadata;

                var f = await mru.GetFolderAsync(entry.Token);                
                Folderlist.AddRange(await f.GetFoldersAsync());

            }

            foreach (var folderlist in Folderlist)
            {
                Filelist.AddRange(await folderlist.GetFilesAsync());
                Folderlist.AddRange(await folderlist.GetFoldersAsync());
                Debug.WriteLine(folderlist.Name + "\n");
            }

          //  Filelist.AddRange(await folder.GetFilesAsync());

            foreach (var filelist in Filelist)
            {

                 Debug.WriteLine(filelist.Name + "\n");
            }

        }


    }
}
