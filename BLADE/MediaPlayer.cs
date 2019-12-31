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
        //DirectSoundOut outputSound = null;
        //MediaFoundationReader audioReader = null;
        //WaveChannel32 waveChanel = null;
        private WaveOutEvent outputSound;
       // private AudioFileReader audioReader;
        private bool _isRepeat;
        private bool _isLoop;
        private bool _isShuffle;
        private List<Song> _curPlaylist;
        private Song _curMedia;
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
        public bool IsLoop { get => _isLoop; set => _isLoop = value; }
        public bool IsShuffle { get => _isShuffle; set => _isShuffle = value; }
        public Song CurrentMedia { get => _curMedia; set => _curMedia = value; }
        public List<Song> CurrentPlaylist { get => _curPlaylist; set => _curPlaylist = value; }

       
        public MediaPlayer()
        {
            Init();
        }

        private void Init()
        {
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
        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    if (audioReader == null)
        //        return;
        //    if (audioReader.CurrentTime.TotalSeconds >= audioReader.TotalTime.TotalSeconds - 2)
        //        if (MediaEnded != null)
        //            MediaEnded(this, new EventArgs());
        //}

        public void Play()
        {
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Paused)
                {
                    outputSound.Play();
                    MediaState = PlaybackState.Playing;
                    CurrentMedia.IsPlaying = PlaybackState.Playing;
                }

        }
        public void Pause()
        {
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Playing)
                {
                    outputSound.Pause();
                    MediaState = PlaybackState.Paused;
                    CurrentMedia.IsPlaying = PlaybackState.Paused;
                }

        }
        public void Stop()
        {
            if (outputSound != null)
                if (outputSound.PlaybackState == PlaybackState.Playing)
                {
                    outputSound.Stop();
                    MediaState = PlaybackState.Stopped;
                    CurrentMedia.IsPlaying = PlaybackState.Stopped;
                }

        }
        public void Next()
        {
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
        public bool AddSongToCurrentPlaylist(Song src)
        {
            if (_curPlaylist.Contains(src))
                return false;
            _curPlaylist.Add(src);
            return true;
        }
        public void PlayInIndex(int src)
        {
            DisposeAudio();
            if (_curPlaylist != null)
                if (src < _curPlaylist.Count && src >=0)
                {
                    if (_curMedia != null)
                        _curMedia.IsPlaying = PlaybackState.Stopped;
                    _curMedia = _curPlaylist[src];
                    //audioReader = new AudioFileReader(_curMedia.SavedPath);
                    outputSound = new WaveOutEvent();
                    outputSound.PlaybackStopped += OutputSound_PlaybackStopped;
                    // waveChanel = new WaveChannel32(audioReader);
                    _curMedia.AudioFile.Position = 0;
                    outputSound.Init(_curMedia.AudioFile);
                    outputSound.Play();
                    if (MediaChanged != null)
                        MediaChanged(this, new EventArgs());
                    MediaState = PlaybackState.Playing;
                    _curMedia.IsPlaying = PlaybackState.Playing;
                }
        }

        private void OutputSound_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if(_playbackState != PlaybackState.Stopped)
            {
                if (MediaEnded != null)
                    MediaEnded(this, new EventArgs());
            }

        }

        public double GetDurationInSecond()
        {
            //if (audioReader == null)
            //    return 0;
            //return audioReader.TotalTime.TotalSeconds;
            if (_curMedia.AudioFile == null)
                return 0;
            return _curMedia.AudioFile.TotalTime.TotalSeconds;
        }
        public double GetCurrentPossiton()
        {
            //if (audioReader == null)
            //    return 0;
            //return audioReader.CurrentTime.TotalSeconds;
            if (_curMedia.AudioFile == null)
                return 0;
            return _curMedia.AudioFile.CurrentTime.TotalSeconds;
        }
        public void SetVolume(float n)
        {
            //if (waveChanel != null)
            //    waveChanel.Volume = n;
            if (outputSound != null)
                outputSound.Volume = n;
        }

        public void SetPossition(int n)
        {
            //if (audioReader == null)
            //    return;
            //audioReader.CurrentTime = TimeSpan.FromSeconds(n);
            if (_curMedia.AudioFile == null)
                return;
            _curMedia.AudioFile.CurrentTime = TimeSpan.FromSeconds(n);
        }
        public void DisposeAudio()
        {
            if (outputSound != null)
            {
                outputSound.PlaybackStopped -= OutputSound_PlaybackStopped;
                outputSound.Dispose();
                outputSound = null;
            }
            //if (audioReader != null)
            //{
            //    audioReader.Dispose();
            //    audioReader = null;
            //}
        }
    }
}
