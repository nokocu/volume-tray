using System;
using System.Runtime.InteropServices;
using Volume-Tray-Volumey.CoreAudioWrapper.Wrapper;

namespace Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces
{
    [Guid(GuidValue.External.IAudioEndpointVolumeCallback), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAudioEndpointVolumeCallback
    {
        [PreserveSig]
        int OnNotify(IntPtr dataPtr);
    }
}
