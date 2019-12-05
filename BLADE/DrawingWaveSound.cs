using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace BLADE
{
    class DrawingWaveSound
    {
        public delegate void NotifySampleHandler(object sender, SampleEventArgs e);
        public event NotifySampleHandler NotifySample;
        private WasapiLoopbackCapture _audioSource;
        private BufferedWaveProvider _provider;
        private WaveOut _player;
        public WasapiLoopbackCapture AudioSource
        { 
            get => _audioSource;
            set
            {
                _audioSource = value;
               
            }
        }
        public BufferedWaveProvider Provider { get => _provider; set => _provider = value; }
        public WaveOut Player { get => _player; set => _player = value; }
        public int Count { get => _count; set => _count = value; }
        public int Speed { get => _speed; }
        public float LeftMax { get => _leftMax; set => _leftMax = value; }
        public float RightMax { get => _rightMax; set => _rightMax = value; }
        public object SampleObject { get => _sampleObject; set => _sampleObject = value; }
        public NotifyingSampleProvider Notify { get => _notify; set => _notify = value; }

        private int _count;
        private const int _speed = 1;
        private float _leftMax, _rightMax;
        private object _sampleObject;
        private NotifyingSampleProvider _notify;

        public DrawingWaveSound()
        {
            _audioSource = new WasapiLoopbackCapture();
            _audioSource.DataAvailable += _audioSource_DataAvailable;
            _provider = new BufferedWaveProvider(new WaveFormat());
            _player = new WaveOut();
            _sampleObject = new object();
            _notify = new NotifyingSampleProvider(_provider.ToSampleProvider());
            _notify.Sample += _notify_Sample;
        }

        private void _notify_Sample(object sender, SampleEventArgs e)
        {
            if (NotifySample != null)
                NotifySample(this, e);
        }

        private void _audioSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            BufferPlay(e.Buffer);
        }
        private void BufferPlay(byte[] recv)
        {
            if(recv.Length > 0)
            {
                _provider.AddSamples(recv, 0, recv.Length);
            }
        }
        private void StartAudio()
        {
            _audioSource.StartRecording();
            _player.Init(_notify);
            _player.Play();
        }
        private void StopAudio()
        {
            if (_player == null) return;
            _player.Dispose();
            _player.Stop();
            _provider.ClearBuffer();
        }


    }
}
