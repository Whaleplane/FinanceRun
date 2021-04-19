using UnrealBuildTool;

public class FinanceRunTarget : TargetRules
{
	public FinanceRunTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FinanceRun");
	}
}
