using System.Runtime.InteropServices;
using Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Enums;
using Volume-Tray-Volumey.CoreAudioWrapper.Wrapper;

namespace Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces
{
	[Guid(GuidValue.External.IMMEndpoint), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IMMEndpoint
	{
		/// <summary>
		/// Gets the dataflow of the Endpoint device
		/// </summary>
		/// <param name="flow"></param>
		/// <returns></returns>
		int GetDataFlow([Out] out EDataFlow flow);
	}
}