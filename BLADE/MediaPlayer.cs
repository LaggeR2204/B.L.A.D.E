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
        private List<Song> _curPlaylist;
        private Song _curMedia;
        private Timer _timer;
        private PlaybackState _playbackState;
        public event EventHandler MediaEnded;
        public event EventHandler MediaChanged;
        public event EventHandler PlaybackStateChanged;
        public PlaybackState MediaState 
        {
            get => _playbackState; 
            set
            {
                if (_playbackState != value)
                {
                    _playbackState = value;
                    if (PlaybackStateChanged != null)
                        PlaybackStateChanged(_playbackState, new EventArgs());
                }
            }
        }
        public bool IsRepeat { get => _isRepeat; set => _isRepeat = value; }
        public Timer MediaTimer { get => _timer; }
        public bool IsLoop { get => _isLoop; set => _isLoop = value; }
        public bool IsShuffle { get => _isShuffle; set => _isShuffle = value; }
        public Song CurrentMedia { get => _curMedia; set => _curMedia = value; }
        public List<Song> CurrentPlaylist { get => _curPlaylist; set => _curPlaylist = value; }

        DirectSoundOut outputSound = null;
        MediaFoundationReader audioReader = null;
        WaveChannel32 waveChanel = null;
        public MediaPlayer()
        {
            Init();
        }

        private void Init()
        {
            _timer = new Timer();
            _timer.Interval = 2000;
            _timer.Elapsed += Timer_Elapsed;
            SetPlaybackMode(false, true, false);
            CurrentMedia = null;
            _curPlaylist = new List<Song>();
            _playbackState = PlaybackState.Stopped;
        }
        public void SetPlaybackMode(bool loop, bool shuffle, bool repeat)
        {
            _isLoop = loop;
            _isShuffle = shuffle;
            _isRepeat = repeat;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (audioReader.CurrentTime.TotalSeconds >= audioReader.TotalTime.TotalSeconds)
                if (MediaEnded != null)
                    MediaEnded(this, new EventArgs());
        }

        public void Play()
        {
            if (_timer.Enabled == false)
                _timer.Start();
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Paused)
                {
                    outputSound.Play();
                    MediaState = PlaybackState.Playing;
                }
                  
        }
        public void Pause()
        {
            if (_timer.Enabled == true)
                _timer.Stop();
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Playing)
                {
                    outputSound.Pause();
                    MediaState = PlaybackState.Paused;
                }
                  
        }
        public void Stop()
        {
            if (_timer.Enabled == true)
                _timer.Stop();
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Playing)
                {
                    outputSound.Stop();
                    MediaState = PlaybackState.Stopped;
                }

        }
        public void Next()
        {
            if (_timer.Enabled == false)
                _timer.Start();
            if (_curPlaylist.Count == 1)
            {
                PlayInIndex(0);
                return;
            }
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
                int nextIndex = ran.Next(_curPlaylist.Count);
                while (nextIndex == nowIndex)
                    nextIndex = ran.Next(_curPlaylist.Count);
                nowIndex = nextIndex;
            }
            PlayInIndex(nowIndex);
        }
        public void Previous()
        {
            if (_timer.Enabled == false)
                _timer.Start();
            if (_curPlaylist.Count == 1)
            {
                PlayInIndex(0);
                return;
            }
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
                int nextIndex = ran.Next(_curPlaylist.Count);
                while (nextIndex == nowIndex)
                    nextIndex = ran.Next(_curPlaylist.Count);
                nowIndex = nextIndex;
            }
            PlayInIndex(nowIndex);
        }
        public void AddSongToCurrentPlaylist(Song src)
        {
            if (_curPlaylist.Contains(src))
                return;
            _curPlaylist.Add(src);
        }
        public void PlayInIndex(int src)
        {
            DisposeAudio();
            _curMedia = _curPlaylist[src];
            audioReader = new MediaFoundationReader(_curMedia.SavedPath);
            outputSound = new DirectSoundOut();
            waveChanel = new WaveChannel32(audioReader);
            outputSound.Init(waveChanel);
            outputSound.Play();
            if (MediaChanged != null)
                MediaChanged(this, new EventArgs());
            _timer.Start();
            MediaState = PlaybackState.Playing;
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
