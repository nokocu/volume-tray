using System.Runtime.InteropServices;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Enums;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public class PolicyClient
	{
		[ComImport, Guid(GuidValue.External.PolicyConfigCOM)]
		private class PolicyClientCOM { }
		
		private IPolicyConfig instance = new PolicyClientCOM() as IPolicyConfig;

		public void SetDefaultEndpointDevice(string deviceId)
		{
			this.instance.SetDefaultEndpoint(deviceId, ERole.Console);
			this.instance.SetDefaultEndpoint(deviceId, ERole.Multimedia);
			this.instance.SetDefaultEndpoint(deviceId, ERole.Communications);
		}
	}
}