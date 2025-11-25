using System.Windows;
using Volume-Tray-Volumey.Helper;
using Volume-Tray-Volumey.Model;

namespace Volume-Tray-Volumey.ViewModel.Settings
{
	public class AudioProcessStateNotificationMediator : IAudioProcessStateMediator
	{
		public void NotifyAudioStateChange(IManagedMasterAudioSession sender)
		{
			Application.Current.Dispatcher.InvokeAsync(() =>
			{
				NotificationManagerHelper.ShowNotification(sender);
			});
		}

		public void NotifyOfDisposing(IManagedMasterAudioSession sender)
		{
			Application.Current.Dispatcher.InvokeAsync(() =>
			{
				NotificationManagerHelper.CloseNotification(sender);
			});
		}
	}
}