using UnrealBuildTool;

public class CSC567FinalTarget : TargetRules
{
	public CSC567FinalTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CSC567Final");
	}
}
