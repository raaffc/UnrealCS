#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FBlueprintCookedComponentInstancingData
	{
		public bool bIsValid
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		public TStructArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBlueprintComponentChangedPropertyInfo>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
