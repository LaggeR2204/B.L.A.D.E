using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NAudio.Wave;

namespace BLADE
{
    class MediaPlayer
    {
        private bool _isRepeat;
        private bool _isLoop;
        private bool _isShuffle;
        private List<string> _curPlaylist;
        private string _curMedia;
        private Timer timer;
        public event EventHandler MediaEnded;
        public event EventHandler MediaChanged;
        public bool IsRepeat { get => _isRepeat; set => _isRepeat = value; }
        public bool IsLoop { get => _isLoop; set => _isLoop = value; }
        public bool IsShuffle { get => _isShuffle; set => _isShuffle = value; }
        public string CurrentMedia { get => _curMedia; set => _curMedia = value; }
        public List<string> CurrentPlaylist { get => _curPlaylist; set => _curPlaylist = value; }

        DirectSoundOut outputSound = null;
        MediaFoundationReader audioReader = null;
        WaveChannel32 waveChanel = null;
        public MediaPlayer()
        {
            Init();
        }

        private void Init()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            _isRepeat = false;
            _isLoop = false;
            _isShuffle = true;
            CurrentMedia = null;
            _curPlaylist = new List<string>();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (audioReader.CurrentTime.TotalSeconds >= audioReader.TotalTime.TotalSeconds)
                if (MediaEnded != null)
                    MediaEnded(this, new EventArgs());
        }

        public void Play()
        {
            timer.Start();
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Paused)
                    outputSound.Play();
        }
        public void Pause()
        {
            timer.Stop();
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Playing)
                    outputSound.Pause();
        }
        public void Stop()
        {
            timer.Stop();
            if (outputSound != null)
                outputSound.Stop();
        }
        public void Next()
        {
            timer.Start();
            if (outputSound == null)
                return;
            int nowIndex = _curPlaylist.IndexOf(_curMedia);
            if (_isLoop)
            {
                if (nowIndex == _curPlaylist.Count - 1)
                    nowIndex = 0;
                else nowIndex++;
            }
            else
            if (_isShuffle)
            {
                Random ran = new Random();
                int nextIndex = ran.Next(_curPlaylist.Count - 1);
                while (nextIndex == nowIndex)
                    nextIndex = ran.Next(_curPlaylist.Count - 1);
                nowIndex = nextIndex;
            }
            _curMedia = _curPlaylist[nowIndex];
            PlayInIndex(nowIndex);
        }
        public void Previous()
        {
            timer.Start();
            if (outputSound == null)
                return;
            int nowIndex = _curPlaylist.IndexOf(_curMedia);
            if (_isLoop)
            {
                if (nowIndex == 0)
                    nowIndex = _curPlaylist.Count - 1;
                else nowIndex--;
            }
            else
            if (_isShuffle)
            {
                Random ran = new Random();
                int nextIndex = ran.Next(_curPlaylist.Count - 1);
                while (nextIndex == nowIndex)
                    nextIndex = ran.Next(_curPlaylist.Count - 1);
                nowIndex = nextIndex;
            }
            _curMedia = _curPlaylist[nowIndex];
            PlayInIndex(nowIndex);
        }
        public void AddSongToCurrentPlaylist(string src)
        {
            if (_curPlaylist.Contains(src))
                return;
            _curPlaylist.Add(src);
        }
        public void PlayInIndex(int src)
        {
            DisposeAudio();
            _curMedia = _curPlaylist[src];
            audioReader = new MediaFoundationReader(_curMedia);
            outputSound = new DirectSoundOut();
            waveChanel = new WaveChannel32(audioReader);
            outputSound.Init(waveChanel);
            outputSound.Play();
            if (MediaChanged != null)
                MediaChanged(this, new EventArgs());
            timer.Start();
        }
        public double GetDurationInSecond()
        {
            return audioReader.TotalTime.TotalSeconds;
        }
        public double GetCurrentPossiton()
        {
            return audioReader.CurrentTime.TotalSeconds;
        }
        public void SetVolume(float n)
        {
            if (waveChanel != null)
                waveChanel.Volume = n;

        }

        public void SetPossition(int n)
        {
            audioReader.CurrentTime = audioReader.CurrentTime.Add(TimeSpan.FromSeconds(n));
        }
        private void DisposeAudio()
        {
            if (outputSound != null)
            {
                if (outputSound.PlaybackState == PlaybackState.Playing)
                    outputSound.Stop();
                outputSound.Dispose();
                outputSound = null;
            }
            if (audioReader != null)
            {
                audioReader.Dispose();
                audioReader = null;
            }
        }



    }
}
