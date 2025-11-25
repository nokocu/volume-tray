using System.Collections.Generic;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces;
using Volume-Tray-Volumey.Model;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public interface IDeviceEnumerator
	{
		IMMDeviceEnumerator MMDeviceEnumerator { get; }

		uint GetDeviceCount();

		string GetDefaultDeviceId();

		List<OutputDeviceModel> GetCurrentActiveDevices(IDeviceStateNotificationHandler dsn);
	}
}