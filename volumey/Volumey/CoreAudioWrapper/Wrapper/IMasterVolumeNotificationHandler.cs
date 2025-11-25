using System;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public interface IMasterVolumeNotificationHandler : IAudioEndpointVolumeCallback, IDisposable
	{
		event Action<VolumeChangedEventArgs> VolumeChanged;
	}
}