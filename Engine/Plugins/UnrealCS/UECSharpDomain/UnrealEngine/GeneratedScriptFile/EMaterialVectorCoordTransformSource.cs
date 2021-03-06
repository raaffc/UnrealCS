using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialVectorCoordTransformSource:byte
	{
		/// <summary>Tangent space (relative to the surface)</summary>
		TRANSFORMSOURCE_Tangent=0,
		/// <summary>Local space (relative to the rendered object, = object space)</summary>
		TRANSFORMSOURCE_Local=1,
		/// <summary>World space, a unit is 1cm</summary>
		TRANSFORMSOURCE_World=2,
		/// <summary>View space (relative to the camera/eye, = camera space, differs from camera space in the shadow passes)</summary>
		TRANSFORMSOURCE_View=3,
		/// <summary>Camera space</summary>
		TRANSFORMSOURCE_Camera=4,
		/// <summary>Particle space</summary>
		TRANSFORMSOURCE_ParticleWorld=5,
		TRANSFORMSOURCE_MAX=6,
		
	}
	
}
