using System;

namespace Volume-Tray-Volumey.CoreAudioWrapper.Wrapper
{
	public readonly struct BLOB
	{
		public readonly ulong cbSize;
		public readonly IntPtr blobData;

		public BLOB(ulong size, IntPtr data)
		{
			this.cbSize = size;
			this.blobData = data;
		}
	}
}