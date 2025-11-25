using System;
using System.Collections.Generic;
using Volume-Tray-Volumey.Controls;

namespace Volume-Tray-Volumey.Helper
{
	public interface IHotkeyManager : IDisposable
	{
		event Action<HotKey> HotkeyPressed;
		int RegisteredHotkeysCount { get; }
		IReadOnlyList<HotKey> GetRegisteredHotkeys();
		void RegisterHotkey(HotKey key);
		void UnregisterHotkey(HotKey key);
	}
}