using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BLADE
{
    public partial class ucPlaylist : UserControl
    {
        public event EventHandler SelectSong;

        public ucPlaylist()
        {
            InitializeComponent();
            //this.LoadLocalSong();
        }

        //private void loadListSong()
        //{
        //    DirectoryInfo dir = new DirectoryInfo(@"D:\Music");
        //    foreach (FileInfo file in dir.GetFiles())
        //    {
        //        if (file.Extension == ".mp3")
        //        {
        //            Song item = GetSongInfo(file);
        //            listSong.Add(item);
        //        }
        //    }
        //}
        //public void LoadLocalSong()
        //{
        //    loadListSong();
        //    foreach (Song song in listSong)
        //        addSongToPlaylistView(song);

        //}
        public void addSongToPlaylistView(Song song)
        {
            ucSongViewDetail songView = new ucSongViewDetail(song);
            songView.SelectedSong += click;
            this.fpnlSongView.Controls.Add(songView);
        }
        private void click(object sender, EventArgs e)
        {
            if (SelectSong != null)
            {
                SelectSong(sender.ToString(), e);
            }
        }
        //private Song GetSongInfo(FileInfo file)
        //{
        //    WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        //    IWMPMedia src = wmp.newMedia(file.FullName);
        //    Song song = new Song();
        //    song.SongName = src.getItemInfo("Name");
        //    song.SavePath = file.FullName;
        //    song.SongTime = src.getItemInfo("Duration");
        //    song.SingerName = src.getItemInfo("Artist");
        //    song.Genre = src.getItemInfo("WM/Genre");
        //    //song.SongImage = getImage(file.FullName);
        //    return song;
        //}

        //private Image getImage(string path)
        //{
        //    Image image;

        //    return image;
        //}
        //private void BtnAdd_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openfileDialog = new OpenFileDialog();
        //    openfileDialog.InitialDirectory = "c:\\";
        //    openfileDialog.Filter = "Audio (*.mp3)|*.mp3|All File|*.*";
        //    openfileDialog.FilterIndex = 2;
        //    openfileDialog.RestoreDirectory = true;

        //    if (openfileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        FileInfo file = new FileInfo(openfileDialog.FileName);
        //        Song song;
        //        if (file.Extension == ".mp3")
        //        {
        //            song = GetSongInfo(file);
        //            if (!listSong.Contains(song))
        //            {
        //                listSong.Add(song);
        //                addSongToPlaylistView(song);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Bai hat da ton tai!!!");
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Day khong phai file audio");
        //        }

        //    }
        //    openfileDialog.Dispose();
        //}
        private void ShowPlaylistInfo(Playlist src)
        {
            ucPlaylistView temp = new ucPlaylistView(src);
            temp.showContent += ShowPlaylist;
            fpnlPlaylistView.Controls.Add(temp);
        }

        private void clearSongViewList()
        {
            foreach (Control ctr in fpnlSongView.Controls)
            {
                fpnlSongView.Controls.Remove(ctr);
                ctr.Dispose();
            }
        }

        private void ShowPlaylist(object sender, EventArgs e)
        {
            clearSongViewList();
            List<Song> list = sender as List<Song>;
            foreach (Song song in list)
            {
                addSongToPlaylistView(song);
            }
        }

        private void BtnAddPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            string name = string.Copy("");
            InputNamePlaylistBox.Show("Input Name", "Nhap ten playlist: ", ref name);
            Playlist pl1 = new Playlist(name);
            ShowPlaylistInfo(pl1);
        }
    }
}
