#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class of communication channels.</summary>
	public partial class UChannel
	{
		static readonly int Connection__Offset;
		public UNetConnection Connection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Connection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static UChannel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Channel");
			Connection__Offset=GetPropertyOffset(NativeClassPtr,"Connection");
			
		}
		
	}
	
}
#endif
#endif
