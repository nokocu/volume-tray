using System.Collections.Generic;
using Volume-Tray-Volumey.Model;

namespace Volume-Tray-Volumey.DataProvider
{
	public interface IScreenInfoProvider
	{
		ScreenInfo GetPrimaryScreenInfo();
		IEnumerable<ScreenInfo> GetAllScreensInfo();
	}
}