using Volume-Tray-Volumey.Model;

namespace Volume-Tray-Volumey.ViewModel.Settings
{
	public interface IAudioProcessStateMediator
	{
		void NotifyAudioStateChange(IManagedMasterAudioSession sender);
		void NotifyOfDisposing(IManagedMasterAudioSession sender);
	}
}