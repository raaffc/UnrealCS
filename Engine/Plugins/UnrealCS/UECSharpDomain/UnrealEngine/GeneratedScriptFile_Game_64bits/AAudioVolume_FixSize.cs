#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AAudioVolume
	{
		static readonly int Priority__Offset;
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int bEnabled__Offset;
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Settings__Offset;
		public FReverbSettings Settings
		{
			get{ CheckIsValid();return (FReverbSettings)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FReverbSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Settings__Offset, false);}
			
		}
		
		static readonly int AmbientZoneSettings__Offset;
		public FInteriorSettings AmbientZoneSettings
		{
			get{ CheckIsValid();return (FInteriorSettings)Marshal.PtrToStructure(_this.Get()+AmbientZoneSettings__Offset, typeof(FInteriorSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AmbientZoneSettings__Offset, false);}
			
		}
		
		static AAudioVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AudioVolume");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			AmbientZoneSettings__Offset=GetPropertyOffset(NativeClassPtr,"AmbientZoneSettings");
			
		}
		
	}
	
}
#endif
#endif
