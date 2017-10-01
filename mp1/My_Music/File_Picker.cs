using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace mp1.My_Music
{
    public sealed class File_Picker : Control
    {
        public File_Picker()
        {
            this.DefaultStyleKey = typeof(File_Picker);
        }

        public class MusicDataArrayList
        {

            String FileName;
            int TrackNo;
            String MusicTitle;
            String ArtistName;
            String AlbumName;

            public MusicDataArrayList(String FileName, int TrackNo, String music, String MusicTitle, String ArtistName, String AlbumName )
            {
                this.FileName = FileName;
                this.TrackNo = TrackNo;
                this.MusicTitle = MusicTitle;
                this.ArtistName = ArtistName;
                this.AlbumName = AlbumName;

            }

            public String Filename
            {
                get
                {
                    return FileName;
                }
                set
                {
                    this.FileName = value;
                }
            }

            public int Trackno
            {
                get
                {
                    return TrackNo;
                }
                set
                {
                    this.TrackNo = value;
                }
            }
            public String Musictitle
            {
                get
                {
                    return MusicTitle;
                }
                set
                {
                    this.MusicTitle = value;
                }
            }
            public String Artistname
            {
                get
                {
                    return ArtistName;
                }
                set
                {
                    this.ArtistName = value;
                }
            }
            public String Albumname
            {
                get
                {
                    return AlbumName;
                }
                set
                {
                    this.AlbumName = value;
                }

            }
        }



        public async Task<String> FileOpenPickAsync()
        {
            String FileName;
            
            var picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.Thumbnail;
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
                FileName =  output.ToString();
            }
            else
            {
                FileName = "Operation cancelled.";
            }

            return FileName;
        }
    }
}
