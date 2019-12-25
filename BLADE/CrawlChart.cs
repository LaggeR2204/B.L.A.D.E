using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using xNet;
using BLADE.xDialog;

namespace BLADE
{
    class CrawlChart
    {
        private string sSave = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).Replace("Pictures", "Downloads");
        HttpClient httpClient;
        HttpClientHandler handler;
        CookieContainer cookie = new CookieContainer();

        public List<ucSongChartDetail> CrawlChartFromCSN(string nation)
        {
            try
            {
                List<ucSongChartDetail> ucListSongChart = new List<ucSongChartDetail>();
                for (int i = 1; i <= 10; i++)
                {
                    Song songChart = new Song();
                    string songURL = "https://chiasenhac.vn/nhac-hot/" + nation + ".html?playlist=" + i;
                    songChart = CrawlSongInChart(songURL);
                    songChart.SongNumber = i;
                    ucSongChartDetail ucSongChart = new ucSongChartDetail(songChart);
                    ucListSongChart.Add(ucSongChart);
                }

                return ucListSongChart;
            }
            catch (WebException exception)
            {
                MessageBox.Show("Crawl Chart Error" + exception.Message);
                return new List<ucSongChartDetail>();
            }
        }


        private Song CrawlSongInChart(string songURL)
        {
            string htmlSong = FindFromURL(songURL);
            string songInfo = Regex.Match(htmlSong.ToString(), @"<div class=""d-flex justify-content-between mb-3 box1 music-listen-title(.*?)</div", RegexOptions.Singleline).Value;

            Song songChart = new Song();
            songChart.SongName = Regex.Match(songInfo.ToString(), @"class=""title"">(.*?)-").Value.Replace("class=", "").Replace("title", "").Replace(">", "").Replace("-","").Replace('"',' ').Trim();
            songChart.SongURL = songURL;
            songChart.Singer = Regex.Match(songInfo.ToString(), @"-(.*?)</h1>").Value.Replace("-", "").Replace("</h1>", "").Trim();
            songChart.SongTime = Regex.Match(songInfo.ToString(), @"headset</i>(.*?)&").Value.Replace("headset</i>", "").Replace("&", "").Trim();
            
            return songChart;
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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = string.Format("Audio|{0}", ".mp3");
            save.FileName = songName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                var thread = new Thread(
                  () =>
                  {
                      string htmlsong = FindFromURL(songURL);
                      string htmlDownloadURL = Regex.Match(htmlsong, @"<a class=""download_item(.*?)128kbps").Value;
                      string DownloadURL = Regex.Match(htmlDownloadURL, @"href=""(.*?)""\stitle=").Value.Replace("href=", "").Replace("title=", "").Replace('"', ' ').Trim();
                      WebClient wc = new WebClient();
                      wc.DownloadFile(DownloadURL, save.FileName);
                      MsgBox.Show("The download is complete !!!", "NOTIFICATION", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                  });
                thread.Start();
            }
        }
    }
}
