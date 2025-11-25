using System;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public interface IAudioSessionVolume
	{
		float GetVolume();

		void SetVolume(int newVolume, ref Guid context);

		bool GetMute();

		void SetMute(bool newState);
	}
}