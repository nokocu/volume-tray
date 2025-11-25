using System;
using System.Globalization;
using System.Windows.Data;
using Volumey.Localization;

namespace Volumey.View.Converters
{
	public class TrayTooltipDeviceNameConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo cltr)
		{
			if(values == null)
				return Binding.DoNothing;

			if(values[0] is true) //bool DeviceProvider.NoOutputDevices
				return TranslationSource.Instance[TranslationSource.NoDeviceCaptionKey];
			
			if(values[1] is string deviceName)
				return $"{deviceName}: ";

			return Binding.DoNothing;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo cltr)
			=> null;
	}
}