using System.Runtime.InteropServices;
using Volume-Tray-Volumey.CoreAudioWrapper.Wrapper;

namespace Volume-Tray-Volumey.CoreAudioWrapper.CoreAudio.Interfaces
{
    [Guid(GuidValue.External.IAudioSessionEnumerator), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAudioSessionEnumerator
    {
        [PreserveSig]
        int GetCount([Out][MarshalAs(UnmanagedType.I4)] out int sessionCount);

        [PreserveSig]
        int GetSession([In][MarshalAs(UnmanagedType.I4)] int sessionCount, [Out] out IAudioSessionControl session);
    }
}
