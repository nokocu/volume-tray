using System;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public interface ISessionProvider : IAudioSessionNotification, IDisposable
	{
		event Action<object, SessionCreatedEventArgs> SessionCreated;
	}
}