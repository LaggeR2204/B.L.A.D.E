﻿using System;
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
using xNet;
using BLADE.xDialog;

namespace BLADE
{
    class SearchOnline
    {
        private string sSave = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).Replace("Pictures", "Downloads");
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
                songSearch.SongName = Regex.Match(song.ToString(), @"title=""(.*?)"">").Value.Replace("title=", "").Replace(">", "").Replace('"', ' ').Trim();
                songSearch.SongURL = Regex.Match(song.ToString(), @"href=""(.*?)""").Value.Replace("href=", "").Replace('"', ' ').Trim();
                songSearch.Singer = Regex.Match(song.ToString(), @"author"">(.*?)</div>").Value.Replace("author", "").Replace("</div>", "").Replace(">", "").Replace('"', ' ');
                songSearch.SongTime = Regex.Match(song.ToString(), @"<small class=""time_stt"">(.*?)</small>").Value.Replace("<small class=", "").Replace("time_stt", "").Replace("</small>", "").Replace(">", "").Replace('"', ' ').Trim();
                if (songSearch.SongName != "" && songSearch.SongTime != "")
                {
                    ucSongSearchDetail ucSongSearch = new ucSongSearchDetail(songSearch);
                    ucListSongSearch.Add(ucSongSearch);
                }
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

        public void Download(Song song)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = string.Format("Audio|{0}", ".mp3");
            save.FileName = song.SongName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                var thread = new Thread(
                  () =>
                  {
                      string htmlsong = FindFromURL(song.SongURL);
                      string htmlDownloadURL = Regex.Match(htmlsong, @"<a class=""download_item"" href=(.*?)128kbps</span>(.*?)</a>").Value;
                      string DownloadURL = Regex.Match(htmlDownloadURL, @"href=""(.*?)"" title").Value.Replace("href=", "").Replace("title", "").Replace('"', ' ').Trim();
                      WebClient wc = new WebClient();
                      wc.DownloadFile(DownloadURL, save.FileName);
                      MsgBox.Show("The download is complete !!!", "NOTIFICATION", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                  });
                thread.Start();
            }
        }
    }
}
