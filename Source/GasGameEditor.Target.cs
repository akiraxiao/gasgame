// CopyRight AkiStustio

using UnrealBuildTool;
using System.Collections.Generic;

public class GasGameEditorTarget : TargetRules
{
	public GasGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GasGame" } );
	}
}
