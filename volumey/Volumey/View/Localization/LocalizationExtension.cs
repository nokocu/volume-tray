using System.Windows.Data;

namespace Volume-Tray-Volumey.Localization
{
	public class LocalizationExtension : Binding
	{
		public LocalizationExtension(string name) : base($"[{name}]")
		{
			this.Mode = BindingMode.OneWay;
			this.Source = TranslationSource.Instance;
		}
	}
}