#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FSupportedSubTrackInfo
	{
		[FieldOffset(4)]
		public FString SubTrackName;
		[FieldOffset(16)]
		public int GroupIndex;
		
	}
	
}
#endif
#endif
