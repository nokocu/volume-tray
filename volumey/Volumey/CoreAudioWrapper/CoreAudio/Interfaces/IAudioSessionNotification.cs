using System.Runtime.InteropServices;
using Volume-Tray-Volumey.CoreAudioWrapper.Wrapper;

namespace Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces
{
    [Guid(GuidValue.External.IAudioSessionNotification), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAudioSessionNotification
    {
        [PreserveSig]
        int OnSessionCreated(IAudioSessionControl sessionControl);
    }
}
