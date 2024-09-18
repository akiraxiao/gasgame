// CopyRight AkiStustio

using UnrealBuildTool;
using System.Collections.Generic;

public class GasGameTarget : TargetRules
{
	public GasGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GasGame" } );
	}
}
