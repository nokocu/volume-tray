using System;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces;
using Volume-Tray-Volumey.Model;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public class SessionCreatedEventArgs : EventArgs
	{
		public AudioSessionModel SessionModel;
		public IAudioSessionControl SessionControl;

		public SessionCreatedEventArgs(AudioSessionModel sessionModel, IAudioSessionControl sessionControl)
		{
			SessionModel = sessionModel;
			SessionControl = sessionControl;
		}
	}
}