using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using xNet;

namespace BLADE
{
    class SearchOnline
    {

        const string sSave = @"D:\\Music\\";
        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();


        public List<ucSongSearchDetail> Search(string _SongName)
        {
            try
            {
                string path = "https://chiasenhac.vn/tim-kiem?q=" + _SongName.Replace(" ", "+").Trim();
                return Crawl(path);
            }
            catch (WebException exception)
            {
                MessageBox.Show("Search Error" + exception.Message);
                return new List<ucSongSearchDetail>();
            }
        }


        List<ucSongSearchDetail> Crawl(string searchURL)
        {

            string htmlKQ = FindFromURL(searchURL);
            List<ucSongSearchDetail> ucListSongSearch = new List<ucSongSearchDetail>();
            var songList = Regex.Matches(htmlKQ, @"<div class=""media-left(.*?)</li>", RegexOptions.Singleline);

            foreach (var song in songList)
            {
                Song songSearch = new Song();
                songSearch.SongName = Regex.Match(song.ToString(), @"title=""(.*?)"">").Value.Replace("title=", "").Replace(">", "").Replace('"', ' ');
                songSearch.SongURL = Regex.Match(song.ToString(), @"href=""(.*?)""").Value.Replace("href=", "").Replace('"', ' ').Trim();
                songSearch.Singer = Regex.Match(song.ToString(), @"author"">(.*?)</div>").Value.Replace("author", "").Replace("</div>", "").Replace(">", "").Replace('"', ' ');
                songSearch.SongTime = Regex.Match(song.ToString(), @"<small class=""time_stt"">(.*?)</small>").Value.Replace("<small class=", "").Replace("time_stt", "").Replace("</small>", "").Replace(">", "").Replace('"', ' ').Trim();
                ucSongSearchDetail ucSongSearch = new ucSongSearchDetail(songSearch);
                ucListSongSearch.Add(ucSongSearch);
            }
            return ucListSongSearch;
        }

        public string FindFromURL(string path)
        {
            string html = "";
            InitHttpClient();
            html = httpClient.GetStringAsync(path).Result;
            return html;
        }

        void InitHttpClient()
        {
            handler = new HttpClientHandler
            {
                CookieContainer = cookie,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false
            };

            httpClient = new HttpClient(handler);
            httpClient.BaseAddress = new Uri("https://chiasenhac.vn");
        }

        public void Download(string songName, string songURL)
        {
            string htmlsong = FindFromURL(songURL);
            string htmlDownloadURL = Regex.Match(htmlsong, @"<a class=""download_item(.*?)128kbps").Value;
            string DownloadURL = Regex.Match(htmlDownloadURL, @"href=""(.*?)""\stitle=").Value.Replace("href=", "").Replace("title=", "").Replace('"', ' ').Trim();
            WebClient wc = new WebClient();
            wc.DownloadFile(DownloadURL, sSave + songName + ".mp3");
        }
    }
}
