//GENERATED: C++ Code
#pragma once

class UScrollBar_
{
	static void SetState(UScrollBar* _this,float InOffsetFraction,float InThumbSizeFraction)
	{
		_this->SetState(InOffsetFraction,InThumbSizeFraction);
		
	}
	static UClass* _StaticClassForProxy(){return UScrollBar::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UScrollBar::SetState",(const void*)SetState);
		mono_add_internal_call("UnrealEngine.UScrollBar::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;