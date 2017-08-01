using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum TextureMipGenSettings:byte
	{
		TMGS_FromTextureGroup=0,
		TMGS_SimpleAverage=1,
		TMGS_Sharpen0=2,
		TMGS_Sharpen1=3,
		TMGS_Sharpen2=4,
		TMGS_Sharpen3=5,
		TMGS_Sharpen4=6,
		TMGS_Sharpen5=7,
		TMGS_Sharpen6=8,
		TMGS_Sharpen7=9,
		TMGS_Sharpen8=10,
		TMGS_Sharpen9=11,
		TMGS_Sharpen10=12,
		TMGS_NoMipmaps=13,
		TMGS_LeaveExistingMips=14,
		TMGS_Blur1=15,
		TMGS_Blur2=16,
		TMGS_Blur3=17,
		TMGS_Blur4=18,
		TMGS_Blur5=19,
		TMGS_MAX=20,
		
	}
	
}
